using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_PRG2_GrapichArt
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";

            string query = "SELECT role_pegawai from Pegawai WHERE nama_akun = @nama_akun and kata_sandi = @kata_sandi";
            string returnValue = "";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                using (SqlCommand sqlcmd = new SqlCommand(query, connection))
                {
                    sqlcmd.Parameters.Add("@nama_akun", SqlDbType.VarChar).Value = txtUsername.Text;
                    sqlcmd.Parameters.Add("@kata_sandi", SqlDbType.VarChar).Value = txtPassword.Text;
                    connection.Open();
                    returnValue = (string)sqlcmd.ExecuteScalar();
                }

                if (String.IsNullOrEmpty(returnValue))
                {
                    MessageBox.Show("Kata sandi atau Nama Akun anda salah!");
                    return;
                }
                returnValue = returnValue.Trim();
                if (returnValue == "Admin")
                {
                    MessageBox.Show("Selamat datang, Admin!");
                    FormAdmin a = new FormAdmin();
                    a.Show();
                   
                }
                else if (returnValue == "Kasir")
                {
                    MessageBox.Show("Selamat datang, Kasir!");
                    FormKasir kasir = new FormKasir();
                    kasir.Show();
                       
                   
                }
                else if (returnValue == "Admin Barang")
                {
                    MessageBox.Show("Selamat datang, Admin Gudang!");
                    FormAdminBrg adminbarang = new FormAdminBrg();
                    adminbarang.Show();

                }
                else if (returnValue == "Manager")
                {
                    MessageBox.Show("Selamat datang, Manager!");
                    FormManager manager = new FormManager();
                    manager.Show();

                }
                else
                {
                    MessageBox.Show("anda tidak berwenang");
                }
                this.Hide();
            }
        }
    }
}
