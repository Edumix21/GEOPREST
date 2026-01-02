using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEOPREST.com.distribucionBinomial.data;

namespace GEOPREST.com.views {
    public partial class MenuDistBinomial : Form {
        public List<ProblemaDistBinomial> lista { get; private set; }

        public MenuDistBinomial() {
            InitializeComponent();
        }

        // Método actualizado para dar formato de incisos (a, b, c) sin repetir el total de ensayos
        private string FormatearProblemas(List<ProblemaDistBinomial> lista) {
            StringBuilder sb = new StringBuilder();
            int problemaPrincipalIndex = 1;

            // Iterar la lista en grupos de 4 (un problema principal contiene 4 sub-preguntas)
            for (int i = 0; i < lista.Count; i += 4) {
                if (i + 3 >= lista.Count) {
                    break;
                }

                ProblemaDistBinomial problemaBase = lista[i];

                sb.AppendLine($"-------- Problema {problemaPrincipalIndex++} --------");
                // La descripción ya incluye el porcentaje formateado y la frase de contexto "Se realizan N ensayos"
                sb.AppendLine(problemaBase.Descripcion);
                sb.AppendLine("Calcule lo siguiente:");

                // Array para los incisos
                string[] incisos = { "a)", "b)", "c)", "d)" };

                // Recorre las 4 subpreguntas
                for (int j = 0; j < 4; j++) {
                    ProblemaDistBinomial subProblema = lista[i + j];
                    string enunciadoTipo = "";
                    string k_sub = subProblema.K.ToString();

                    // Fraseo más limpio como lo pediste
                    switch (subProblema.TipoPregunta) {
                        case "exacto":
                            enunciadoTipo = $"La probabilidad de obtener exactamente {k_sub} éxitos.";
                            break;
                        case "a lo sumo":
                            enunciadoTipo = $"La probabilidad de obtener a lo sumo {k_sub} éxitos.";
                            break;
                        case "al menos":
                            enunciadoTipo = $"La probabilidad de obtener al menos {k_sub} éxitos.";
                            break;
                        case "intervalo":
                            enunciadoTipo = $"La probabilidad de obtener entre {subProblema.KInferior} y {k_sub} éxitos.";
                            break;
                    }
                    // Agrega el inciso y el texto
                    sb.AppendLine($"    {incisos[j]} {enunciadoTipo}");
                }
                sb.AppendLine(); // Salto de línea entre problemas principales
            }
            return sb.ToString();
        }

        // Método actualizado para mostrar respuestas claras
        private string FormatearRespuestas(List<ProblemaDistBinomial> lista) {
            StringBuilder sb = new StringBuilder();
            int problemaPrincipalIndex = 1;

            for (int i = 0; i < lista.Count; i += 4) {
                if (i + 3 >= lista.Count) {
                    break;
                }

                ProblemaDistBinomial problemaBase = lista[i];
                string[] incisos = { "a)", "b)", "c)", "d)" };

                sb.AppendLine($"-------- Respuestas Problema {problemaPrincipalIndex++} --------");
                // Mostramos datos clave para referencia rápida del profesor
                sb.AppendLine($"Datos: n = {problemaBase.Ensayos}, p = {problemaBase.ProbabilidadExito:F2}");

                for (int j = 0; j < 4; j++) {
                    ProblemaDistBinomial subProblema = lista[i + j];

                    // Formatear la probabilidad
                    string valorProbabilidad;
                    if (subProblema.Respuesta == 0.0) {
                        valorProbabilidad = "0";
                    } else if (subProblema.Respuesta < 0.0001 && subProblema.Respuesta > 0) {
                        valorProbabilidad = subProblema.Respuesta.ToString("E4"); // Notación científica para valores muy bajos
                    } else {
                        valorProbabilidad = subProblema.Respuesta.ToString("F4"); // 4 decimales estándar
                    }

                    sb.AppendLine($"    {incisos[j]} {subProblema.TipoPregunta} (k={subProblema.K}): {valorProbabilidad}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                // 1. Recolección de datos desde la interfaz
                int numProb = int.Parse(numProblemas.Text);
                int ensayosMin = int.Parse(minEnsayos.Text);
                int ensayosMax = int.Parse(maxEnsayos.Text);
                double probMin = double.Parse(minProb.Text);
                double probMax = double.Parse(maxProb.Text);
                string descripcion = ejercicioTxt.Text;

                // 2. Validación de datos básica
                if (numProb <= 0 || ensayosMin > ensayosMax || probMin > probMax || probMin < 0 || probMax > 1) {
                    MessageBox.Show("Verifica que los datos estén correctamente ingresados (Probabilidad entre 0 y 1, Min < Max).");
                    return;
                }

                // 3. Obtener el Texto de Contexto N (Nuevo paso)
                string contextoN = "Se realizan {n} ensayos."; // Valor por defecto si es manual

                // Si hay un problema seleccionado en el combo, intentamos sacar su contexto específico
                if (ProblemasPredefinidos.SelectedIndex >= 0) {
                    ProblemasPredefinidosDB pHelper = new ProblemasPredefinidosDB();
                    // Cargamos el problema para ver su textoContextoN
                    var problemaSeleccionado = pHelper.CargarProblema(ProblemasPredefinidos.SelectedIndex);

                    // Usamos el contexto del problema predefinido. 
                    // (Opcional: Podrías comparar si descripcion == problemaSeleccionado.ejercicio para asegurarte 
                    // que el usuario no cambió el texto manualmente, pero generalmente está bien usar el del combo).
                    contextoN = problemaSeleccionado.textoContextoN;
                }

                // 4. Generar problemas pasando el nuevo parámetro
                DistBinomial generador = new DistBinomial();
                // AQUÍ SE PASA EL CONTEXTO 'N'
                generador.GenerarProblemas(numProb, descripcion, contextoN, ensayosMin, ensayosMax, probMin, probMax);

                lista = generador.ObtenerProblemas();

                // 5. Formatear y mostrar
                mostrarDatos.Text = FormatearProblemas(lista);
                mostrarDatos1.Text = FormatearRespuestas(lista);

                ActivateXMLButton();

            } catch (Exception ex) {
                MessageBox.Show("Error al procesar los datos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            numProblemas.Text = "";
            minEnsayos.Text = "";
            maxEnsayos.Text = "";
            minProb.Text = "";
            maxProb.Text = "";
            ejercicioTxt.Text = "";
            // tipoPregunta.SelectedIndex = 0; // Si ya no usas este combo, puedes comentarlo
            ProblemasPredefinidos.SelectedIndex = -1; // Resetear combo
        }

        // Método para activar el botón XML si hay datos
        private void ActivateXMLButton() {
            if (!string.IsNullOrEmpty(mostrarDatos.Text)) {
                Color buttonActivated = Color.FromArgb(51, 153, 255);
                Color fontButtonActivated = Color.FromArgb(255, 255, 255);
                button3.BackColor = buttonActivated;
                button3.ForeColor = fontButtonActivated;
                button3.Enabled = true;
            }
        }

        private void ProblemasPredefinidos_SelectedIndexChanged(object sender, EventArgs e) {
            if (ProblemasPredefinidos.SelectedIndex < 0) return;

            int numProblema = ProblemasPredefinidos.SelectedIndex;
            ProblemasPredefinidosDB p1 = new ProblemasPredefinidosDB();
            ProblemasPredefinidosDB problema = p1.CargarProblema(numProblema);

            numProblemas.Text = problema.numProb.ToString();
            ejercicioTxt.Text = problema.ejercicio;
            minEnsayos.Text = problema.minEnsayos.ToString();
            maxEnsayos.Text = problema.maxEnsayos.ToString();
            minProb.Text = problema.minProb.ToString();
            maxProb.Text = problema.maxProb.ToString();
        }

        // Botón para abrir la ventana del generador xml
        private void button3_Click(object sender, EventArgs e) {
            // Asegúrate de que GenerateXMLDB acepte 'this' (MenuDistBinomial) en su constructor
            GenerateXMLDB g = new GenerateXMLDB(this);
            g.Show();
        }
    }
}