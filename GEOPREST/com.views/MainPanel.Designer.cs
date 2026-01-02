namespace GEOPREST.com.views {
    partial class MainPanel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuTabCont = new System.Windows.Forms.Button();
            this.menuDistNormal = new System.Windows.Forms.Button();
            this.menuProb = new System.Windows.Forms.Button();
            this.menuDistBin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCont = new System.Windows.Forms.Panel();
            this.menuDistBinomial = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.menuDistBinomial);
            this.panel2.Controls.Add(this.menuTabCont);
            this.panel2.Controls.Add(this.menuDistNormal);
            this.panel2.Controls.Add(this.menuProb);
            this.panel2.Controls.Add(this.menuDistBin);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 54);
            this.panel2.TabIndex = 57;
            // 
            // menuTabCont
            // 
            this.menuTabCont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTabCont.Location = new System.Drawing.Point(607, 3);
            this.menuTabCont.Name = "menuTabCont";
            this.menuTabCont.Size = new System.Drawing.Size(111, 51);
            this.menuTabCont.TabIndex = 31;
            this.menuTabCont.Text = "Tablas de\r\nContingencia";
            this.menuTabCont.UseVisualStyleBackColor = true;
            this.menuTabCont.Click += new System.EventHandler(this.menuTabCont_Click);
            // 
            // menuDistNormal
            // 
            this.menuDistNormal.BackColor = System.Drawing.Color.White;
            this.menuDistNormal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDistNormal.Location = new System.Drawing.Point(717, 3);
            this.menuDistNormal.Name = "menuDistNormal";
            this.menuDistNormal.Size = new System.Drawing.Size(111, 51);
            this.menuDistNormal.TabIndex = 30;
            this.menuDistNormal.Text = "Distribución Normal";
            this.menuDistNormal.UseVisualStyleBackColor = false;
            this.menuDistNormal.Click += new System.EventHandler(this.menuOtro_Click);
            // 
            // menuProb
            // 
            this.menuProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProb.Location = new System.Drawing.Point(496, 3);
            this.menuProb.Name = "menuProb";
            this.menuProb.Size = new System.Drawing.Size(111, 51);
            this.menuProb.TabIndex = 29;
            this.menuProb.Text = "Diagramas de Venn";
            this.menuProb.UseVisualStyleBackColor = true;
            this.menuProb.Click += new System.EventHandler(this.menuProb_Click);
            // 
            // menuDistBin
            // 
            this.menuDistBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDistBin.Location = new System.Drawing.Point(383, 3);
            this.menuDistBin.Name = "menuDistBin";
            this.menuDistBin.Size = new System.Drawing.Size(113, 51);
            this.menuDistBin.TabIndex = 28;
            this.menuDistBin.Text = "Estadistica Descriptiva";
            this.menuDistBin.UseVisualStyleBackColor = true;
            this.menuDistBin.Click += new System.EventHandler(this.menuEstDes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label11.Location = new System.Drawing.Point(102, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 40);
            this.label11.TabIndex = 27;
            this.label11.Text = "GEOPREST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GEOPREST.Properties.Resources.GEOPREST_logo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCont
            // 
            this.panelCont.Location = new System.Drawing.Point(0, 52);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(953, 709);
            this.panelCont.TabIndex = 58;
            this.panelCont.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCont_Paint);
            // 
            // menuDistBinomial
            // 
            this.menuDistBinomial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDistBinomial.Location = new System.Drawing.Point(827, 3);
            this.menuDistBinomial.Name = "menuDistBinomial";
            this.menuDistBinomial.Size = new System.Drawing.Size(113, 51);
            this.menuDistBinomial.TabIndex = 32;
            this.menuDistBinomial.Text = "Distribución Binomial";
            this.menuDistBinomial.UseVisualStyleBackColor = true;
            this.menuDistBinomial.Click += new System.EventHandler(this.menuDistBinomial_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(951, 759);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL GEOPREST";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menuDistNormal;
        private System.Windows.Forms.Button menuProb;
        private System.Windows.Forms.Button menuDistBin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.Button menuTabCont;
        private System.Windows.Forms.Button menuDistBinomial;
    }
}