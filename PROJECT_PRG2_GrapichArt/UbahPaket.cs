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
    public partial class UbahPaket : Form
    {
        public UbahPaket()
        {
            InitializeComponent();
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

        private void txtHargaPaket_Leave(object sender, EventArgs e)
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
                SqlConnection connection = new SqlConnection(connectionstring);



                connection.Open();
                DataTable dt = new DataTable();



                SqlCommand cmd = new SqlCommand("SELECT * FROM Paket WHERE Id_Paket ='" + txtIDPaket.Text + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



                txtIDPaket.Text = txtIDPaket.Text;



                txtNamaPaket.Text = dt.Rows[0]["Nama_Paket"].ToString();
                txtHargaPaket.Text = dt.Rows[0]["Harga_Paket"].ToString();
                txtKeterangan.Text = dt.Rows[0]["Keterangan"].ToString();



                connection.Close();



                SqlCommand deleteDetail = new SqlCommand("sp_DeleteDetailPaket", connection);
                deleteDetail.CommandType = CommandType.StoredProcedure;
                deleteDetail.Parameters.AddWithValue("Id_Paket", txtIDPaket.Text);
                connection.Open();
                deleteDetail.ExecuteNonQuery();
                connection.Close();


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak ditemukan!\n" + ex.Message);
               
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
                    SqlCommand update = new SqlCommand("sp_DeletePaket", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("Id_Paket", txtIDPaket.Text);
                    update.ExecuteNonQuery();

                    SqlCommand deleteDetail = new SqlCommand("sp_DeleteDetailPaket", connection);
                    deleteDetail.CommandType = CommandType.StoredProcedure;
                    deleteDetail.Parameters.AddWithValue("Id_Paket", txtIDPaket.Text);
                    
                    deleteDetail.ExecuteNonQuery();
                    connection.Close();


                    MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data tidak dapat dihapus: " + ex.Message);
                }
            }
        }
    }
}
