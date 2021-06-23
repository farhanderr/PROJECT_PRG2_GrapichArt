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
    public partial class UbahJenisMember : Form
    {
        public UbahJenisMember()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (txtIdJenisMember.Text == "")
            {
                MessageBox.Show("Masukkan ID terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtIdJenisMember.Text.Trim()))
                {
                    using (SqlConnection sqlConn = new SqlConnection("integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt"))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariKatMember", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_KatMember", txtIdJenisMember.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaKategoriMember.SelectedText = Convert.ToString(reader["Nama_KatMember"]);
                                txtPotongan.SelectedText = Convert.ToString(reader["Potongan"]);
                                txtPeraturan.SelectedText = Convert.ToString(reader["Peraturan"]);
                                btnCari.Enabled = false;
                                txtIdJenisMember.Enabled = false;
                                

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
                    SqlCommand update = new SqlCommand("sp_deletKatMember", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("Id_KatMember", txtIdJenisMember.Text);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data tidak dapat dihapus: " + ex.Message);
                }


               
                btnCari.Enabled = true;
                txtIdJenisMember.Enabled = true;
                txtIdJenisMember.Text = "";
                txtNamaKategoriMember.Text = "";
                txtPotongan.Text = "";
            }
            else
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand update = new SqlCommand("sp_UpdateKatMember", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_KatMember", txtIdJenisMember.Text);
            update.Parameters.AddWithValue("Nama_KatMember", txtNamaKategoriMember.Text);
            update.Parameters.AddWithValue("Potongan", txtPotongan.Text);
            update.Parameters.AddWithValue("Peraturan", txtPeraturan.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak dapat disimpan: " + ex.Message);
            }
            btnCari.Enabled = true;
            txtIdJenisMember.Enabled = true;
            txtIdJenisMember.Text = "";
            txtNamaKategoriMember.Text = "";
            txtPotongan.Text = "";
        }

        private void txtNamaKategoriMember_Leave(object sender, EventArgs e)
        {
            if (txtNamaKategoriMember.Text == "")
            {
                epCorrect.SetError(txtNamaKategoriMember, "");
                epError.SetError(txtNamaKategoriMember, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaKategoriMember, "Benar");
                epError.SetError(txtNamaKategoriMember, "");
            }
        }

        private void txtNamaKategoriMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtIdJenisMember.Text = "";
            txtNamaKategoriMember.Text = "";
            txtPotongan.Text = "";
            btnCari.Enabled = true;
            txtIdJenisMember.Enabled = true;
        }

     
    }
}
