using System;
using GEOPREST.com.data;
using GEOPREST.com.xml_generator;
using System.Windows.Forms;

namespace GEOPREST.com.views {
    public partial class GenerateXMLWindow : Form {
        public ProblemaAlumno[] Alumnos { get; set; }

        public GenerateXMLWindow() {
            InitializeComponent();
        }

        private void GenerateXMLWindow_Load(object sender, EventArgs e) {

        }

        //Metodo para obtener el valor del error permitido en el coeficiente de variacion
        public string GetErrCof() {
            if (!string.IsNullOrEmpty(errorCof.Text)) {
                return errorCof.Text;
            } else {
                return "0";
            }
        }

        //Visualizacion del label correspondiente a la sumatoria
        private void sumatoriaCheck_CheckedChanged(object sender, EventArgs e) {
            if (sumatoriaCheck.Checked) {
                labelESum.Visible = true;
                errorSumatoria.Visible = true;
            } else {
                labelESum.Visible = false;
                errorSumatoria.Visible = false;
            }
        }

        //Metodo para obtener el valor del error permitido en la sumatoria
        public string GetErrSum() {
            if (!string.IsNullOrEmpty(errorSumatoria.Text)) {
                return errorSumatoria.Text;
            } else {
                return "0";
            }
        }

        //Metodo para obtener el valor del error permitido en la media
        public string GetErrMed() {
            if (!string.IsNullOrEmpty(errorMedia.Text)) {
                return errorMedia.Text;
            } else {
                return "0";
            }
        }

        //Metodo para obtener el valor del error permitido en la varianza
        public string GetErrVar() {
            if (!string.IsNullOrEmpty(errorVarianza.Text)) {
                return errorVarianza.Text;
            } else {
                return "0";
            }
        }

        //Metodo para obtener el valor del error permitido en la desviacion estandar
        public string GetErrDes() {
            if (!string.IsNullOrEmpty(errorDesviacion.Text)) {
                return errorDesviacion.Text;
            } else {
                return "0";
            }
        }

        //Boton para abrir la ruta de los archivos
        private void button3_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                rutaTxt.Text = filePath;
            }
        }

        //Boton para guardar el archivo en xml
        private void button4_Click(object sender, EventArgs e) {

            //Obtenemos los datos del formulario
            string problema = nomProblema.Text;
            string categoria = categoriaProb.Text;
            bool sumatoria, media, varianza, desEstandar, cofVariacion;
            sumatoria = sumatoriaCheck.Checked;
            media = mediaCheck.Checked;
            varianza = varianzaCheck.Checked;
            desEstandar = desEstandarCheck.Checked;
            cofVariacion = cofVariacionCheck.Checked;
            string[] errPermitidos = { GetErrSum(), GetErrMed(), GetErrVar(), GetErrDes(), GetErrCof() };

            string ubicacion = rutaTxt.Text;
            string rutaCsv = csvTextBox.Text;
            if (generarCsv.Checked == false) rutaCsv = ""; //Si no quiere generar csv, nos aseguramos de pasar un string vacio

            // Verifica que los campos de texto no estén vacíos
            if (!string.IsNullOrEmpty(problema) && !string.IsNullOrEmpty(categoria) && !string.IsNullOrEmpty(ubicacion)) {
                // Verifica si la ruta termina con ".xml"
                if (!ubicacion.ToLower().EndsWith(".xml")) {
                    ubicacion += ".xml"; // Agrega ".xml" al final si no lo tiene
                }

                //Recogemos los valores de los problemas guardados en el cache
                ProblemaAlumno[] alumnos = SaveDataInTxt.LoadDataTxt();


                try {
                    //Generamos el xml con los valores guardados
                    XMLGenerator.GenerateXML(alumnos, problema, sumatoria, media, varianza, desEstandar, cofVariacion,
                            ubicacion, categoria, errPermitidos, rutaCsv);
                } catch (Exception ex) {
                    MessageBox.Show("Error al último paso: " + ex.Message);
                }
                //En caso de exito, mandamos retroalimentacion y cerramos la ventana
                MessageBox.Show("El archivo fue creado de manera exitosa\nRuta: " + ubicacion);
                this.Visible = false;
            } else {
                MessageBox.Show("Error: Uno o más campos de texto están vacíos.");
            }
        }

        //Boton para guardar la ruta de los archivos csv
        private void csvButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                csvTextBox.Text = filePath;
            }
        }

        //Visualizacion del label correspondiente a la media
        private void mediaCheck_CheckedChanged_1(object sender, EventArgs e) {
            if (mediaCheck.Checked) {
                labelEMed.Visible = true;
                errorMedia.Visible = true;
            } else {
                labelEMed.Visible = false;
                errorMedia.Visible = false;
            }
        }

        //Visualizacion del label correspondiente a la varianza
        private void varianzaCheck_CheckedChanged_1(object sender, EventArgs e) {
            if (varianzaCheck.Checked) {
                labelEVar.Visible = true;
                errorVarianza.Visible = true;
            } else {
                labelEVar.Visible = false;
                errorVarianza.Visible = false;
            }
        }

        //Visualizacion del label correspondiente a la desviacion estandar
        private void desEstandarCheck_CheckedChanged_1(object sender, EventArgs e) {
            if (desEstandarCheck.Checked) {
                labelEDes.Visible = true;
                errorDesviacion.Visible = true;
            } else {
                labelEDes.Visible = false;
                errorDesviacion.Visible = false;
            }
        }

        //Visualizacion del label correspondiente al coeficiente de variacion
        private void cofVariacionCheck_CheckedChanged_1(object sender, EventArgs e) {
            if (cofVariacionCheck.Checked) {
                labelECof.Visible = true;
                errorCof.Visible = true;
            } else {
                labelECof.Visible = false;
                errorCof.Visible = false;
            }
        }

        //Visualizacion del label correspondiente a la generacion del csv
        private void generarCsv_CheckedChanged_1(object sender, EventArgs e) {
            if (generarCsv.Checked) {
                csvLabel.Visible = true;
                csvTextBox.Visible = true;
                csvButton.Visible = true;
            } else {
                csvLabel.Visible = false;
                csvTextBox.Visible = false;
                csvButton.Visible = false;
            }
        }
    }
}
