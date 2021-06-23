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
    public partial class KelolaBarang : Form
    {
        public KelolaBarang()
        {
            InitializeComponent();
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUbahDataBarang_Click(object sender, EventArgs e)
        {
            UbahBarang b = new UbahBarang();
            b.Show();
        }
    }
}
