using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        private void TxtHastsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        public string TCno;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtHastad.Text = dr[1].ToString();
                TxtHastsoyad.Text = dr[2].ToString();
                Mskhasttlf.Text = dr[4].ToString();
                TxtHastsıfre.Text = dr[5].ToString();
                CmbHastcins.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtHastad.Text);
            komut2.Parameters.AddWithValue("@p2", TxtHastsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", Mskhasttlf.Text);
            komut2.Parameters.AddWithValue("@p4", TxtHastsıfre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbHastcins.Text);
            komut2.Parameters.AddWithValue("@p6", MskTc.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

    }
        

    }
}
