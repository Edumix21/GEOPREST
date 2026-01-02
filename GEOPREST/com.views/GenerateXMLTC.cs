using System;
using System.Windows.Forms;
using GEOPREST.com.xml_generator;
using GEOPREST.com.tablasContingencia.data;

namespace GEOPREST.com.views {
    public partial class GenerateXMLTC : Form {
        private MenuTablasCont menuTablasCont;

        public GenerateXMLTC(MenuTablasCont menuTablasCont) {
            InitializeComponent();
            this.menuTablasCont = menuTablasCont;
        }

        //Boton para abrir la ruta del archivo
        private void button3_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                rutaTxt.Text = filePath;
            }
        }

        //Boton para generar el archivo xml
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

                //Obtenemos los problemas del formulario anterior
                ProblemaContingencia[] problemas = menuTablasCont.ProblemasGenerados;


                try {
                    //Generamos el xml con los valores guardados
                    XMLGeneratorTC.GenerateXMLTC(categoria, problema, ubicacion, problemas);
                } catch (Exception ex) {
                    MessageBox.Show("Error al generar el archivo xml: " + ex.Message);
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
