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
    public partial class FormManager : Form
    {
        Laporan_pembelian lappem = new Laporan_pembelian();
        Laporan_Penjualan lappenj = new Laporan_Penjualan();
        public FormManager()
        {
            InitializeComponent();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            lappem.Hide();
            lappenj.Hide();

            lappenj.TopLevel = false;
            lappenj.TopMost = true;
            Panel_form2.Controls.Add(lappenj);
            lappenj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lappenj.Dock = DockStyle.Fill;
            lappenj.Show();

        }

        private void btnLaporanPembelian_Click(object sender, EventArgs e)
        {
            lappem.Hide();
            lappenj.Hide();

            lappem.TopLevel = false;
            lappem.TopMost = true;
            Panel_form2.Controls.Add(lappem);
            lappem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lappem.Dock = DockStyle.Fill;
            lappem.Show();
        }

        private void btnDasboardManager_Click(object sender, EventArgs e)
        {
            lappem.Hide();
            lappenj.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin a = new FormLogin();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
