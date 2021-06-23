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
    public partial class TambahSupplier : Form
    {
        public TambahSupplier()
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            string query = "select top 1 Id_Supplier from Supplier order by Id_Supplier desc";
            string ID = autogenerateID("SPL", query);

            insert.Parameters.AddWithValue("Id_Supplier", ID);
            insert.Parameters.AddWithValue("Nama_Supplier", txtNamaSupplier.Text);
            insert.Parameters.AddWithValue("Alamat_Supp", txtAlamat.Text);
            insert.Parameters.AddWithValue("Telp_Supplier", txtNomerTelepon.Text);
            insert.Parameters.AddWithValue("Email_Supplier", txtEmail.Text);
            insert.Parameters.AddWithValue("harga_jual", txtHargaBarang.Text);
            insert.Parameters.AddWithValue("barang_jual", txtBarangJual.Text);
            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan: " + ex.Message);
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

        private void txtBarangJual_Leave(object sender, EventArgs e)
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

        private void txtAlamat_Leave(object sender, EventArgs e)
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
    }
}
