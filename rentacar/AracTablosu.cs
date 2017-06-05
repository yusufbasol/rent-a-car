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
    public partial class AracTablosu : Form
    {
        public AracTablosu()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            engine nesne = new engine();
            nesne.AracKaydet(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text);
            MessageBox.Show("Kaydedildi");
            DataGridView1.DataSource = nesne.TumAraclar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            engine nesne = new engine();
            DataGridView1.DataSource = nesne.TumAraclar();
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
                kmt.CommandText = "DELETE from AracTablosu WHERE Plaka='" + DataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                con.Close();
                engine nesne = new engine();
                DataGridView1.DataSource = nesne.TumAraclar();
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracTablosu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
