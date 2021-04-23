namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.TxtHastad = new System.Windows.Forms.TextBox();
            this.TxtHastsıfre = new System.Windows.Forms.TextBox();
            this.TxtHastsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mskhasttlf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbHastcins = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(143, 148);
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
            this.label3.Location = new System.Drawing.Point(62, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sifre:";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(3, 151);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(134, 24);
            this.LblTc.TabIndex = 5;
            this.LblTc.Text = "Tc Kimlik No:";
            // 
            // TxtHastad
            // 
            this.TxtHastad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHastad.Location = new System.Drawing.Point(143, 48);
            this.TxtHastad.Name = "TxtHastad";
            this.TxtHastad.Size = new System.Drawing.Size(136, 29);
            this.TxtHastad.TabIndex = 1;
            // 
            // TxtHastsıfre
            // 
            this.TxtHastsıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHastsıfre.Location = new System.Drawing.Point(143, 252);
            this.TxtHastsıfre.Name = "TxtHastsıfre";
            this.TxtHastsıfre.Size = new System.Drawing.Size(136, 29);
            this.TxtHastsıfre.TabIndex = 5;
            // 
            // TxtHastsoyad
            // 
            this.TxtHastsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHastsoyad.Location = new System.Drawing.Point(143, 98);
            this.TxtHastsoyad.Name = "TxtHastsoyad";
            this.TxtHastsoyad.Size = new System.Drawing.Size(136, 29);
            this.TxtHastsoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad:";
            // 
            // Mskhasttlf
            // 
            this.Mskhasttlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mskhasttlf.Location = new System.Drawing.Point(143, 201);
            this.Mskhasttlf.Mask = "(999) 000-0000";
            this.Mskhasttlf.Name = "Mskhasttlf";
            this.Mskhasttlf.Size = new System.Drawing.Size(136, 29);
            this.Mskhasttlf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefon:";
            // 
            // CmbHastcins
            // 
            this.CmbHastcins.FormattingEnabled = true;
            this.CmbHastcins.Location = new System.Drawing.Point(143, 297);
            this.CmbHastcins.Name = "CmbHastcins";
            this.CmbHastcins.Size = new System.Drawing.Size(136, 31);
            this.CmbHastcins.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cinsiyet:";
            // 
            // BtnKayıt
            // 
            this.BtnKayıt.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnKayıt.Location = new System.Drawing.Point(143, 356);
            this.BtnKayıt.Name = "BtnKayıt";
            this.BtnKayıt.Size = new System.Drawing.Size(106, 51);
            this.BtnKayıt.TabIndex = 18;
            this.BtnKayıt.Text = "Kayıt Yap";
            this.BtnKayıt.UseVisualStyleBackColor = false;
            this.BtnKayıt.Click += new System.EventHandler(this.BtnKayıt_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(351, 437);
            this.Controls.Add(this.BtnKayıt);
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
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.TextBox TxtHastad;
        private System.Windows.Forms.TextBox TxtHastsıfre;
        private System.Windows.Forms.TextBox TxtHastsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Mskhasttlf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbHastcins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKayıt;
    }
}