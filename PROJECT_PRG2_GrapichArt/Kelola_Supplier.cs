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
    public partial class Kelola_Supplier : Form
    {
        public Kelola_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTambahSupplier_Click(object sender, EventArgs e)
        {
            TambahSupplier a = new TambahSupplier();
            a.Show();
        }

        private void btnUbahJabatan_Click(object sender, EventArgs e)
        {
            UbahSupplier b = new UbahSupplier();
            b.Show();
        }
    }
}
