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
    public partial class MusteriTablosu : Form
    {
       

        public MusteriTablosu()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            engine nesne = new engine();
            nesne.KisiKaydet(txtTcKimlikNo.Text, txtAd.Text,txtSoyad.Text, cbCinsiyet.Text, DateTimePicker1.Text, txtDogumYeri.Text, txtTelefon.Text, txtCepTelefonu.Text,txtMail.Text,txtAdres.Text,txtEhliyetNo.Text, DateTimePicker2.Text,txtEhliyetVerilenYer.Text);
            MessageBox.Show("Kaydedildi");        
            dataGridView1.DataSource = nesne.TumKisiler();


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
                kmt.CommandText = "DELETE from MusteriTablosu WHERE TcKimlikNo='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                con.Close();
                engine nesne = new engine();
                dataGridView1.DataSource = nesne.TumKisiler();
            }
        }

        private void TcNumaraToolStripButton_Click(object sender, EventArgs e)
        {
            engine nesne = new engine();
            dataGridView1.DataSource = nesne.KisiBul(TcNumaraToolStripTextBox.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            engine nesne = new engine();
            dataGridView1.DataSource = nesne.TumKisiler();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriTablosu_Load(object sender, EventArgs e)
        {

        }
        


    }
}
