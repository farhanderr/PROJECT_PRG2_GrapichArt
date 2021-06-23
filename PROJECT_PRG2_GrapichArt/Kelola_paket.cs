using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_GrapichArt
{
    public partial class Kelola_paket : Form
    {
        public Kelola_paket()
        {
            InitializeComponent();
        }

        private void btnTambahPaket_Click(object sender, EventArgs e)
        {
            TambahPaket a = new TambahPaket();
            a.Show();
        }

        private void btnUbahDataBarang_Click(object sender, EventArgs e)
        {
            UbahPaket b = new UbahPaket();
            b.Show();
        }
    }
}
