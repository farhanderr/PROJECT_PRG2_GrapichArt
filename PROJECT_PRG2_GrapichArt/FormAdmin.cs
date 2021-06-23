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
    public partial class FormAdmin : Form
    {
        Kelola_Pegawai kelpe = new Kelola_Pegawai();
        Kelola_Gaji kelgaj = new Kelola_Gaji();
        Kelola_KatMember KelMem = new Kelola_KatMember();
        KelolaJabatan keljab = new KelolaJabatan();
        Kelola_Supplier kelsup = new Kelola_Supplier();

        public FormAdmin()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMasterPegawai_Click(object sender, EventArgs e)
        {


            kelgaj.Hide();
            keljab.Hide();
            kelsup.Hide();
            kelpe.Hide();
            KelMem.Hide();
            kelpe.TopLevel = false;
            kelpe.TopMost = true;
            panel_form.Controls.Add(kelpe);
            kelpe.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kelpe.Dock = DockStyle.Fill;
            kelpe.Show();



        }

        private void btnGaji_Click(object sender, EventArgs e)
        {

            kelgaj.Hide();
            keljab.Hide();
            kelsup.Hide();
            kelpe.Hide();
            KelMem.Hide();
            kelgaj.TopLevel = false;
            kelgaj.TopMost = true;
            panel_form.Controls.Add(kelgaj);
            kelgaj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kelgaj.Dock = DockStyle.Fill;
            kelgaj.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {

            kelgaj.Hide();
            keljab.Hide();
            kelsup.Hide();
            kelpe.Hide();
            KelMem.Hide();
            KelMem.TopLevel = false;
            KelMem.TopMost = true;
            panel_form.Controls.Add(KelMem);
            KelMem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            KelMem.Dock = DockStyle.Fill;
            KelMem.Show();
        }

        private void btnJabatan_Click(object sender, EventArgs e)
        {

            kelgaj.Hide();
            keljab.Hide();
            kelsup.Hide();
            kelpe.Hide();
            KelMem.Hide();
            keljab.TopLevel = false;
            keljab.TopMost = true;
            panel_form.Controls.Add(keljab);
            keljab.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            keljab.Dock = DockStyle.Fill;
            keljab.Show();
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin a = new FormLogin();
            a.Show();
            this.Hide();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            kelgaj.Hide();
            keljab.Hide();
            kelsup.Hide();
            kelpe.Hide();
            KelMem.Hide();
        }
    }
}
