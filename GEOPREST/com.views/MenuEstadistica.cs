using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEOPREST.com.data;
using GEOPREST.com.xml_generator;
using GEOPREST.com.views;

namespace GEOPREST {
    public partial class MenuEstadistica : Form {

        //No estoy particularmente seguro de por que los declare de manera publica, pero seguro es por algo importante del xml
        public ProblemaAlumno[] Alumnos { get; set; }
        public static bool IsAgruped { get; set; }
        public static int NIntervalos { get; set; }

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
                    //Llamamos al metodo para generar el formato de impresion y lo guardamos
                    datos.Append(pr.ImprimirDatos(alumnos[i]));
                }
            } else {
                for (int i = 0; i < nAlumnos; i++) {
                    if (flag) datos.AppendLine("-------- Problema " + (i + 1) + " --------");
                    //Llamamos al metodo para generar el formato de impresion y lo guardamos
                    datos.Append(pr.ImprimirDatosAgrupados(alumnos[i], nIntervalos, false));
                }
            }
            return datos.ToString();
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

        public MenuEstadistica() {
            InitializeComponent();
            numIntervalos.Visible = false;
        }

        //Boton para generar el arreglo de problemas
        private void button2_Click(object sender, EventArgs e) {
            try {
                //Recogemos todos los datos del formulario
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
                MenuEstadistica mostrar = new MenuEstadistica();

                Alumnos = new ProblemaAlumno[nAlum];
                //Llamamos el metodo para generar las iteraciones de los problemas
                Alumnos = op.GenerarProblema(nAlum, ejer, minD, maxD, limI, limS, nDec);

                //Guardamos los textos de los datos y valores para mostrarlos en el panel de texto
                string datos = mostrar.ImprimirDatosAlumnos(nAlum, Alumnos, IsAgruped, NIntervalos, true);
                string valores = mostrar.ImprimirValoresAlumnos(nAlum, Alumnos, true);
                mostrarDatos.Text = valores;
                mostrarDatos1.Text = datos;

                //Guardamos las iteraciones de los problemas en un archivo cache
                SaveDataInTxt.SaveDataTxt(Alumnos);

                ActivateXMLButton();
            } catch (Exception ex) {
                MessageBox.Show("Error: Datos no válidos\nPor favor llene todos los datos de manera correcta");
                Console.WriteLine(ex);
            }
        }

        //Boton para limpiar todos los datos del formulario
        private void button1_Click(object sender, EventArgs e) {
            numAlumnos.Text = "";
            numDatosMin.Text = "";
            numDatosMax.Text = "";
            limInf.Text = "";
            limSup.Text = "";
            numDecimales.Text = "";
            ejercicioTxt.Text = "";
        }

        //ComboBox para obtener los problemas predefinidos de su archivo y mostrar los datos en el formulario
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

        //Boton para mostrar la ventana del generador xml
        private void button3_Click(object sender, EventArgs e) {
            GenerateXMLWindow g = new GenerateXMLWindow();
            g.Show();
            
        }

        private void MainPanel_Load(object sender, EventArgs e) {

        }
    }
}
