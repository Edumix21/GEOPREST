using System;
using System.Drawing;
using System.Windows.Forms;
using GEOPREST.com.tablasContingencia.data;

namespace GEOPREST.com.views {
    public partial class MenuTablasCont : Form {
        private ProblemaContingencia[] problemasGenerados;

        public ProblemaContingencia[] ProblemasGenerados { get => problemasGenerados; set => problemasGenerados = value; }

        public MenuTablasCont() {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e) {

        }

        private void buttonGenerar_Click(object sender, EventArgs e) {
            try {
                //Recolectamos los datos del formulario
                int numProblemas = int.Parse(txtNumProblemas.Text);
                string nomFila = txtNomFila.Text;
                string nomColumna = txtNomColumna.Text;
                string textoEjercicio = txtTextoEjercicio.Text;
                string valorTabla1 = txtValorTabla1.Text;
                string valorTabla2 = txtValorTabla2.Text;
                string valorTabla3 = txtValorTabla3.Text;
                string valorTabla4 = txtValorTabla4.Text;
                int numMin = int.Parse(txtNumMin.Text);
                int numMax = int.Parse(txtNumMax.Text);

                //Creamos una instancia del generador de problemas
                TablasContingencia generador = new TablasContingencia();

                //Generamos los problemas
                problemasGenerados = generador.GenerarProblemas(numProblemas, nomFila, nomColumna, textoEjercicio, valorTabla1, valorTabla2, valorTabla3, valorTabla4, numMin, numMax);

                // Mostrar problemas generados en algún componente de la interfaz
                if(problemasGenerados.Length != 0) {
                    //mostrarDatos.Text = problemas[0].Ejercicio + "\n" + problemas[0].TablaContingencia[0,0];
                    //mostrarDatos1.Text = problemas[0].Respuestas[0].ToString();
                    mostrarDatos.Text = generador.FormatoProblemas(problemasGenerados);
                    mostrarDatos1.Text = generador.FormatearRespuestasProblemas(problemasGenerados);
                    ActivateXMLButton();
                } else {
                    mostrarDatos.Text = "Error al imprimir los valores";
                }

            } catch (Exception ex) {
                MessageBox.Show("Error: Datos no válidos\nPor favor llene todos los datos de manera correcta");
                Console.WriteLine(ex);
            }
        }

        private void MenuTablasCont_Load(object sender, EventArgs e) {

        }

        private void ProblemasPredefinidos_SelectedIndexChanged(object sender, EventArgs e) {
            int numProblema = ProblemasPredefinidos.SelectedIndex;
            ProblemasPredefinidosTC prob = new ProblemasPredefinidosTC();
            ProblemasPredefinidosTC p1 = prob.CargarProblema(numProblema);

            txtNumProblemas.Text = p1.numProb.ToString();
            txtNomFila.Text = p1.nombreFila;
            txtNomColumna.Text = p1.nombreColumna;
            txtTextoEjercicio.Text = p1.txtEjercicio;
            txtValorTabla1.Text = p1.valTabla1;
            txtValorTabla2.Text = p1.valTabla2;
            txtValorTabla3.Text = p1.valTabla3;
            txtValorTabla4.Text = p1.valTabla4;
            txtNumMin.Text = p1.nMin.ToString();
            txtNumMax.Text = p1.nMax.ToString();
        }

        //Boton para abrir la ventana para el generador xml
        private void button3_Click(object sender, EventArgs e) {
            GenerateXMLTC g = new GenerateXMLTC(this);
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
    }
}
