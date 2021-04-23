namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSekreterAdSoyad = new System.Windows.Forms.Label();
            this.LblSekreterTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btnolustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ChbDurum = new System.Windows.Forms.CheckBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbSekreterDoktor = new System.Windows.Forms.ComboBox();
            this.Cmbbrans = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtSekreterid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuliste = new System.Windows.Forms.Button();
            this.Btnbranspanel = new System.Windows.Forms.Button();
            this.BtnDoktorpanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSekreterAdSoyad);
            this.groupBox1.Controls.Add(this.LblSekreterTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEKRETER BİLGİ";
            // 
            // LblSekreterAdSoyad
            // 
            this.LblSekreterAdSoyad.AutoSize = true;
            this.LblSekreterAdSoyad.Location = new System.Drawing.Point(112, 96);
            this.LblSekreterAdSoyad.Name = "LblSekreterAdSoyad";
            this.LblSekreterAdSoyad.Size = new System.Drawing.Size(76, 23);
            this.LblSekreterAdSoyad.TabIndex = 3;
            this.LblSekreterAdSoyad.Text = "Null Null";
            // 
            // LblSekreterTc
            // 
            this.LblSekreterTc.AutoSize = true;
            this.LblSekreterTc.Location = new System.Drawing.Point(82, 45);
            this.LblSekreterTc.Name = "LblSekreterTc";
            this.LblSekreterTc.Size = new System.Drawing.Size(120, 23);
            this.LblSekreterTc.TabIndex = 2;
            this.LblSekreterTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btnolustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // Btnolustur
            // 
            this.Btnolustur.Location = new System.Drawing.Point(0, 193);
            this.Btnolustur.Name = "Btnolustur";
            this.Btnolustur.Size = new System.Drawing.Size(231, 39);
            this.Btnolustur.TabIndex = 1;
            this.Btnolustur.Text = "Oluştur";
            this.Btnolustur.UseVisualStyleBackColor = true;
            this.Btnolustur.Click += new System.EventHandler(this.Btnolustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(0, 30);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(231, 157);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.ChbDurum);
            this.groupBox3.Controls.Add(this.MskTc);
            this.groupBox3.Controls.Add(this.CmbSekreterDoktor);
            this.groupBox3.Controls.Add(this.Cmbbrans);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.TxtSekreterid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(249, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 416);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(59, 327);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(141, 30);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ChbDurum
            // 
            this.ChbDurum.AutoSize = true;
            this.ChbDurum.Location = new System.Drawing.Point(83, 294);
            this.ChbDurum.Name = "ChbDurum";
            this.ChbDurum.Size = new System.Drawing.Size(84, 27);
            this.ChbDurum.TabIndex = 14;
            this.ChbDurum.Text = "Durum";
            this.ChbDurum.UseVisualStyleBackColor = true;
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(67, 254);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(133, 31);
            this.MskTc.TabIndex = 13;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // CmbSekreterDoktor
            // 
            this.CmbSekreterDoktor.FormattingEnabled = true;
            this.CmbSekreterDoktor.Location = new System.Drawing.Point(71, 205);
            this.CmbSekreterDoktor.Name = "CmbSekreterDoktor";
            this.CmbSekreterDoktor.Size = new System.Drawing.Size(121, 31);
            this.CmbSekreterDoktor.TabIndex = 12;
            // 
            // Cmbbrans
            // 
            this.Cmbbrans.FormattingEnabled = true;
            this.Cmbbrans.Location = new System.Drawing.Point(71, 165);
            this.Cmbbrans.Name = "Cmbbrans";
            this.Cmbbrans.Size = new System.Drawing.Size(121, 31);
            this.Cmbbrans.TabIndex = 11;
            this.Cmbbrans.SelectedIndexChanged += new System.EventHandler(this.Cmbbrans_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(67, 125);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(125, 31);
            this.MskSaat.TabIndex = 10;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(59, 75);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(133, 31);
            this.MskTarih.TabIndex = 9;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtSekreterid
            // 
            this.TxtSekreterid.Location = new System.Drawing.Point(59, 35);
            this.TxtSekreterid.Name = "TxtSekreterid";
            this.TxtSekreterid.Size = new System.Drawing.Size(133, 31);
            this.TxtSekreterid.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(474, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 191);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(477, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 371);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 341);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnRandevuliste);
            this.groupBox6.Controls.Add(this.Btnbranspanel);
            this.groupBox6.Controls.Add(this.BtnDoktorpanel);
            this.groupBox6.Location = new System.Drawing.Point(0, 434);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(468, 140);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnRandevuliste
            // 
            this.BtnRandevuliste.Location = new System.Drawing.Point(259, 31);
            this.BtnRandevuliste.Name = "BtnRandevuliste";
            this.BtnRandevuliste.Size = new System.Drawing.Size(132, 39);
            this.BtnRandevuliste.TabIndex = 2;
            this.BtnRandevuliste.Text = "Randevu Liste";
            this.BtnRandevuliste.UseVisualStyleBackColor = true;
            this.BtnRandevuliste.Click += new System.EventHandler(this.BtnRandevuliste_Click);
            // 
            // Btnbranspanel
            // 
            this.Btnbranspanel.Location = new System.Drawing.Point(134, 31);
            this.Btnbranspanel.Name = "Btnbranspanel";
            this.Btnbranspanel.Size = new System.Drawing.Size(119, 39);
            this.Btnbranspanel.TabIndex = 1;
            this.Btnbranspanel.Text = "Branş Paneli";
            this.Btnbranspanel.UseVisualStyleBackColor = true;
            this.Btnbranspanel.Click += new System.EventHandler(this.Btnbranspanel_Click);
            // 
            // BtnDoktorpanel
            // 
            this.BtnDoktorpanel.Location = new System.Drawing.Point(0, 30);
            this.BtnDoktorpanel.Name = "BtnDoktorpanel";
            this.BtnDoktorpanel.Size = new System.Drawing.Size(128, 40);
            this.BtnDoktorpanel.TabIndex = 0;
            this.BtnDoktorpanel.Text = "Doktor Paneli";
            this.BtnDoktorpanel.UseVisualStyleBackColor = true;
            this.BtnDoktorpanel.Click += new System.EventHandler(this.BtnDoktorpanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyuru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(849, 586);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSekreterAdSoyad;
        private System.Windows.Forms.Label LblSekreterTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btnolustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox ChbDurum;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.ComboBox CmbSekreterDoktor;
        private System.Windows.Forms.ComboBox Cmbbrans;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox TxtSekreterid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnDoktorpanel;
        private System.Windows.Forms.Button Btnbranspanel;
        private System.Windows.Forms.Button BtnRandevuliste;
        private System.Windows.Forms.Button button1;
    }
}