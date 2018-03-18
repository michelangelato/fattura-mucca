namespace FatturaMucca
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMucca = new System.Windows.Forms.Button();
            this.imgMucca = new System.Windows.Forms.PictureBox();
            this.txtProfessionista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCommittente = new System.Windows.Forms.TextBox();
            this.txtImporto = new System.Windows.Forms.TextBox();
            this.btnTak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMucca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMucca
            // 
            this.btnMucca.Location = new System.Drawing.Point(27, 27);
            this.btnMucca.Name = "btnMucca";
            this.btnMucca.Size = new System.Drawing.Size(440, 47);
            this.btnMucca.TabIndex = 0;
            this.btnMucca.Text = "appari mucca";
            this.btnMucca.UseVisualStyleBackColor = true;
            this.btnMucca.Click += new System.EventHandler(this.btnMucca_Click);
            // 
            // imgMucca
            // 
            this.imgMucca.Image = ((System.Drawing.Image)(resources.GetObject("imgMucca.Image")));
            this.imgMucca.Location = new System.Drawing.Point(27, 102);
            this.imgMucca.Name = "imgMucca";
            this.imgMucca.Size = new System.Drawing.Size(440, 576);
            this.imgMucca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMucca.TabIndex = 1;
            this.imgMucca.TabStop = false;
            this.imgMucca.Visible = false;
            // 
            // txtProfessionista
            // 
            this.txtProfessionista.Location = new System.Drawing.Point(833, 102);
            this.txtProfessionista.Name = "txtProfessionista";
            this.txtProfessionista.Size = new System.Drawing.Size(399, 31);
            this.txtProfessionista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Professionista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Committente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 6;
            // 
            // txtCommittente
            // 
            this.txtCommittente.Location = new System.Drawing.Point(833, 144);
            this.txtCommittente.Name = "txtCommittente";
            this.txtCommittente.Size = new System.Drawing.Size(399, 31);
            this.txtCommittente.TabIndex = 7;
            // 
            // txtImporto
            // 
            this.txtImporto.BackColor = System.Drawing.SystemColors.Info;
            this.txtImporto.Location = new System.Drawing.Point(833, 189);
            this.txtImporto.Name = "txtImporto";
            this.txtImporto.Size = new System.Drawing.Size(399, 31);
            this.txtImporto.TabIndex = 8;
            // 
            // btnTak
            // 
            this.btnTak.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTak.Location = new System.Drawing.Point(600, 249);
            this.btnTak.Name = "btnTak";
            this.btnTak.Size = new System.Drawing.Size(636, 57);
            this.btnTak.TabIndex = 9;
            this.btnTak.Text = "Taaak";
            this.btnTak.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1388, 1157);
            this.Controls.Add(this.btnTak);
            this.Controls.Add(this.txtImporto);
            this.Controls.Add(this.txtCommittente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfessionista);
            this.Controls.Add(this.imgMucca);
            this.Controls.Add(this.btnMucca);
            this.Name = "frmMain";
            this.Text = "Fattura";
            ((System.ComponentModel.ISupportInitialize)(this.imgMucca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMucca;
        private System.Windows.Forms.PictureBox imgMucca;
        private System.Windows.Forms.TextBox txtProfessionista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCommittente;
        private System.Windows.Forms.TextBox txtImporto;
        private System.Windows.Forms.Button btnTak;
    }
}

