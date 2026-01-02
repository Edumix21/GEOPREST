using System;
using System.Drawing;
using System.Windows.Forms;

namespace GEOPREST.com.views {
    public partial class MainPanel : Form {
        // Variable para rastrear el botón de menú actual
        private Button currentMenuButton;
        private EventArgs e;

        public MainPanel() {
            InitializeComponent();

            menuEstDes_Click(null, e);

            // Establecer el estilo visual del botón para que parezca un panel
            foreach (Button button in new Button[] {menuDistBin, menuProb, menuDistNormal, menuTabCont, menuDistBinomial }) {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }

            // Establecer el botón menuEstDes como el menú actual
            currentMenuButton = menuDistBin;
            SetButtonColors();
        }

        //Al clickear el boton, cambiamos su color y abrimos el formulario
        private void menuEstDes_Click(object sender, EventArgs e) {
            currentMenuButton = menuDistBin;
            SetButtonColors();
            AbrirForm(new MenuEstadistica());
        }

        //Metodo para abrir un formulario en el panel principal
        private void AbrirForm(object form) {
            if (this.panelCont.Controls.Count > 0) {
                this.panelCont.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();
        }

        private void panelCont_Paint(object sender, PaintEventArgs e) {

        }

        //Al clickear el boton, cambiamos su color y abrimos el formulario
        private void menuProb_Click(object sender, EventArgs e) {
            currentMenuButton = menuProb;
            SetButtonColors();
            AbrirForm(new MenuProbabilidad());
        }

        //De momento este boton no sirve para nada
        private void menuOtro_Click(object sender, EventArgs e) {
            currentMenuButton = menuDistNormal;
            SetButtonColors();
            AbrirForm(new MenuDistNormal());
        }

        // Función para establecer los colores de los botones según el menú actual
        private void SetButtonColors() {
            // Establecer el color de fondo de los botones
            menuDistBin.BackColor = currentMenuButton == menuDistBin ? Color.FromArgb(226, 232, 233) : Color.FromArgb(250, 250, 250);
            menuProb.BackColor = currentMenuButton == menuProb ? Color.FromArgb(226, 232, 233) : Color.FromArgb(250, 250, 250);
            menuTabCont.BackColor = currentMenuButton == menuTabCont ? Color.FromArgb(226, 232, 233) : Color.FromArgb(250, 250, 250);
            menuDistNormal.BackColor = currentMenuButton == menuDistNormal ? Color.FromArgb(226, 232, 233) : Color.FromArgb(250, 250, 250);
            menuDistBinomial.BackColor = currentMenuButton == menuDistBinomial ? Color.FromArgb(226, 232, 233) : Color.FromArgb(250, 250, 250);
        }

        private void button1_Click(object sender, EventArgs e) {
            currentMenuButton = menuTabCont;
            SetButtonColors();
            AbrirForm(new MenuTablasCont());
        }

        private void menuTabCont_Click(object sender, EventArgs e) {
            currentMenuButton = menuTabCont;
            SetButtonColors();
            AbrirForm(new MenuTablasCont());
        }

        private void menuDistBinomial_Click(object sender, EventArgs e) {
            currentMenuButton = menuDistBinomial;
            SetButtonColors();
            AbrirForm(new MenuDistBinomial());
        }
    }
}
