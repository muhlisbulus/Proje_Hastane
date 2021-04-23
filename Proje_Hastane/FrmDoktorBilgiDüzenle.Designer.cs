namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDüzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDoktorsoyad = new System.Windows.Forms.TextBox();
            this.TxtDoktorsıfre = new System.Windows.Forms.TextBox();
            this.TxtDoktorad = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.CmbBranş = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnGuncelle.Location = new System.Drawing.Point(131, 330);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(171, 51);
            this.BtnGuncelle.TabIndex = 44;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Soyad:";
            // 
            // TxtDoktorsoyad
            // 
            this.TxtDoktorsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDoktorsoyad.Location = new System.Drawing.Point(144, 85);
            this.TxtDoktorsoyad.Name = "TxtDoktorsoyad";
            this.TxtDoktorsoyad.Size = new System.Drawing.Size(136, 29);
            this.TxtDoktorsoyad.TabIndex = 37;
            // 
            // TxtDoktorsıfre
            // 
            this.TxtDoktorsıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDoktorsıfre.Location = new System.Drawing.Point(144, 246);
            this.TxtDoktorsıfre.Name = "TxtDoktorsıfre";
            this.TxtDoktorsıfre.Size = new System.Drawing.Size(136, 29);
            this.TxtDoktorsıfre.TabIndex = 36;
            // 
            // TxtDoktorad
            // 
            this.TxtDoktorad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDoktorad.Location = new System.Drawing.Point(144, 39);
            this.TxtDoktorad.Name = "TxtDoktorad";
            this.TxtDoktorad.Size = new System.Drawing.Size(136, 29);
            this.TxtDoktorad.TabIndex = 35;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(144, 132);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(136, 29);
            this.MskTc.TabIndex = 34;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sifre:";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(1, 137);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(134, 24);
            this.LblTc.TabIndex = 32;
            this.LblTc.Text = "Tc Kimlik No:";
            // 
            // CmbBranş
            // 
            this.CmbBranş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBranş.FormattingEnabled = true;
            this.CmbBranş.Location = new System.Drawing.Point(144, 186);
            this.CmbBranş.Name = "CmbBranş";
            this.CmbBranş.Size = new System.Drawing.Size(136, 28);
            this.CmbBranş.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Branş:";
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbBranş);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDoktorsoyad);
            this.Controls.Add(this.TxtDoktorsıfre);
            this.Controls.Add(this.TxtDoktorad);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTc);
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDoktorsoyad;
        private System.Windows.Forms.TextBox TxtDoktorsıfre;
        private System.Windows.Forms.TextBox TxtDoktorad;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.ComboBox CmbBranş;
        private System.Windows.Forms.Label label4;
    }
}