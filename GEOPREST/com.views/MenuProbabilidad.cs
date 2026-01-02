using GEOPREST.com.probabilidad.data;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GEOPREST.com.views {
    public partial class MenuProbabilidad : Form {

        private ProblemaVenn[] problemasGenerados;
        private string rutaBaseImagenes;

        public ProblemaVenn[] ProblemasGenerados { get => problemasGenerados; set => problemasGenerados = value; }
        public string RutaBaseImagenes { get => rutaBaseImagenes; set => rutaBaseImagenes = value; }

        public MenuProbabilidad() {
            object sender = new object();
            EventArgs e = new EventArgs();
            InitializeComponent();
            UpdatePreview(sender, e);
        }

        //Boton para generar los problemas y las imagenes de los diagramas de venn
        private void button1_Click_1(object sender, EventArgs e) {
            //Array para guardar los valores de los numeros de los circulos
            int[] valCirculos = new int[4];
            string result = "";

            // Obtener valores de los checkboxes
            bool[] visibilidad = {
                checkCirR.Checked,
                checkCirA.Checked,
                checkCirV.Checked
            };

            bool[] mostNum = {
                checkNumA.Checked,
                checkNumB.Checked,
                checkNumC.Checked
            };

            string textoEjercicio = pEjercicioTxt.Text;

            string variableFuera = checkVarExt.Checked ? "Total" : null;
            string variableInterseccion = checkInter.Checked ? "D" : null;

            // Obtener valores de los rangos
            int rangoMin;
            int rangoMax;

            // Validar y obtener los valores de los rangos
            if (!int.TryParse(valorMin.Text, out rangoMin)) {
                MessageBox.Show("Por favor ingrese un valor numérico válido para el rango mínimo.");
                return;
            }

            if (!int.TryParse(valorMax.Text, out rangoMax)) {
                MessageBox.Show("Por favor ingrese un valor numérico válido para el rango máximo.");
                return;
            }

            if (rangoMin > rangoMax) {
                MessageBox.Show("El valor mínimo no puede ser mayor que el valor máximo.");
                return;
            }

            // Crear instancia de GeneradorVenn con los valores obtenidos
            GeneradorVenn generador = new GeneradorVenn(visibilidad, mostNum, variableFuera, variableInterseccion, rangoMin, rangoMax);

            //Desde aqui se genera el repetidor
            int numProb = int.Parse(numProblemas.Text);

            problemasGenerados = new ProblemaVenn[numProb];

            for (int i = 0; i < numProb; i++) {

                // Generar imagen y guardarla como PNG
                int width = 400;
                int height = 300;
                Bitmap bitmap = new Bitmap(width, height);
                using (Graphics graphics = Graphics.FromImage(bitmap)) {
                    valCirculos = generador.GenerarImagen(graphics);
                }

                // Guardar la imagen
                rutaBaseImagenes = rutaTxt.Text;
                string fileName = rutaBaseImagenes + (i + 1) + ".png";
                bitmap.Save(fileName, ImageFormat.Png);
                //MessageBox.Show("Imagen guardada como: " + fileName);

                //A partir de aqui todo lo relacionado a la generacion del problema

                Probabilidad prob = new Probabilidad();
                problemasGenerados[i] = prob.GenerarProblemasVenn(valCirculos, textoEjercicio);

                result += "-------- Problema " + (i + 1) + "--------\n";
                result += ImprimirProblemaVenn(problemasGenerados[i]) + "\n";

            }
            
            richTextBox1.Text = result;
            ActivateXMLButton();
        }

        //Metodo para determinar si se puede usar el boton de "Generar xml"
        //Esto para no llamarlo cuando no tengamos ningun programa generado
        private void ActivateXMLButton() {
            if (!string.IsNullOrEmpty(richTextBox1.Text)) {
                Color buttonActivated = Color.FromArgb(51, 153, 255);
                Color fontButtonActivated = Color.FromArgb(255, 255, 255);
                button3.BackColor = buttonActivated;
                button3.ForeColor = fontButtonActivated;
                button3.Enabled = true;
            }
        }

        private void UpdatePreview(object sender, EventArgs e) {
            bool[] visibilidad = {
                checkCirR.Checked,
                checkCirA.Checked,
                checkCirV.Checked
            };

            bool[] mostNum = {
                checkNumA.Checked,
                checkNumB.Checked,
                checkNumC.Checked                
            };

            string variableFuera = checkVarExt.Checked ? "Total" : null;
            string variableInterseccion = checkInter.Checked ? "D" : null;

            GeneradorVenn venn = new GeneradorVenn(visibilidad, mostNum, variableFuera, variableInterseccion, 1, 1);

            // Generar imagen en un Bitmap
            Bitmap bitmap = new Bitmap(pictureBoxPreview.Width, pictureBoxPreview.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap)) {
                venn.GenerarImagen(graphics);
            }

            // Asignar el Bitmap al PictureBox
            pictureBoxPreview.Image = bitmap;
        }

        private void MenuProbabilidad_Load(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        //Guardar la ruta de las imagenes
        private void button2_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                rutaTxt.Text = filePath;
            }
        }

        public string ImprimirProblemaVenn(ProblemaVenn problemaVenn) {
            string resultado;

            resultado = problemaVenn.Ejercicio + "\n\n";

            // Añadimos cada problema con su respectiva probabilidad
            for (int i = 0; i < problemaVenn.ValEjercicios.Length; i++) {
                resultado += $"P({problemaVenn.ValEjercicios[i]}) = {problemaVenn.Resultados[i]:F4}\n";
            }

            return resultado;
        }

        private void button3_Click(object sender, EventArgs e) {
            //Boton para mostrar la ventana del generador xml
            GenerateXMLProb g = new GenerateXMLProb(this);
            g.Show();
        }

        //Combobox para escoger los problemas predeterminados
        private void pProblemasPredefinidos_SelectedIndexChanged(object sender, EventArgs e) {
            int numProblema = pProblemasPredefinidos.SelectedIndex;
            ProblemasPredefinidosP prob = new ProblemasPredefinidosP();
            ProblemasPredefinidosP p1 = prob.CargarProblemas(numProblema);

            numProblemas.Text = p1.numProblemas.ToString();
            valorMin.Text = p1.valMin.ToString();
            valorMax.Text = p1.valMax.ToString();
            pEjercicioTxt.Text = p1.ejercicio;
            checkCirR.Checked = p1.circulos[0];
            checkCirA.Checked = p1.circulos[1];
            checkCirV.Checked = p1.circulos[2];
        }
    }
}
