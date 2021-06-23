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
    public partial class UbahMember : Form
    {
        public UbahMember()
        {
            InitializeComponent();
        }

        private void UbahMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.KatMember' table. You can move, or remove it, as needed.
            this.katMemberTableAdapter.Fill(this.db_GrapichArtDataSet.KatMember);

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
                        using (SqlCommand sqlCmd = new SqlCommand("sp_CariMember", sqlConn))
                        {
                            sqlConn.Open();
                            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("Id_Member", txtIdJenisMember.Text.Trim());

                            SqlDataReader reader = sqlCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                cmbJenisMember.SelectedText = Convert.ToString(reader["Jenis_Member"]);
                                txtNamaMember.SelectedText = Convert.ToString(reader["Nama"]);


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

            SqlCommand update = new SqlCommand("sp_UpdateMember", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_Member", txtIdJenisMember.Text);
            update.Parameters.AddWithValue("Nama", txtNamaMember.Text);
            update.Parameters.AddWithValue("Jenis_Member", cmbJenisMember.SelectedValue);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
                    SqlCommand update = new SqlCommand("sp_deleteMember", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("Id_Member", txtIdJenisMember.Text);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data tidak dapat dihapus: " + ex.Message);
                }


                this.Close();
            }
            else
            {

            }
        }

        private void txtNamaMember_Leave(object sender, EventArgs e)
        {
            if (txtNamaMember.Text == "")
            {
                epCorrect.SetError(txtNamaMember, "");
                epError.SetError(txtNamaMember, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaMember, "Benar");
                epError.SetError(txtNamaMember, "");
            }
        }

        private void txtNamaMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
