namespace GEOPREST.com.views {
    partial class MenuDistBinomial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tipoPregunta = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.mostrarDatos1 = new System.Windows.Forms.RichTextBox();
            this.mostrarDatos = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProblemasPredefinidos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ejercicioTxt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maxProb = new System.Windows.Forms.TextBox();
            this.minProb = new System.Windows.Forms.TextBox();
            this.maxEnsayos = new System.Windows.Forms.TextBox();
            this.minEnsayos = new System.Windows.Forms.TextBox();
            this.numProblemas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoPregunta
            // 
            this.tipoPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPregunta.FormattingEnabled = true;
            this.tipoPregunta.IntegralHeight = false;
            this.tipoPregunta.ItemHeight = 21;
            this.tipoPregunta.Items.AddRange(new object[] {
            "Exacto",
            "A lo sumo",
            "Al menos",
            "Intervalo"});
            this.tipoPregunta.Location = new System.Drawing.Point(222, 196);
            this.tipoPregunta.Name = "tipoPregunta";
            this.tipoPregunta.Size = new System.Drawing.Size(115, 29);
            this.tipoPregunta.TabIndex = 76;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(687, 664);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 75;
            this.button3.Text = "Guardar en XML";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mostrarDatos1
            // 
            this.mostrarDatos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.mostrarDatos1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDatos1.Location = new System.Drawing.Point(495, 442);
            this.mostrarDatos1.Name = "mostrarDatos1";
            this.mostrarDatos1.Size = new System.Drawing.Size(415, 198);
            this.mostrarDatos1.TabIndex = 74;
            this.mostrarDatos1.Text = "";
            // 
            // mostrarDatos
            // 
            this.mostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.mostrarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDatos.Location = new System.Drawing.Point(52, 442);
            this.mostrarDatos.Name = "mostrarDatos";
            this.mostrarDatos.Size = new System.Drawing.Size(415, 198);
            this.mostrarDatos.TabIndex = 73;
            this.mostrarDatos.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(491, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 21);
            this.label10.TabIndex = 72;
            this.label10.Text = "Datos de los Ejercicios Generados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 21);
            this.label9.TabIndex = 71;
            this.label9.Text = "Valores de los Ejercicios Generados";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 50);
            this.button1.TabIndex = 70;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(40, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 50);
            this.button2.TabIndex = 69;
            this.button2.Text = "Generar datos del Ejercicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProblemasPredefinidos
            // 
            this.ProblemasPredefinidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProblemasPredefinidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemasPredefinidos.FormattingEnabled = true;
            this.ProblemasPredefinidos.IntegralHeight = false;
            this.ProblemasPredefinidos.ItemHeight = 21;
            this.ProblemasPredefinidos.Items.AddRange(new object[] {
            "Red de paquetes",
            "Examen múltiple",
            "Solicitudes servidor",
            "Casos de prueba",
            "Entrega tareas",
            "Habilidad eSports",
            "Servidor nube",
            "Compilar programa",
            "Entrega dron",
            "Ítem raro",
            "Robot fábrica",
            "Pregunta repaso",
            "Sensor movimiento",
            "Compilar intento",
            "Encuesta online",
            "Antivirus",
            "Cajero automático",
            "Jugador dispara",
            "Impresora 3D",
            "Repartidor",
            "Problema algoritmos"});
            this.ProblemasPredefinidos.Location = new System.Drawing.Point(711, 196);
            this.ProblemasPredefinidos.Name = "ProblemasPredefinidos";
            this.ProblemasPredefinidos.Size = new System.Drawing.Size(199, 29);
            this.ProblemasPredefinidos.TabIndex = 68;
            this.ProblemasPredefinidos.SelectedIndexChanged += new System.EventHandler(this.ProblemasPredefinidos_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 21);
            this.label8.TabIndex = 67;
            this.label8.Text = "Ejercicios Recomendados";
            // 
            // ejercicioTxt
            // 
            this.ejercicioTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejercicioTxt.Location = new System.Drawing.Point(336, 279);
            this.ejercicioTxt.Name = "ejercicioTxt";
            this.ejercicioTxt.Size = new System.Drawing.Size(574, 107);
            this.ejercicioTxt.TabIndex = 66;
            this.ejercicioTxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 65;
            this.label7.Text = "Texto del Ejercicio";
            // 
            // maxProb
            // 
            this.maxProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxProb.Location = new System.Drawing.Point(608, 196);
            this.maxProb.Name = "maxProb";
            this.maxProb.Size = new System.Drawing.Size(80, 29);
            this.maxProb.TabIndex = 64;
            // 
            // minProb
            // 
            this.minProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minProb.Location = new System.Drawing.Point(522, 196);
            this.minProb.Name = "minProb";
            this.minProb.Size = new System.Drawing.Size(80, 29);
            this.minProb.TabIndex = 63;
            // 
            // maxEnsayos
            // 
            this.maxEnsayos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxEnsayos.Location = new System.Drawing.Point(436, 196);
            this.maxEnsayos.Name = "maxEnsayos";
            this.maxEnsayos.Size = new System.Drawing.Size(65, 29);
            this.maxEnsayos.TabIndex = 62;
            // 
            // minEnsayos
            // 
            this.minEnsayos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minEnsayos.Location = new System.Drawing.Point(365, 196);
            this.minEnsayos.Name = "minEnsayos";
            this.minEnsayos.Size = new System.Drawing.Size(65, 29);
            this.minEnsayos.TabIndex = 61;
            // 
            // numProblemas
            // 
            this.numProblemas.AccessibleName = "";
            this.numProblemas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProblemas.Location = new System.Drawing.Point(52, 196);
            this.numProblemas.Name = "numProblemas";
            this.numProblemas.Size = new System.Drawing.Size(110, 29);
            this.numProblemas.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tipo de Pregunta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 42);
            this.label5.TabIndex = 58;
            this.label5.Text = "Rango de la\r\nprobabilidad de exito\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Rango de los ensayos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Número de Problemas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 40);
            this.panel1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Añadir Ejercicio";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(724, 22);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(40, 30);
            this.helpButton.TabIndex = 55;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(277, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 74);
            this.label1.TabIndex = 53;
            this.label1.Text = "Generador de problemas de\r\nDistribucion Binomial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuDistBinomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(953, 709);
            this.Controls.Add(this.tipoPregunta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mostrarDatos1);
            this.Controls.Add(this.mostrarDatos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProblemasPredefinidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ejercicioTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxProb);
            this.Controls.Add(this.minProb);
            this.Controls.Add(this.maxEnsayos);
            this.Controls.Add(this.minEnsayos);
            this.Controls.Add(this.numProblemas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuDistBinomial";
            this.Text = "MenuDistBinomial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipoPregunta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox mostrarDatos1;
        private System.Windows.Forms.RichTextBox mostrarDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ProblemasPredefinidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox ejercicioTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxProb;
        private System.Windows.Forms.TextBox minProb;
        private System.Windows.Forms.TextBox maxEnsayos;
        private System.Windows.Forms.TextBox minEnsayos;
        private System.Windows.Forms.TextBox numProblemas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label1;
    }
}