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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void müşteriTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriTablosu ac = new MusteriTablosu();
            ac.ShowDialog();
        }

        private void araçTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracTablosu ac = new AracTablosu();
            ac.ShowDialog();
        }

        private void yeniSözleşmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniSozlesme ac = new YeniSozlesme();
            ac.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void sözleşmeBelgesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda ben = new Hakkinda();
            ben.ShowDialog();
        }
    }
}
