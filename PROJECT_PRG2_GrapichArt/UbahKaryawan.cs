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
    public partial class UbahKaryawan : Form
    {
        public UbahKaryawan()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Masukkan ID terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    using (SqlConnection sqlConn = new SqlConnection("integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt"))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariPegawai", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_Pegawai", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNama.SelectedText = Convert.ToString(reader["Nama"]);
                                txtAlamat.SelectedText = Convert.ToString(reader["alamat"]);
                                txtNomerTelepon.SelectedText = Convert.ToString(reader["no_hp"]);
                                txtUsername.SelectedText = Convert.ToString(reader["nama_akun"]);
                                txtPassword.SelectedText = Convert.ToString(reader["kata_sandi"]);
                                txtEmail.SelectedText = Convert.ToString(reader["Email"]);
                                cmbJabatan.SelectedText = Convert.ToString(reader["role_pegawai"]);

                                txtID.Enabled = false;
                                txtNama.Enabled = true;
                                txtAlamat.Enabled = true;
                                txtNomerTelepon.Enabled = true;
                                txtUsername.Enabled = true;
                                txtPassword.Enabled = true;
                                
                            }
                            else
                            {
                                MessageBox.Show("Data dengan ID tersebut tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            sqlConn.Close();
                           
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string msg = "Apakah anda yakin ingin menghapus data ini?";
            string title = "Peringatan";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, title, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionstring = "integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
                SqlConnection connection = new SqlConnection(connectionstring);

                try
                {
                    connection.Open();
                    SqlCommand update = new SqlCommand("sp_DeletePegawai", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("Id_Pegawai", txtID.Text);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data tidak dapat dihapus: " + ex.Message);
                }
            
           
               
            }
            else
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                string connectionstring = "integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdatePegawai", connection);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("Id_Pegawai", txtID.Text);
                update.Parameters.AddWithValue("Nama", txtNama.Text);
                update.Parameters.AddWithValue("alamat", txtAlamat.Text);
                update.Parameters.AddWithValue("no_hp", txtNomerTelepon.Text);
                update.Parameters.AddWithValue("nama_akun", txtUsername.Text);
                update.Parameters.AddWithValue("kata_sandi", txtPassword.Text);
                update.Parameters.AddWithValue("Email", txtEmail.Text);
                update.Parameters.AddWithValue("Jabatan", cmbJabatan.SelectedValue);

            try
            {
                    connection.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data tidak dapat disimpan: " + ex.Message);
                }
            }

        private void UbahKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.db_GrapichArtDataSet.Jabatan);

            txtAlamat.Enabled = false;
            txtNomerTelepon.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            txtNama.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAlamat.Text = "";
            txtNomerTelepon.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtNama.Text = "";



        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epCorrect.SetError(txtNama, "");
                epError.SetError(txtNama, "Kolom harus diisi!");
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

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    
}
