using System;

namespace GEOPREST.com.views {
    partial class MenuProbabilidad {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkCirR = new System.Windows.Forms.CheckBox();
            this.checkCirA = new System.Windows.Forms.CheckBox();
            this.checkCirV = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkNumC = new System.Windows.Forms.CheckBox();
            this.checkNumB = new System.Windows.Forms.CheckBox();
            this.checkNumA = new System.Windows.Forms.CheckBox();
            this.checkVarExt = new System.Windows.Forms.CheckBox();
            this.checkInter = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valorMax = new System.Windows.Forms.TextBox();
            this.valorMin = new System.Windows.Forms.TextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.pEjercicioTxt = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pProblemasPredefinidos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rutaTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numProblemas = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 40);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Crear Diagrama de Venn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "Diagramas de Venn";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(673, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 52;
            this.button3.Text = "Guardar en XML";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(482, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "Generar Diagrama de Venn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkCirR
            // 
            this.checkCirR.AutoSize = true;
            this.checkCirR.Checked = true;
            this.checkCirR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCirR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCirR.Location = new System.Drawing.Point(18, 6);
            this.checkCirR.Name = "checkCirR";
            this.checkCirR.Size = new System.Drawing.Size(98, 21);
            this.checkCirR.TabIndex = 56;
            this.checkCirR.Text = "Circulo Rojo";
            this.checkCirR.UseVisualStyleBackColor = true;
            this.checkCirR.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkCirA
            // 
            this.checkCirA.AutoSize = true;
            this.checkCirA.Checked = true;
            this.checkCirA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCirA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCirA.Location = new System.Drawing.Point(18, 33);
            this.checkCirA.Name = "checkCirA";
            this.checkCirA.Size = new System.Drawing.Size(95, 21);
            this.checkCirA.TabIndex = 57;
            this.checkCirA.Text = "Circulo Azul";
            this.checkCirA.UseVisualStyleBackColor = true;
            this.checkCirA.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkCirV
            // 
            this.checkCirV.AutoSize = true;
            this.checkCirV.Checked = true;
            this.checkCirV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCirV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCirV.Location = new System.Drawing.Point(18, 60);
            this.checkCirV.Name = "checkCirV";
            this.checkCirV.Size = new System.Drawing.Size(105, 21);
            this.checkCirV.TabIndex = 58;
            this.checkCirV.Text = "Circulo Verde";
            this.checkCirV.UseVisualStyleBackColor = true;
            this.checkCirV.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modificar diagrama de venn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkNumC
            // 
            this.checkNumC.AutoSize = true;
            this.checkNumC.Checked = true;
            this.checkNumC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNumC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumC.Location = new System.Drawing.Point(133, 60);
            this.checkNumC.Name = "checkNumC";
            this.checkNumC.Size = new System.Drawing.Size(158, 21);
            this.checkNumC.TabIndex = 66;
            this.checkNumC.Text = "Valor de la variable \'C\'";
            this.checkNumC.UseVisualStyleBackColor = true;
            this.checkNumC.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkNumB
            // 
            this.checkNumB.AutoSize = true;
            this.checkNumB.Checked = true;
            this.checkNumB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNumB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumB.Location = new System.Drawing.Point(133, 33);
            this.checkNumB.Name = "checkNumB";
            this.checkNumB.Size = new System.Drawing.Size(157, 21);
            this.checkNumB.TabIndex = 65;
            this.checkNumB.Text = "Valor de la variable \'B\'";
            this.checkNumB.UseVisualStyleBackColor = true;
            this.checkNumB.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkNumA
            // 
            this.checkNumA.AutoSize = true;
            this.checkNumA.Checked = true;
            this.checkNumA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNumA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNumA.Location = new System.Drawing.Point(133, 6);
            this.checkNumA.Name = "checkNumA";
            this.checkNumA.Size = new System.Drawing.Size(158, 21);
            this.checkNumA.TabIndex = 64;
            this.checkNumA.Text = "Valor de la variable \'A\'";
            this.checkNumA.UseVisualStyleBackColor = true;
            this.checkNumA.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkVarExt
            // 
            this.checkVarExt.AutoSize = true;
            this.checkVarExt.Checked = true;
            this.checkVarExt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkVarExt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVarExt.Location = new System.Drawing.Point(512, 143);
            this.checkVarExt.Name = "checkVarExt";
            this.checkVarExt.Size = new System.Drawing.Size(155, 38);
            this.checkVarExt.TabIndex = 67;
            this.checkVarExt.Text = "Mostrar sumatoria de\r\nlos circulos";
            this.checkVarExt.UseVisualStyleBackColor = true;
            this.checkVarExt.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkInter
            // 
            this.checkInter.AutoSize = true;
            this.checkInter.Checked = true;
            this.checkInter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkInter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInter.Location = new System.Drawing.Point(512, 187);
            this.checkInter.Name = "checkInter";
            this.checkInter.Size = new System.Drawing.Size(179, 38);
            this.checkInter.TabIndex = 68;
            this.checkInter.Text = "Variable en la interseccion\r\nde los Circulos";
            this.checkInter.UseVisualStyleBackColor = true;
            this.checkInter.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Valor maximo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Valor minimo:";
            // 
            // valorMax
            // 
            this.valorMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorMax.Location = new System.Drawing.Point(74, 316);
            this.valorMax.Name = "valorMax";
            this.valorMax.Size = new System.Drawing.Size(68, 25);
            this.valorMax.TabIndex = 74;
            this.valorMax.Text = "10";
            this.valorMax.TextChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // valorMin
            // 
            this.valorMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorMin.Location = new System.Drawing.Point(74, 269);
            this.valorMin.Name = "valorMin";
            this.valorMin.Size = new System.Drawing.Size(68, 25);
            this.valorMin.TabIndex = 73;
            this.valorMin.Text = "1";
            this.valorMin.TextChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.Location = new System.Drawing.Point(524, 269);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxPreview.TabIndex = 77;
            this.pictureBoxPreview.TabStop = false;
            // 
            // pEjercicioTxt
            // 
            this.pEjercicioTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEjercicioTxt.Location = new System.Drawing.Point(34, 385);
            this.pEjercicioTxt.Name = "pEjercicioTxt";
            this.pEjercicioTxt.Size = new System.Drawing.Size(467, 66);
            this.pEjercicioTxt.TabIndex = 78;
            this.pEjercicioTxt.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Texto del ejercicio";
            // 
            // pProblemasPredefinidos
            // 
            this.pProblemasPredefinidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pProblemasPredefinidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pProblemasPredefinidos.FormattingEnabled = true;
            this.pProblemasPredefinidos.IntegralHeight = false;
            this.pProblemasPredefinidos.ItemHeight = 21;
            this.pProblemasPredefinidos.Items.AddRange(new object[] {
            "Espacio Muestral",
            "Empresa Software",
            "Inscripcion Cursos",
            "Sistemas Operativos",
            "Centro de Investigacion",
            "Empresa Videojuegos",
            "Ciberseguridad",
            "Curso Ingenieria Info.",
            "Desarrollo Web",
            "Estudiantes Universidad",
            "Empresa Tecnologia"});
            this.pProblemasPredefinidos.Location = new System.Drawing.Point(725, 195);
            this.pProblemasPredefinidos.Name = "pProblemasPredefinidos";
            this.pProblemasPredefinidos.Size = new System.Drawing.Size(199, 29);
            this.pProblemasPredefinidos.TabIndex = 81;
            this.pProblemasPredefinidos.SelectedIndexChanged += new System.EventHandler(this.pProblemasPredefinidos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(721, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 21);
            this.label7.TabIndex = 80;
            this.label7.Text = "Ejercicios Recomendados";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 553);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(467, 144);
            this.richTextBox1.TabIndex = 82;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Ejercicios Generados";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(376, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 86;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rutaTxt
            // 
            this.rutaTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaTxt.Location = new System.Drawing.Point(115, 473);
            this.rutaTxt.Name = "rutaTxt";
            this.rutaTxt.Size = new System.Drawing.Size(245, 29);
            this.rutaTxt.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 42);
            this.label10.TabIndex = 84;
            this.label10.Text = "Ubicación de\r\nlas Imagenes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 88;
            this.label11.Text = "Numero de problemas:";
            // 
            // numProblemas
            // 
            this.numProblemas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProblemas.Location = new System.Drawing.Point(73, 213);
            this.numProblemas.Name = "numProblemas";
            this.numProblemas.Size = new System.Drawing.Size(68, 25);
            this.numProblemas.TabIndex = 87;
            this.numProblemas.Text = "1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(512, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 38);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = "Mostrar la probabilidad\r\nen los circulos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.checkCirR);
            this.panel2.Controls.Add(this.checkCirA);
            this.panel2.Controls.Add(this.checkCirV);
            this.panel2.Controls.Add(this.checkNumA);
            this.panel2.Controls.Add(this.checkNumB);
            this.panel2.Controls.Add(this.checkNumC);
            this.panel2.Location = new System.Drawing.Point(190, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 88);
            this.panel2.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(767, 592);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 50);
            this.button4.TabIndex = 90;
            this.button4.Text = "Limpiar Campos";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // MenuProbabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(953, 709);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numProblemas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rutaTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pProblemasPredefinidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pEjercicioTxt);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.valorMax);
            this.Controls.Add(this.valorMin);
            this.Controls.Add(this.checkInter);
            this.Controls.Add(this.checkVarExt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProbabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuProbabilidad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkCirR;
        private System.Windows.Forms.CheckBox checkCirA;
        private System.Windows.Forms.CheckBox checkCirV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkNumC;
        private System.Windows.Forms.CheckBox checkNumB;
        private System.Windows.Forms.CheckBox checkNumA;
        private System.Windows.Forms.CheckBox checkVarExt;
        private System.Windows.Forms.CheckBox checkInter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox valorMax;
        private System.Windows.Forms.TextBox valorMin;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.RichTextBox pEjercicioTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pProblemasPredefinidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rutaTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox numProblemas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
    }
}