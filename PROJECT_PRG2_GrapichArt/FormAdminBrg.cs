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
    public partial class FormAdminBrg : Form
    {

        Kelola_Supplier kelsup = new Kelola_Supplier();
        Kelola_paket kelpak = new Kelola_paket();
        KelolaBarang kelbar = new KelolaBarang();
        public FormAdminBrg()
        {
            InitializeComponent();
        }

        private void btnKelolaSupplier_Click(object sender, EventArgs e)
        {

            kelpak.Hide();
            kelsup.Hide();
            kelbar.Hide();
            kelsup.TopLevel = false;
            kelsup.TopMost = true;
            Form_panel3.Controls.Add(kelsup);
            kelsup.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kelsup.Dock = DockStyle.Fill;
            kelsup.Show();
        }

        private void btnGaji_Click(object sender, EventArgs e)
        {

        }

        private void btnKelolaPaket_Click(object sender, EventArgs e)
        {

            kelpak.Hide();
            kelsup.Hide();
            kelbar.Hide();
            kelpak.TopLevel = false;
            kelpak.TopMost = true;
            Form_panel3.Controls.Add(kelpak);
            kelpak.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kelpak.Dock = DockStyle.Fill;
            kelpak.Show();
        }

        private void btnKelolabrg_Click(object sender, EventArgs e)
        {
            kelpak.Hide();
            kelsup.Hide();
            kelbar.Hide();
            kelbar.TopLevel = false;
            kelbar.TopMost = true;
            Form_panel3.Controls.Add(kelbar);
            kelbar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kelbar.Dock = DockStyle.Fill;
            kelbar.Show();
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            kelpak.Hide();
            kelsup.Hide();
            kelbar.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin a = new FormLogin();
            a.Show();
        }
    }
}
