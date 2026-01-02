using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEOPREST.com.data;
using GEOPREST.com.xml_generator;
using GEOPREST.com.views;

namespace GEOPREST {
    public partial class MainPanel : Form {

        public ProblemaAlumno[] Alumnos { get; set; }
        public static bool IsAgruped { get; set; }
        public static int NIntervalos { get; set; }
        // Variable para rastrear el botón de menú actual
        private Button currentMenuButton;

        // El parámetro flag determina si se necesita imprimir el número del alumno o no
        private string ImprimirValoresAlumnos(int nAlumnos, ProblemaAlumno[] alumnos, bool flag) {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < nAlumnos; i++) {
                if (flag) datos.AppendLine("-------- Problema " + (i + 1) + " --------");
                datos.Append(alumnos[i].ImprimirResultados());
            }
            return datos.ToString();
        }

        // El parámetro flag determina si se necesita imprimir el número del alumno o no
        private string ImprimirDatosAlumnos(int nAlumnos, ProblemaAlumno[] alumnos, bool isAgrupped, int nIntervalos, bool flag) {
            ProblemaAlumno pr = new ProblemaAlumno();
            StringBuilder datos = new StringBuilder();
            if (!isAgrupped) {
                for (int i = 0; i < nAlumnos; i++) {
                    if (flag) datos.AppendLine("-------- Problema " + (i + 1) + " --------");
                    datos.Append(pr.ImprimirDatos(alumnos[i]));
                }
            } else {
                for (int i = 0; i < nAlumnos; i++) {
                    if (flag) datos.AppendLine("-------- Problema " + (i + 1) + " --------");
                    datos.Append(pr.ImprimirDatosAgrupados(alumnos[i], nIntervalos, false));
                }
            }
            return datos.ToString();
        }

        private void ActivateXMLButton() {
            if (!string.IsNullOrEmpty(mostrarDatos.Text)) {
                Color buttonActivated = Color.FromArgb(51, 153, 255);
                Color fontButtonActivated = Color.FromArgb(255, 255, 255);
                button3.BackColor = buttonActivated;
                button3.ForeColor = fontButtonActivated;
                button3.Enabled = true;
            }
        }

        public MainPanel() {
            InitializeComponent();
            numIntervalos.Visible = false;

            // Establecer el estilo visual del botón para que parezca un panel
            foreach (Button button in new Button[] {menuEstDes, menuProb, menuOtro }) {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }

            // Establecer el botón menuEstDes como el menú actual
            currentMenuButton = menuEstDes;
            SetButtonColors();
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                int nAlum = int.Parse(numAlumnos.Text);
                string ejer = ejercicioTxt.Text;
                int minD = int.Parse(numDatosMin.Text);
                int maxD = int.Parse(numDatosMax.Text);
                double limI = double.Parse(limInf.Text);
                double limS = double.Parse(limSup.Text);
                int nDec = int.Parse(numDecimales.Text);

                IsAgruped = estanAgrupados.Checked;
                NIntervalos = 0;

                if (IsAgruped) {
                    NIntervalos = int.Parse(numIntervalos.Text);
                }

                Estadistica op = new Estadistica();
                MainPanel mostrar = new MainPanel();

                Alumnos = new ProblemaAlumno[nAlum];
                Alumnos = op.GenerarProblema(nAlum, ejer, minD, maxD, limI, limS, nDec);
                string datos = mostrar.ImprimirDatosAlumnos(nAlum, Alumnos, IsAgruped, NIntervalos, true);
                string valores = mostrar.ImprimirValoresAlumnos(nAlum, Alumnos, true);
                mostrarDatos.Text = valores;
                mostrarDatos1.Text = datos;
                SaveDataInTxt.SaveDataTxt(Alumnos);

                ActivateXMLButton();
            } catch (Exception ex) {
                MessageBox.Show("Error: Datos no válidos\nPor favor llene todos los datos de manera correcta");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            numAlumnos.Text = "";
            numDatosMin.Text = "";
            numDatosMax.Text = "";
            limInf.Text = "";
            limSup.Text = "";
            numDecimales.Text = "";
            ejercicioTxt.Text = "";
        }

        private void ProblemasPredefinidos_SelectedIndexChanged(object sender, EventArgs e) {
            int numProblema = ProblemasPredefinidos.SelectedIndex;
            ProblemasPredefinidos pro = new ProblemasPredefinidos();
            ProblemasPredefinidos problemaSeleccionado = pro.GenerarProblema(numProblema);
            numAlumnos.Text = problemaSeleccionado.GetNumAlumnos();
            numDatosMin.Text = problemaSeleccionado.GetMinDatos();
            numDatosMax.Text = problemaSeleccionado.GetMaxDatos();
            limInf.Text = problemaSeleccionado.GetLimInf();
            limSup.Text = problemaSeleccionado.GetLimSup();
            numDecimales.Text = problemaSeleccionado.GetNumDecimales();
            ejercicioTxt.WordWrap = true;
            ejercicioTxt.Text = problemaSeleccionado.GetEjercicio();
            numIntervalos.Text = problemaSeleccionado.GetNIntervalos();
        }

        private void helpButton_Click(object sender, EventArgs e) {
            HelpDialog h = new HelpDialog();
            h.Show();
        }

        private void estanAgrupados_CheckedChanged(object sender, EventArgs e) {
            if (estanAgrupados.Checked) {
                numIntervalos.Visible = true;
            } else {
                numIntervalos.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            GenerateXMLWindow g = new GenerateXMLWindow();
            g.Show();
            
        }

        // Función para establecer los colores de los botones según el menú actual
        private void SetButtonColors() {
            // Establecer el color de fondo de los botones
            menuEstDes.BackColor = currentMenuButton == menuEstDes ? Color.FromArgb(215, 215, 215) : Color.FromArgb(250, 250, 250);
            menuProb.BackColor = currentMenuButton == menuProb ? Color.FromArgb(215, 215, 215) : Color.FromArgb(250, 250, 250);
            menuOtro.BackColor = currentMenuButton == menuOtro ? Color.FromArgb(215, 215, 215) : Color.FromArgb(250, 250, 250);
        }

        private void MainPanel_Load(object sender, EventArgs e) {

        }

        private void menuEstDes_Click(object sender, EventArgs e) {
            // Establecer el botón como el menú actual y actualizar los colores
            currentMenuButton = menuEstDes;
            SetButtonColors();
        }

        private void menuProb_Click(object sender, EventArgs e) {
            // Establecer el botón como el menú actual y actualizar los colores
            currentMenuButton = menuProb;
            SetButtonColors();
        }

        private void menuOtro_Click(object sender, EventArgs e) {
            // Establecer el botón como el menú actual y actualizar los colores
            //currentMenuButton = menuOtro;
            //SetButtonColors();
            MessageBox.Show("Menu proximamente disponible");
        }
    }
}
