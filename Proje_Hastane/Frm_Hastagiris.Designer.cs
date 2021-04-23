namespace Proje_Hastane
{
    partial class Frm_Hastagiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.Lnkuyeol = new System.Windows.Forms.LinkLabel();
            this.Btngirisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(12, 129);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(134, 24);
            this.LblTc.TabIndex = 1;
            this.LblTc.Text = "Tc Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(161, 185);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(136, 29);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(161, 133);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(136, 29);
            this.MskTc.TabIndex = 1;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // Lnkuyeol
            // 
            this.Lnkuyeol.AutoSize = true;
            this.Lnkuyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lnkuyeol.Location = new System.Drawing.Point(346, 194);
            this.Lnkuyeol.Name = "Lnkuyeol";
            this.Lnkuyeol.Size = new System.Drawing.Size(62, 20);
            this.Lnkuyeol.TabIndex = 5;
            this.Lnkuyeol.TabStop = true;
            this.Lnkuyeol.Text = "Üye Ol";
            this.Lnkuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnkuyeol_LinkClicked);
            // 
            // Btngirisyap
            // 
            this.Btngirisyap.BackColor = System.Drawing.Color.White;
            this.Btngirisyap.Location = new System.Drawing.Point(183, 254);
            this.Btngirisyap.Name = "Btngirisyap";
            this.Btngirisyap.Size = new System.Drawing.Size(114, 45);
            this.Btngirisyap.TabIndex = 6;
            this.Btngirisyap.Text = "Giriş Yap";
            this.Btngirisyap.UseVisualStyleBackColor = false;
            this.Btngirisyap.Click += new System.EventHandler(this.Btngirisyap_Click);
            // 
            // Frm_Hastagiris
            // 
            this.AcceptButton = this.Btngirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(459, 322);
            this.Controls.Add(this.Btngirisyap);
            this.Controls.Add(this.Lnkuyeol);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Hastagiris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.Frm_Hastagiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.LinkLabel Lnkuyeol;
        private System.Windows.Forms.Button Btngirisyap;
    }
}