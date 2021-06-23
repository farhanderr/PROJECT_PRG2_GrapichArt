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
    public partial class TambahKaryawan : Form
    {

        public TambahKaryawan()
        {
            InitializeComponent();
        }

        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        static string connectionString = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";

        public string autogenerateID(string firstText, string query)
        {
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(2, '0');
            return result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (txtNamaKaryawan.Text == ""  || txtNomerTelepon.Text == "" || txtAlamat.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string connectionstring = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InsertPegawai", connection);
                insert.CommandType = CommandType.StoredProcedure;

                string query = "select top 1 Id_Pegawai from Pegawai order by Id_Pegawai desc";
                string ID = autogenerateID("KRY", query);

                insert.Parameters.AddWithValue("Id_Pegawai", ID);
                insert.Parameters.AddWithValue("Nama", txtNamaKaryawan.Text);
                insert.Parameters.AddWithValue("alamat", txtAlamat.Text);
                insert.Parameters.AddWithValue("no_hp", txtNomerTelepon.Text);
                insert.Parameters.AddWithValue("nama_akun", txtUsername.Text);
                insert.Parameters.AddWithValue("kata_sandi", txtPassword.Text);
                insert.Parameters.AddWithValue("Email", txtEmail.Text);
                insert.Parameters.AddWithValue("role_pegawai", cmbJabatan.SelectedValue);
               

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan: " + ex.Message);
                }
            }
        }

        private void TambahKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.db_GrapichArtDataSet.Jabatan);
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.db_GrapichArtDataSet.Jabatan);

        }

        private void txtNamaKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomerTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamaKaryawan_Leave(object sender, EventArgs e)
        {
            if (txtNamaKaryawan.Text == "")
            {
                epCorrect.SetError(txtNamaKaryawan, "");
                epError.SetError(txtNamaKaryawan, "Kolom harus diisi!");
            }
          
        }

        private void txtNomerTelepon_Leave(object sender, EventArgs e)
        {
            if (txtNomerTelepon.Text == "")
            {
                epCorrect.SetError(txtNomerTelepon, "");
                epError.SetError(txtNomerTelepon, "Kolom harus diisi!");
            }
         
        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epCorrect.SetError(txtAlamat, "");
                epError.SetError(txtAlamat, "Kolom harus diisi!");
            }
          
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                epCorrect.SetError(txtUsername, "");
                epError.SetError(txtUsername, "Kolom harus diisi!");
            }
          
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                epCorrect.SetError(txtPassword, "");
                epError.SetError(txtPassword, "Kolom harus diisi!");
            }
          
        }

        public void clear()
        {
            txtAlamat.Text = "";
            txtNamaKaryawan.Text = "";
            txtNomerTelepon.Text = "";
            txtEmail.Text = "";
            cmbJabatan.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = ""; ;
        }


      

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBATL_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
