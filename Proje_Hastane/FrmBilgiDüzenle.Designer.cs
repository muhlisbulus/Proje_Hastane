namespace Proje_Hastane
{
    partial class FrmBilgiDüzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbHastcins = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mskhasttlf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHastsoyad = new System.Windows.Forms.TextBox();
            this.TxtHastsıfre = new System.Windows.Forms.TextBox();
            this.TxtHastad = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnGuncelle.Location = new System.Drawing.Point(139, 297);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(171, 51);
            this.BtnGuncelle.TabIndex = 31;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cinsiyet:";
            // 
            // CmbHastcins
            // 
            this.CmbHastcins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbHastcins.FormattingEnabled = true;
            this.CmbHastcins.Location = new System.Drawing.Point(152, 254);
            this.CmbHastcins.Name = "CmbHastcins";
            this.CmbHastcins.Size = new System.Drawing.Size(136, 24);
            this.CmbHastcins.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefon:";
            // 
            // Mskhasttlf
            // 
            this.Mskhasttlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mskhasttlf.Location = new System.Drawing.Point(152, 152);
            this.Mskhasttlf.Mask = "(999) 000-0000";
            this.Mskhasttlf.Name = "Mskhasttlf";
            this.Mskhasttlf.Size = new System.Drawing.Size(136, 29);
            this.Mskhasttlf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Soyad:";
            // 
            // TxtHastsoyad
            // 
            this.TxtHastsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHastsoyad.Location = new System.Drawing.Point(152, 52);
            this.TxtHastsoyad.Name = "TxtHastsoyad";
            this.TxtHastsoyad.Size = new System.Drawing.Size(136, 29);
            this.TxtHastsoyad.TabIndex = 2;
            this.TxtHastsoyad.TextChanged += new System.EventHandler(this.TxtHastsoyad_TextChanged);
            // 
            // TxtHastsıfre
            // 
            this.TxtHastsıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHastsıfre.Location = new System.Drawing.Point(152, 205);
            this.TxtHastsıfre.Name = "TxtHastsıfre";
            this.TxtHastsıfre.Size = new System.Drawing.Size(136, 29);
            this.TxtHastsıfre.TabIndex = 5;
            // 
            // TxtHastad
            // 
            this.TxtHastad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHastad.Location = new System.Drawing.Point(152, 6);
            this.TxtHastad.Name = "TxtHastad";
            this.TxtHastad.Size = new System.Drawing.Size(136, 29);
            this.TxtHastad.TabIndex = 1;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(152, 99);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(136, 29);
            this.MskTc.TabIndex = 3;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sifre:";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(9, 104);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(134, 24);
            this.LblTc.TabIndex = 19;
            this.LblTc.Text = "Tc Kimlik No:";
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.BtnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(353, 409);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbHastcins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mskhasttlf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHastsoyad);
            this.Controls.Add(this.TxtHastsıfre);
            this.Controls.Add(this.TxtHastad);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTc);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "FrmBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbHastcins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Mskhasttlf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHastsoyad;
        private System.Windows.Forms.TextBox TxtHastsıfre;
        private System.Windows.Forms.TextBox TxtHastad;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTc;
    }
}