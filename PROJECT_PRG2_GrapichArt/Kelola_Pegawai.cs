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
   
    public partial class Kelola_Pegawai : Form
    {
        TambahKaryawan a = new TambahKaryawan();
        UbahKaryawan b = new UbahKaryawan();

        public Kelola_Pegawai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void hide()
        {
            a.Hide();
            b.Hide();
        }

        private void Kelola_Pegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.db_GrapichArtDataSet.Pegawai);


        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            hide();
            a.TopLevel = false;
            a.TopMost = true;
            Panel_form.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.Show();

          
        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            hide();
            b.TopLevel = false;
            b.TopMost = true;
            Panel_form.Controls.Add(b);
            b.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            b.Dock = DockStyle.Fill;
            b.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.db_GrapichArtDataSet.Pegawai);
        }
    }
}
