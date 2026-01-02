namespace GEOPREST {
    partial class MenuEstadistica {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.estanAgrupados = new System.Windows.Forms.CheckBox();
            this.numAlumnos = new System.Windows.Forms.TextBox();
            this.numDatosMin = new System.Windows.Forms.TextBox();
            this.numDatosMax = new System.Windows.Forms.TextBox();
            this.limInf = new System.Windows.Forms.TextBox();
            this.limSup = new System.Windows.Forms.TextBox();
            this.numDecimales = new System.Windows.Forms.TextBox();
            this.numIntervalos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ejercicioTxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProblemasPredefinidos = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mostrarDatos = new System.Windows.Forms.RichTextBox();
            this.mostrarDatos1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generador de problemas Estadisticos";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(727, 20);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(40, 30);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 40);
            this.panel1.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de Problemas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rango de los Valores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número de Decimales";
            // 
            // estanAgrupados
            // 
            this.estanAgrupados.AutoSize = true;
            this.estanAgrupados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estanAgrupados.Location = new System.Drawing.Point(775, 160);
            this.estanAgrupados.Name = "estanAgrupados";
            this.estanAgrupados.Size = new System.Drawing.Size(149, 25);
            this.estanAgrupados.TabIndex = 7;
            this.estanAgrupados.Text = "Datos Agrupados";
            this.estanAgrupados.UseVisualStyleBackColor = true;
            this.estanAgrupados.CheckedChanged += new System.EventHandler(this.estanAgrupados_CheckedChanged);
            // 
            // numAlumnos
            // 
            this.numAlumnos.AccessibleName = "";
            this.numAlumnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAlumnos.Location = new System.Drawing.Point(55, 194);
            this.numAlumnos.Name = "numAlumnos";
            this.numAlumnos.Size = new System.Drawing.Size(110, 29);
            this.numAlumnos.TabIndex = 8;
            // 
            // numDatosMin
            // 
            this.numDatosMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDatosMin.Location = new System.Drawing.Point(201, 194);
            this.numDatosMin.Name = "numDatosMin";
            this.numDatosMin.Size = new System.Drawing.Size(80, 29);
            this.numDatosMin.TabIndex = 9;
            // 
            // numDatosMax
            // 
            this.numDatosMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDatosMax.Location = new System.Drawing.Point(300, 194);
            this.numDatosMax.Name = "numDatosMax";
            this.numDatosMax.Size = new System.Drawing.Size(80, 29);
            this.numDatosMax.TabIndex = 10;
            // 
            // limInf
            // 
            this.limInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limInf.Location = new System.Drawing.Point(402, 194);
            this.limInf.Name = "limInf";
            this.limInf.Size = new System.Drawing.Size(80, 29);
            this.limInf.TabIndex = 11;
            // 
            // limSup
            // 
            this.limSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limSup.Location = new System.Drawing.Point(488, 194);
            this.limSup.Name = "limSup";
            this.limSup.Size = new System.Drawing.Size(80, 29);
            this.limSup.TabIndex = 12;
            // 
            // numDecimales
            // 
            this.numDecimales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDecimales.Location = new System.Drawing.Point(608, 194);
            this.numDecimales.Name = "numDecimales";
            this.numDecimales.Size = new System.Drawing.Size(125, 29);
            this.numDecimales.TabIndex = 13;
            // 
            // numIntervalos
            // 
            this.numIntervalos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIntervalos.Location = new System.Drawing.Point(797, 194);
            this.numIntervalos.Name = "numIntervalos";
            this.numIntervalos.Size = new System.Drawing.Size(88, 29);
            this.numIntervalos.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Texto del Ejercicio";
            // 
            // ejercicioTxt
            // 
            this.ejercicioTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejercicioTxt.Location = new System.Drawing.Point(43, 268);
            this.ejercicioTxt.Name = "ejercicioTxt";
            this.ejercicioTxt.Size = new System.Drawing.Size(638, 73);
            this.ejercicioTxt.TabIndex = 16;
            this.ejercicioTxt.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(710, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ejercicios Recomendados";
            // 
            // ProblemasPredefinidos
            // 
            this.ProblemasPredefinidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProblemasPredefinidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemasPredefinidos.FormattingEnabled = true;
            this.ProblemasPredefinidos.IntegralHeight = false;
            this.ProblemasPredefinidos.ItemHeight = 21;
            this.ProblemasPredefinidos.Items.AddRange(new object[] {
            "Calcular Estaturas",
            "Respuesta Servidor",
            "Uso del CPU",
            "Tamaño de Archivos",
            "Temperatura del Servidor",
            "Nivel de Satisfaccion",
            "Lineas de Codigo",
            "Errores del Programa",
            "Correos Electronicos"});
            this.ProblemasPredefinidos.Location = new System.Drawing.Point(714, 290);
            this.ProblemasPredefinidos.Name = "ProblemasPredefinidos";
            this.ProblemasPredefinidos.Size = new System.Drawing.Size(199, 29);
            this.ProblemasPredefinidos.TabIndex = 18;
            this.ProblemasPredefinidos.SelectedIndexChanged += new System.EventHandler(this.ProblemasPredefinidos_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(201, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Generar datos del Ejercicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(498, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Valores de los Ejercicios Generados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Datos de los Ejercicios Generados";
            // 
            // mostrarDatos
            // 
            this.mostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.mostrarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDatos.Location = new System.Drawing.Point(55, 477);
            this.mostrarDatos.Name = "mostrarDatos";
            this.mostrarDatos.Size = new System.Drawing.Size(415, 168);
            this.mostrarDatos.TabIndex = 23;
            this.mostrarDatos.Text = "";
            // 
            // mostrarDatos1
            // 
            this.mostrarDatos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.mostrarDatos1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDatos1.Location = new System.Drawing.Point(498, 477);
            this.mostrarDatos1.Name = "mostrarDatos1";
            this.mostrarDatos1.Size = new System.Drawing.Size(415, 168);
            this.mostrarDatos1.TabIndex = 24;
            this.mostrarDatos1.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(690, 662);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Guardar en XML";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(953, 709);
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
            this.Controls.Add(this.numIntervalos);
            this.Controls.Add(this.numDecimales);
            this.Controls.Add(this.limSup);
            this.Controls.Add(this.limInf);
            this.Controls.Add(this.numDatosMax);
            this.Controls.Add(this.numDatosMin);
            this.Controls.Add(this.numAlumnos);
            this.Controls.Add(this.estanAgrupados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox estanAgrupados;
        private System.Windows.Forms.TextBox numAlumnos;
        private System.Windows.Forms.TextBox numDatosMin;
        private System.Windows.Forms.TextBox numDatosMax;
        private System.Windows.Forms.TextBox limInf;
        private System.Windows.Forms.TextBox limSup;
        private System.Windows.Forms.TextBox numDecimales;
        private System.Windows.Forms.TextBox numIntervalos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox ejercicioTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ProblemasPredefinidos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox mostrarDatos;
        private System.Windows.Forms.RichTextBox mostrarDatos1;
        private System.Windows.Forms.Button button3;
    }
}

