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
    public partial class UbahBarang : Form
    {
        public UbahBarang()
        {
            InitializeComponent();
        }

        private void txtNamaBarang_Leave(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "")
            {
                epCorrect.SetError(txtNamaBarang, "");
                epError.SetError(txtNamaBarang, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaBarang, "Benar");
                epError.SetError(txtNamaBarang, "");
            }
        }

        private void txtHargaBarang_Leave(object sender, EventArgs e)
        {
            if (txtHargaBarang.Text == "")
            {
                epCorrect.SetError(txtHargaBarang, "");
                epError.SetError(txtHargaBarang, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtHargaBarang, "Benar");
                epError.SetError(txtHargaBarang, "");
            }
        }

        private void txtJumlahBarang_Leave(object sender, EventArgs e)
        {
            if (txtJumlahBarang.Text == "")
            {
                epCorrect.SetError(txtJumlahBarang, "");
                epError.SetError(txtJumlahBarang, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtJumlahBarang, "Benar");
                epError.SetError(txtJumlahBarang, "");
            }
        }

        private void txtNamaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHargaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtJumlahBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCariBarang_Click(object sender, EventArgs e)
        {
            if (txtIdBarang.Text == "")
            {
                MessageBox.Show("Masukkan ID terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtIdBarang.Text.Trim()))
                {
                    using (SqlConnection sqlConn = new SqlConnection("integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt"))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariBarang", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_barang", txtIdBarang.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaBarang.SelectedText = Convert.ToString(reader["Nama_Barang"]);
                                txtHargaBarang.SelectedText = Convert.ToString(reader["Harga_Beli"]);
                                txtJumlahBarang.SelectedText = Convert.ToString(reader["Stock_barang"]);



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

        private void btnUpdateBarang_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand update = new SqlCommand("sp_UpdateBarang", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_barang", txtIdBarang.Text);
            update.Parameters.AddWithValue("Nama_Barang", txtNamaBarang.Text);
            update.Parameters.AddWithValue("Harga_Beli", txtHargaBarang.Text);
            update.Parameters.AddWithValue("Stock_barang", txtJumlahBarang.Text);


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
        }

        private void btnHapusBarang_Click(object sender, EventArgs e)
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
                    SqlCommand update = new SqlCommand("sp_deleteBarang", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("Id_barang", txtIdBarang.Text);
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
    }
}
