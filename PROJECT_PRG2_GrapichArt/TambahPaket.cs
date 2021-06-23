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
    public partial class TambahPaket : Form
    {
        string dummy;

        public TambahPaket()
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

        private void txtNamaPaket_Leave(object sender, EventArgs e)
        {
            if (txtNamaPaket.Text == "")
            {
                epCorrect.SetError(txtNamaPaket, "");
                epError.SetError(txtNamaPaket, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaPaket, "Benar");
                epError.SetError(txtNamaPaket, "");
            }
        }

        private void txtJumlahPaket_Leave(object sender, EventArgs e)
        {
         
        }

        private void txtHargaPaket_TextChanged(object sender, EventArgs e)
        {
            if (txtHargaPaket.Text == "")
            {
                epCorrect.SetError(txtHargaPaket, "");
                epError.SetError(txtHargaPaket, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtHargaPaket, "Benar");
                epError.SetError(txtHargaPaket, "");
            }
        }

        private void txtNamaPaket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtJumlahPaket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHargaPaket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionstring = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertDetailPaket", connection);
            insert.CommandType = CommandType.StoredProcedure;

            

            insert.Parameters.AddWithValue("Id_Paket", dummy);
            insert.Parameters.AddWithValue("Id_barang", cbBarang.SelectedValue);
            insert.Parameters.AddWithValue("Jumlah_barang", txtJumlah.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Detail parcel berhasil disimpan", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbBarang.Text = "";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan detail  : " + ex.Message);
            }
        }

        private void TambahPaket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.db_GrapichArtDataSet.Barang);

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertPaket", connection);
            insert.CommandType = CommandType.StoredProcedure;

            string query = "select top 1 Id_Paket from Paket order by Id_Paket desc";
            string ID = autogenerateID("PKT", query);

            dummy = ID;
           

            insert.Parameters.AddWithValue("Id_Paket", ID);
            insert.Parameters.AddWithValue("Nama_Paket", txtNamaPaket.Text);
            insert.Parameters.AddWithValue("Harga_Paket", txtHargaPaket.Text);
            insert.Parameters.AddWithValue("Keterangan", txtKeterangan.Text);


            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Detail parcel berhasil disimpan", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbBarang.Text = "";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan detail  : " + ex.Message);
            }
        }
    }
}
