namespace GEOPREST.com.views {
    partial class GenerateXMLWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateXMLWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomProblema = new System.Windows.Forms.TextBox();
            this.categoriaProb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.sumatoriaCheck = new System.Windows.Forms.CheckBox();
            this.labelESum = new System.Windows.Forms.Label();
            this.errorSumatoria = new System.Windows.Forms.TextBox();
            this.errorMedia = new System.Windows.Forms.TextBox();
            this.labelEMed = new System.Windows.Forms.Label();
            this.mediaCheck = new System.Windows.Forms.CheckBox();
            this.errorVarianza = new System.Windows.Forms.TextBox();
            this.labelEVar = new System.Windows.Forms.Label();
            this.varianzaCheck = new System.Windows.Forms.CheckBox();
            this.errorDesviacion = new System.Windows.Forms.TextBox();
            this.labelEDes = new System.Windows.Forms.Label();
            this.desEstandarCheck = new System.Windows.Forms.CheckBox();
            this.errorCof = new System.Windows.Forms.TextBox();
            this.labelECof = new System.Windows.Forms.Label();
            this.cofVariacionCheck = new System.Windows.Forms.CheckBox();
            this.rutaTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.csvTextBox = new System.Windows.Forms.TextBox();
            this.csvLabel = new System.Windows.Forms.Label();
            this.generarCsv = new System.Windows.Forms.CheckBox();
            this.csvButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Problema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la categoria:";
            // 
            // nomProblema
            // 
            this.nomProblema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomProblema.Location = new System.Drawing.Point(270, 85);
            this.nomProblema.Name = "nomProblema";
            this.nomProblema.Size = new System.Drawing.Size(371, 29);
            this.nomProblema.TabIndex = 2;
            this.nomProblema.Text = "Problema 1";
            // 
            // categoriaProb
            // 
            this.categoriaProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaProb.Location = new System.Drawing.Point(270, 132);
            this.categoriaProb.Name = "categoriaProb";
            this.categoriaProb.Size = new System.Drawing.Size(371, 29);
            this.categoriaProb.TabIndex = 3;
            this.categoriaProb.Text = "Por Defecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "GENERAR ARCHIVO XML";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 57);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(80, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 44);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ejercicios a pedir en el problema";
            // 
            // sumatoriaCheck
            // 
            this.sumatoriaCheck.AutoSize = true;
            this.sumatoriaCheck.Checked = true;
            this.sumatoriaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sumatoriaCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumatoriaCheck.Location = new System.Drawing.Point(89, 258);
            this.sumatoriaCheck.Name = "sumatoriaCheck";
            this.sumatoriaCheck.Size = new System.Drawing.Size(101, 25);
            this.sumatoriaCheck.TabIndex = 7;
            this.sumatoriaCheck.Text = "Sumatoria";
            this.sumatoriaCheck.UseVisualStyleBackColor = true;
            this.sumatoriaCheck.CheckedChanged += new System.EventHandler(this.sumatoriaCheck_CheckedChanged);
            // 
            // labelESum
            // 
            this.labelESum.AutoSize = true;
            this.labelESum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelESum.Location = new System.Drawing.Point(54, 286);
            this.labelESum.Name = "labelESum";
            this.labelESum.Size = new System.Drawing.Size(103, 17);
            this.labelESum.TabIndex = 8;
            this.labelESum.Text = "Error Aceptable:";
            // 
            // errorSumatoria
            // 
            this.errorSumatoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSumatoria.Location = new System.Drawing.Point(163, 283);
            this.errorSumatoria.Name = "errorSumatoria";
            this.errorSumatoria.Size = new System.Drawing.Size(48, 25);
            this.errorSumatoria.TabIndex = 9;
            this.errorSumatoria.Text = "1";
            // 
            // errorMedia
            // 
            this.errorMedia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMedia.Location = new System.Drawing.Point(393, 283);
            this.errorMedia.Name = "errorMedia";
            this.errorMedia.Size = new System.Drawing.Size(48, 25);
            this.errorMedia.TabIndex = 12;
            this.errorMedia.Text = "1";
            // 
            // labelEMed
            // 
            this.labelEMed.AutoSize = true;
            this.labelEMed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMed.Location = new System.Drawing.Point(284, 286);
            this.labelEMed.Name = "labelEMed";
            this.labelEMed.Size = new System.Drawing.Size(103, 17);
            this.labelEMed.TabIndex = 11;
            this.labelEMed.Text = "Error Aceptable:";
            // 
            // mediaCheck
            // 
            this.mediaCheck.AutoSize = true;
            this.mediaCheck.Checked = true;
            this.mediaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediaCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaCheck.Location = new System.Drawing.Point(319, 258);
            this.mediaCheck.Name = "mediaCheck";
            this.mediaCheck.Size = new System.Drawing.Size(72, 25);
            this.mediaCheck.TabIndex = 10;
            this.mediaCheck.Text = "Media";
            this.mediaCheck.UseVisualStyleBackColor = true;
            this.mediaCheck.CheckedChanged += new System.EventHandler(this.mediaCheck_CheckedChanged_1);
            // 
            // errorVarianza
            // 
            this.errorVarianza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorVarianza.Location = new System.Drawing.Point(614, 283);
            this.errorVarianza.Name = "errorVarianza";
            this.errorVarianza.Size = new System.Drawing.Size(48, 25);
            this.errorVarianza.TabIndex = 15;
            this.errorVarianza.Text = "1";
            // 
            // labelEVar
            // 
            this.labelEVar.AutoSize = true;
            this.labelEVar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEVar.Location = new System.Drawing.Point(505, 286);
            this.labelEVar.Name = "labelEVar";
            this.labelEVar.Size = new System.Drawing.Size(103, 17);
            this.labelEVar.TabIndex = 14;
            this.labelEVar.Text = "Error Aceptable:";
            // 
            // varianzaCheck
            // 
            this.varianzaCheck.AutoSize = true;
            this.varianzaCheck.Checked = true;
            this.varianzaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.varianzaCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varianzaCheck.Location = new System.Drawing.Point(540, 258);
            this.varianzaCheck.Name = "varianzaCheck";
            this.varianzaCheck.Size = new System.Drawing.Size(88, 25);
            this.varianzaCheck.TabIndex = 13;
            this.varianzaCheck.Text = "Varianza";
            this.varianzaCheck.UseVisualStyleBackColor = true;
            this.varianzaCheck.CheckedChanged += new System.EventHandler(this.varianzaCheck_CheckedChanged_1);
            // 
            // errorDesviacion
            // 
            this.errorDesviacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDesviacion.Location = new System.Drawing.Point(276, 352);
            this.errorDesviacion.Name = "errorDesviacion";
            this.errorDesviacion.Size = new System.Drawing.Size(48, 25);
            this.errorDesviacion.TabIndex = 18;
            this.errorDesviacion.Text = "1";
            // 
            // labelEDes
            // 
            this.labelEDes.AutoSize = true;
            this.labelEDes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEDes.Location = new System.Drawing.Point(167, 355);
            this.labelEDes.Name = "labelEDes";
            this.labelEDes.Size = new System.Drawing.Size(103, 17);
            this.labelEDes.TabIndex = 17;
            this.labelEDes.Text = "Error Aceptable:";
            // 
            // desEstandarCheck
            // 
            this.desEstandarCheck.AutoSize = true;
            this.desEstandarCheck.Checked = true;
            this.desEstandarCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desEstandarCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desEstandarCheck.Location = new System.Drawing.Point(170, 327);
            this.desEstandarCheck.Name = "desEstandarCheck";
            this.desEstandarCheck.Size = new System.Drawing.Size(168, 25);
            this.desEstandarCheck.TabIndex = 16;
            this.desEstandarCheck.Text = "Desviación Estandar";
            this.desEstandarCheck.UseVisualStyleBackColor = true;
            this.desEstandarCheck.CheckedChanged += new System.EventHandler(this.desEstandarCheck_CheckedChanged_1);
            // 
            // errorCof
            // 
            this.errorCof.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCof.Location = new System.Drawing.Point(524, 352);
            this.errorCof.Name = "errorCof";
            this.errorCof.Size = new System.Drawing.Size(48, 25);
            this.errorCof.TabIndex = 21;
            this.errorCof.Text = "1";
            // 
            // labelECof
            // 
            this.labelECof.AutoSize = true;
            this.labelECof.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelECof.Location = new System.Drawing.Point(415, 355);
            this.labelECof.Name = "labelECof";
            this.labelECof.Size = new System.Drawing.Size(103, 17);
            this.labelECof.TabIndex = 20;
            this.labelECof.Text = "Error Aceptable:";
            // 
            // cofVariacionCheck
            // 
            this.cofVariacionCheck.AutoSize = true;
            this.cofVariacionCheck.Checked = true;
            this.cofVariacionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cofVariacionCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofVariacionCheck.Location = new System.Drawing.Point(404, 327);
            this.cofVariacionCheck.Name = "cofVariacionCheck";
            this.cofVariacionCheck.Size = new System.Drawing.Size(195, 25);
            this.cofVariacionCheck.TabIndex = 19;
            this.cofVariacionCheck.Text = "Coeficiente de Variación";
            this.cofVariacionCheck.UseVisualStyleBackColor = true;
            this.cofVariacionCheck.CheckedChanged += new System.EventHandler(this.cofVariacionCheck_CheckedChanged_1);
            // 
            // rutaTxt
            // 
            this.rutaTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaTxt.Location = new System.Drawing.Point(228, 434);
            this.rutaTxt.Name = "rutaTxt";
            this.rutaTxt.Size = new System.Drawing.Size(309, 29);
            this.rutaTxt.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ubicación del Archivo:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(574, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = "Abrir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(261, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 43);
            this.button4.TabIndex = 25;
            this.button4.Text = "Guardar Archivo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // csvTextBox
            // 
            this.csvTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvTextBox.Location = new System.Drawing.Point(324, 390);
            this.csvTextBox.Name = "csvTextBox";
            this.csvTextBox.Size = new System.Drawing.Size(213, 29);
            this.csvTextBox.TabIndex = 27;
            this.csvTextBox.Visible = false;
            // 
            // csvLabel
            // 
            this.csvLabel.AutoSize = true;
            this.csvLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvLabel.Location = new System.Drawing.Point(192, 393);
            this.csvLabel.Name = "csvLabel";
            this.csvLabel.Size = new System.Drawing.Size(123, 21);
            this.csvLabel.TabIndex = 26;
            this.csvLabel.Text = "Ruta de los CSV:";
            this.csvLabel.Visible = false;
            // 
            // generarCsv
            // 
            this.generarCsv.AutoSize = true;
            this.generarCsv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarCsv.Location = new System.Drawing.Point(68, 392);
            this.generarCsv.Name = "generarCsv";
            this.generarCsv.Size = new System.Drawing.Size(118, 25);
            this.generarCsv.TabIndex = 28;
            this.generarCsv.Text = "Generar CSV";
            this.generarCsv.UseVisualStyleBackColor = true;
            this.generarCsv.CheckedChanged += new System.EventHandler(this.generarCsv_CheckedChanged_1);
            // 
            // csvButton
            // 
            this.csvButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.csvButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csvButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvButton.ForeColor = System.Drawing.Color.White;
            this.csvButton.Location = new System.Drawing.Point(574, 388);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(125, 29);
            this.csvButton.TabIndex = 29;
            this.csvButton.Text = "Abrir";
            this.csvButton.UseVisualStyleBackColor = false;
            this.csvButton.Visible = false;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // GenerateXMLWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(763, 562);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.generarCsv);
            this.Controls.Add(this.csvTextBox);
            this.Controls.Add(this.csvLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rutaTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.errorCof);
            this.Controls.Add(this.labelECof);
            this.Controls.Add(this.cofVariacionCheck);
            this.Controls.Add(this.errorDesviacion);
            this.Controls.Add(this.labelEDes);
            this.Controls.Add(this.desEstandarCheck);
            this.Controls.Add(this.errorVarianza);
            this.Controls.Add(this.labelEVar);
            this.Controls.Add(this.varianzaCheck);
            this.Controls.Add(this.errorMedia);
            this.Controls.Add(this.labelEMed);
            this.Controls.Add(this.mediaCheck);
            this.Controls.Add(this.errorSumatoria);
            this.Controls.Add(this.labelESum);
            this.Controls.Add(this.sumatoriaCheck);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.categoriaProb);
            this.Controls.Add(this.nomProblema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateXMLWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR XML ESTADISTICA";
            this.Load += new System.EventHandler(this.GenerateXMLWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomProblema;
        private System.Windows.Forms.TextBox categoriaProb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sumatoriaCheck;
        private System.Windows.Forms.Label labelESum;
        private System.Windows.Forms.TextBox errorSumatoria;
        private System.Windows.Forms.TextBox errorMedia;
        private System.Windows.Forms.Label labelEMed;
        private System.Windows.Forms.CheckBox mediaCheck;
        private System.Windows.Forms.TextBox errorVarianza;
        private System.Windows.Forms.Label labelEVar;
        private System.Windows.Forms.CheckBox varianzaCheck;
        private System.Windows.Forms.TextBox errorDesviacion;
        private System.Windows.Forms.Label labelEDes;
        private System.Windows.Forms.CheckBox desEstandarCheck;
        private System.Windows.Forms.TextBox errorCof;
        private System.Windows.Forms.Label labelECof;
        private System.Windows.Forms.CheckBox cofVariacionCheck;
        private System.Windows.Forms.TextBox rutaTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox csvTextBox;
        private System.Windows.Forms.Label csvLabel;
        private System.Windows.Forms.CheckBox generarCsv;
        private System.Windows.Forms.Button csvButton;
    }
}