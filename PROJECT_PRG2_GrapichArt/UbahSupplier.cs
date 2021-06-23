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
using System.Text.RegularExpressions;

namespace PROJECT_PRG2_GrapichArt
{
    public partial class UbahSupplier : Form
    {
        public UbahSupplier()
        {
            InitializeComponent();
        }

        private void UbahSupplier_Load(object sender, EventArgs e)
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
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariSupplier", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_Supplier", txtID.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaSupplier.SelectedText = Convert.ToString(reader["Nama_Supplier"]);
                                txtAlamat.SelectedText = Convert.ToString(reader["Alamat_Supp"]);
                                txtNomerTelepon.SelectedText = Convert.ToString(reader["Telp_Supplier"]);
                                txtEmail.SelectedText = Convert.ToString(reader["Email_Supp"]);
                                txtBarangJual.SelectedText = Convert.ToString(reader["Barang_Jual"]);
                                txtHargaBarang.SelectedText = Convert.ToString(reader["Harga_Barang"]);


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true;data source = DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand update = new SqlCommand("sp_UpdateSupllier", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_Supplier", txtID.Text);
            update.Parameters.AddWithValue("Nama_Supplier", txtNamaSupplier.Text);
            update.Parameters.AddWithValue("Alamat_Supp", txtAlamat.Text);
            update.Parameters.AddWithValue("Telp_Supplier", txtNomerTelepon.Text);
            update.Parameters.AddWithValue("Email_Supplier", txtEmail.Text);
            update.Parameters.AddWithValue("harga_jual", txtHargaBarang.Text);
            update.Parameters.AddWithValue("barang_jual", txtBarangJual.Text);

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
                    SqlCommand update = new SqlCommand("sp_DeleteSuplier", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("Id_Supplier", txtID.Text);
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

        private void txtNamaSupplier_Leave(object sender, EventArgs e)
        {
            if (txtNamaSupplier.Text == "")
            {
                epCorrect.SetError(txtNamaSupplier, "");
                epError.SetError(txtNamaSupplier, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaSupplier, "Benar");
                epError.SetError(txtNamaSupplier, "");
            }
        }

        private void txtNomerTelepon_Leave(object sender, EventArgs e)
        {
            if (txtNomerTelepon.Text == "")
            {
                epCorrect.SetError(txtNomerTelepon, "");
                epError.SetError(txtNomerTelepon, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNomerTelepon, "Benar");
                epError.SetError(txtNomerTelepon, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(regexPattern);

            if (!regex.IsMatch(txtEmail.Text))
            {
                epCorrect.SetError(txtEmail, "");
                epError.SetError(txtEmail, "Kolom harus diisi dengan format (a@b.c)!");
            }
            else
            {
                epCorrect.SetError(txtEmail, "Benar");
                epError.SetError(txtEmail, "");
            }
        }

        private void txtBarangJual_TextChanged(object sender, EventArgs e)
        {
            if (txtBarangJual.Text == "")
            {
                epCorrect.SetError(txtBarangJual, "");
                epError.SetError(txtBarangJual, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtBarangJual, "Benar");
                epError.SetError(txtBarangJual, "");
            }
        }

        private void txtHargaBarang_TextChanged(object sender, EventArgs e)
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

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epCorrect.SetError(txtAlamat, "");
                epError.SetError(txtAlamat, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtAlamat, "Benar");
                epError.SetError(txtAlamat, "");
            }
        }

        private void txtNamaSupplier_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHargaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* private void txtNamaSupplier_KeyUp(object sender, KeyEventArgs e)
         {
             if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
             {
                 e.Handled = true;
             }
         } */
    }
}
