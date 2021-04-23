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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtHastad.Text);
            komut.Parameters.AddWithValue("@p2", TxtHastsoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", Mskhasttlf.Text);
            komut.Parameters.AddWithValue("@p5", TxtHastsıfre.Text);
            komut.Parameters.AddWithValue("@p6", CmbHastcins.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir:"+TxtHastsıfre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
