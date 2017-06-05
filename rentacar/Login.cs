using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rentacar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            engine nesne = new engine();
            bool kontrol = nesne.GirisKontrol(txtKullaniciAd.Text, txtSifre.Text);
            if (kontrol == true)
            {
                MessageBox.Show("Giriş Başarılı, Hoşgeldiniz...");
                this.Hide();
                Admin ac = new Admin();
                ac.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
