using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GEOPREST.com.distribucionNormal.data;

namespace GEOPREST.com.views {
    public partial class MenuDistNormal : Form {
        private ProblemaDistNormal[] problemasGenerados;

        public ProblemaDistNormal[] ProblemasGenerados { get => problemasGenerados; set => problemasGenerados = value; }

        public MenuDistNormal() {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                //Recogemos los datos del formulario para generar los problemas
                int nProb = int.Parse(numProblemas.Text);
                string ejer = ejercicioTxt.Text;
                double mediaMin = double.Parse(minMedia.Text);
                double mediaMax = double.Parse(maxMedia.Text);
                double desvMin = double.Parse(minDesv.Text);
                double desvMax = double.Parse(maxDesv.Text);
                //int tipoProblema = tipoEjercicio.SelectedIndex;
                //string tipoProblemaString = "";
                //if (tipoProblema == 0) tipoProblemaString = "intervalo";
                //else if (tipoProblema == 1) tipoProblemaString = "acumulada";
                //else {
                //    MessageBox.Show("Error: Tipo de problema inválido.");
                //    return;
                //}

                //Llamamos al metodo para generar los ejercicios
                DistNormal generador = new DistNormal();
                generador.GenerarProblemas(nProb, ejer, mediaMin, mediaMax, desvMin, desvMax/*, tipoProblemaString*/);

                problemasGenerados = generador.ObtenerProblemas();

                // Formatear los problemas y respuestas
                string textoProblemas = generador.FormatearProblemas(problemasGenerados);
                string textoRespuestas = generador.FormatearRespuestas(problemasGenerados);

                // Asignar a los cuadros de texto
                mostrarDatos.Text = textoProblemas;
                mostrarDatos1.Text = textoRespuestas;

                ActivateXMLButton();
            } catch (Exception ex) {
                MessageBox.Show("Error: Datos no válidos\nPor favor llene todos los datos de manera correcta");
                Console.WriteLine(ex);
            }
        }

        //Combobox para cargar los problemas predefinidos en la interfaz
        private void ProblemasPredefinidos_SelectedIndexChanged(object sender, EventArgs e) {
            int numProblema = ProblemasPredefinidos.SelectedIndex;
            ProblemasPredefinidosDN p1 = new ProblemasPredefinidosDN();
            ProblemasPredefinidosDN problema = p1.CargarProblema(numProblema);
            numProblemas.Text = problema.numProb.ToString();
            ejercicioTxt.Text = problema.ejercicio;
            minMedia.Text = problema.minMedia.ToString();
            maxMedia.Text = problema.maxMedia.ToString();
            minDesv.Text = problema.minDesv.ToString();
            maxDesv.Text = problema.maxDesv.ToString();
            //tipoEjercicio.SelectedIndex = problema.tipoProb;
        }

        //Boton para abrir la ventana del generador xml
        private void button3_Click(object sender, EventArgs e) {
            GenerateXMLDN g = new GenerateXMLDN(this);
            g.Show();
        }

        //Metodo para determinar si se puede usar el boton de "Generar xml"
        //Esto para no llamarlo cuando no tengamos ningun programa generado
        private void ActivateXMLButton() {
            if (!string.IsNullOrEmpty(mostrarDatos.Text)) {
                Color buttonActivated = Color.FromArgb(51, 153, 255);
                Color fontButtonActivated = Color.FromArgb(255, 255, 255);
                button3.BackColor = buttonActivated;
                button3.ForeColor = fontButtonActivated;
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            numProblemas.Text = "";
            ejercicioTxt.Text = "";
            minMedia.Text = "";
            maxMedia.Text = "";
            minDesv.Text = "";
            maxDesv.Text = "";
            //tipoEjercicio.SelectedIndex = 0;
        }
    }
}
