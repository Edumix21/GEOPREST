using System;
using System.Windows.Forms;
using GEOPREST.com.distribucionBinomial.data;
using GEOPREST.com.xml_generator;

namespace GEOPREST.com.views {
    public partial class GenerateXMLDB : Form {
        private MenuDistBinomial menuDistBinomial;

        public GenerateXMLDB(MenuDistBinomial menuDistBinomial) {
            InitializeComponent();
            this.menuDistBinomial = menuDistBinomial;
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
            // Obtenemos los datos del formulario
            string problema = nomProblema.Text;
            string categoria = categoriaProb.Text;
            string ubicacion = rutaTxt.Text;

            // Verifica que los campos de texto no estén vacíos
            if (!string.IsNullOrEmpty(problema) && !string.IsNullOrEmpty(categoria) && !string.IsNullOrEmpty(ubicacion)) {
                // Verifica si la ruta termina con ".xml" y la agrega si no lo tiene
                if (!ubicacion.ToLower().EndsWith(".xml")) {
                    ubicacion += ".xml";
                }

                // Obtenemos los problemas generados del formulario anterior (MenuDistBinomial)
                // Se asume que MenuDistBinomial tiene una propiedad pública para acceder a ellos.
                // Es importante que MenuDistBinomial.cs exponga la lista de ProblemaDistBinomial
                // en una propiedad pública, similar a como MenuDistNormal.cs lo hace con ProblemasGenerados.
                // Si la propiedad es una List<>, deberás convertirla a array si XMLGeneratorDB lo espera así.
                ProblemaDistBinomial[] problemas = menuDistBinomial.lista.ToArray();

                try {
                    // Llamamos al generador XML para distribución binomial
                    XMLGeneratorDB.GenerateXMLDB(categoria, problema, ubicacion, problemas);

                    // En caso de éxito, mandamos retroalimentación y cerramos la ventana
                    MessageBox.Show("El archivo XML fue creado de manera exitosa.\nRuta: " + ubicacion);
                    this.Visible = false; // O this.Close(); si prefieres cerrar la ventana completamente
                } catch (Exception ex) {
                    MessageBox.Show("Error al generar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Error: Uno o más campos de texto están vacíos. Por favor, rellene todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
