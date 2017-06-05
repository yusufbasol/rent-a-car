using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rentacar
{
    public partial class YeniSozlesme : Form
    {

        public YeniSozlesme()
        {
            InitializeComponent();
        }

        public void comboTcKimlik()
        {
            ComboBox1.Items.Clear();
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            SQLiteCommand kmt = new SQLiteCommand();
            con.Open();

            kmt.Connection = con;
            kmt.CommandText = "Select TcKimlikNo from MusteriTablosu";
            SQLiteDataReader oku = default(SQLiteDataReader);
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ComboBox1.Items.Add(oku[0].ToString());
            }
            con.Close();
            oku.Dispose();

        }
        public void comboPlaka() {
            ComboBox3.Items.Clear();
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            SQLiteCommand kmt = new SQLiteCommand();
            con.Open();
            kmt.Connection = con;
            kmt.CommandText = "Select Plaka from AracTablosu";
            SQLiteDataReader oku = default(SQLiteDataReader);
            oku = kmt.ExecuteReader();
            while (oku.Read()) {
                ComboBox3.Items.Add(oku[0].ToString());
            }
            con.Close();
            oku.Dispose();
        }
        public void sozlesmeListele() {
            DataTable dt = new DataTable();
            dt.Clear();
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteDataAdapter adp = new SQLiteDataAdapter("select * From SozlesmeBilgisi", con);
            adp.Fill(dt);
            DataGridView1.DataSource = dt;
            con.Close();
            adp.Dispose();
        }

        private void YeniSozlesme_Load(object sender, EventArgs e)
        {
            comboTcKimlik();
            comboPlaka();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand kmt = new SQLiteCommand();
            kmt.Connection = con;
            kmt.CommandText = "INSERT INTO SozlesmeBilgisi(TcKimlikNo,Ad,Soyad,Cinsiyet,DogumTarihi,DogumYeri,Telefon,CepTel,Email,Adres,EhliyetNo,EhliyetTarihi,EhliyetVerilenYer,SurucuAd,KefilAd,KefilSoyad,KefilAdres,KefilTel,KefilCep,Plaka,Marka,Tip,Model,Renk,Gunluk,Haftalik,Aylik,CikisZamani,DonusZamani,EkTutar,Toplam,Aciklama) VALUES ('" + txtTcKimlikNo.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + cbCinsiyet.Text + "','" + DateTimePicker1.Text + "','" + txtDogumYeri.Text + "','" + txtTelefon.Text + "','" + txtCepTelefonu.Text + "','" + txtMail.Text + "','" + txtAdres.Text + "','" + txtEhliyetNo.Text + "','" + DateTimePicker2.Text + "','" + txtEhliyetVerilenYer.Text + "','" + txtSurucuAd.Text + "','" + txtKefilAd.Text + "','" + txtKefilSoyad.Text + "','" + txtKefilAdres.Text + "','" + txtKefilTel.Text + "','" + txtKefilCep.Text + "','" + txtPlaka.Text + "','" + txtMarka.Text + "','" + txtTip.Text + "','" + txtModel.Text + "','" + txtRenk.Text + "','" + txtGunluk.Text + "','" + txtHaftalik.Text + "','" + txtAylik.Text + "','" + DateTimePicker3.Text + "','" + DateTimePicker4.Text + "','" + txtEkTutar.Text + "','" + txtToplam.Text + "','" + txtAciklama.Text + "') ";
            kmt.ExecuteNonQuery();
            kmt.CommandText = "UPDATE AracTablosu SET Durum='Kirada' WHERE Plaka='" + ComboBox3.Text + "' ";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            con.Close();
            sozlesmeListele();
            ComboBox3.Text = "";
            comboPlaka();
            MessageBox.Show("Kiralama işlemi tamamlandı ");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult rizalt = new DialogResult();
            rizalt = MessageBox.Show("Silmek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            SQLiteCommand kmt = new SQLiteCommand();
            if ((rizalt == System.Windows.Forms.DialogResult.Yes))
            {
                con.Open();
                kmt.Connection = con;
                kmt.CommandText = "DELETE from SozlesmeBilgisi WHERE Plaka='"+ DataGridView1.CurrentRow.Cells[20].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                con.Close();
                sozlesmeListele(); 
            }
            }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand kmt = new SQLiteCommand();
            kmt.Connection = con;
            kmt.CommandText = "Select * from MusteriTablosu where TcKimlikNo='" + ComboBox1.Text + "'";
            SQLiteDataReader oku = default(SQLiteDataReader);

            oku = kmt.ExecuteReader();
            while (oku.Read()) {
                txtTcKimlikNo.Text = oku[1].ToString();
                txtAd.Text = oku[2].ToString();
                txtSoyad.Text = oku[3].ToString();
                cbCinsiyet.Text = oku[4].ToString();
                DateTimePicker1.Text = oku[5].ToString();
                txtDogumYeri.Text = oku[6].ToString();
                txtTelefon.Text = oku[7].ToString();
                txtCepTelefonu.Text = oku[8].ToString();
                txtMail.Text = oku[9].ToString();
                txtAdres.Text = oku[10].ToString();
                txtEhliyetNo.Text = oku[11].ToString();
                DateTimePicker2.Text = oku[12].ToString();
                txtEhliyetVerilenYer.Text = oku[13].ToString();

            }
            kmt.Dispose();
            con.Close();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand kmt = new SQLiteCommand();
            kmt.Connection = con;
            kmt.CommandText = "Select * from AracTablosu where Plaka='" + ComboBox3.Text + "'";
            SQLiteDataReader oku = default(SQLiteDataReader);
            oku = kmt.ExecuteReader();
            while (oku.Read()) {
                txtPlaka.Text = oku[0].ToString();
                txtPlaka.Text = oku[1].ToString();
                txtMarka.Text = oku[2].ToString();
                txtTip.Text = oku[3].ToString();
                txtModel.Text = oku[4].ToString();
                txtRenk.Text = oku[5].ToString();
                txtGunluk.Text = oku[6].ToString();
                txtHaftalik.Text = oku[7].ToString();
            }
            kmt.Dispose();
            con.Close();


        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand kmt = new SQLiteCommand();
            kmt.Connection = con;
            kmt.CommandText = "UPDATE AracTablosu SET Durum='Uygun' WHERE Plaka='" + DataGridView1.CurrentRow.Cells[20].Value.ToString() + "' ";
            kmt.ExecuteNonQuery();
            kmt.CommandText = "DELETE from SozlesmeBilgisi WHERE Plaka='" + DataGridView1.CurrentRow.Cells[20].Value.ToString() + "'";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            con.Close();
            comboPlaka();
            sozlesmeListele();
            MessageBox.Show("Teslim alma işlemi gerçekleştirildi. ");
    }
    }
}

