using System;
using System.Windows.Forms;
using GEOPREST.com.probabilidad.data;
using GEOPREST.com.xml_generator;

namespace GEOPREST.com.views {
    public partial class GenerateXMLProb : Form {
        private MenuProbabilidad menuProbabilidad;

        public GenerateXMLProb(MenuProbabilidad menuProbabilidad) {
            InitializeComponent();
            this.menuProbabilidad = menuProbabilidad;
        }

        private void button3_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                rutaTxt.Text = filePath;
            }
        }

        //Boton para generar el xml
        private void button4_Click(object sender, EventArgs e) {
            //Obtenemos los datos del formulario
            string problema = nomProblema.Text;
            string categoria = categoriaProb.Text;
            string ubicacion = rutaTxt.Text;

            // Verifica que los campos de texto no estén vacíos
            if (!string.IsNullOrEmpty(problema) && !string.IsNullOrEmpty(categoria) && !string.IsNullOrEmpty(ubicacion)) {
                // Verifica si la ruta termina con ".xml"
                if (!ubicacion.ToLower().EndsWith(".xml")) {
                    ubicacion += ".xml"; // Agrega ".xml" al final si no lo tiene
                }

                ProblemaVenn[] problemas = menuProbabilidad.ProblemasGenerados;
                string rutaImagenes = menuProbabilidad.RutaBaseImagenes;

                if (problemas != null) {
                    try {
                        XMLGeneratorProb.GenerateXMLProb(problemas, problema, rutaImagenes, ubicacion, categoria);
                    } catch (Exception ex) {
                        MessageBox.Show("Error al último paso: " + ex.Message);
                    }
                } else {
                    MessageBox.Show("El objeto es nulo");
                }
                //En caso de exito, mandamos retroalimentacion y cerramos la ventana
                MessageBox.Show("El archivo fue creado de manera exitosa\nRuta: " + ubicacion);
                this.Visible = false;
            } else {
                MessageBox.Show("Error: Uno o más campos de texto están vacíos.");
            }

        }
    }
}
