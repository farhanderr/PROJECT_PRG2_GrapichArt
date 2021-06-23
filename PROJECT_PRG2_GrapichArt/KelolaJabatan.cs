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
    public partial class KelolaJabatan : Form
    {
        TambahJabatan a = new TambahJabatan();
        UbahJabatan b = new UbahJabatan();
        public KelolaJabatan()
        {
            InitializeComponent();
        }
        public void hide()
        {
            a.Hide();
            b.Hide();
        }

        private void btnTambahJabatan_Click(object sender, EventArgs e)
        {
            hide();
            a.TopLevel = false;
            a.TopMost = true;
            Panel_form.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void btnUbahJabatan_Click(object sender, EventArgs e)
        {
            hide();
            b.TopLevel = false;
            b.TopMost = true;
            Panel_form.Controls.Add(b);
            b.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            b.Dock = DockStyle.Fill;
            b.Show();
        }
    }
}
