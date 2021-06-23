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
    public partial class TambahJenisMember : Form
    {
        public TambahJenisMember()
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

            SqlCommand insert = new SqlCommand("[sp_InsertKatMember]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            string query = "select top 1 Id_KatMember from KatMember order by Id_KatMember desc";
            string ID = autogenerateID("PKT", query);

            insert.Parameters.AddWithValue("Id_KatMember", ID);
            insert.Parameters.AddWithValue("Nama_KatMember", txtNamaKategotiMember.Text);
            insert.Parameters.AddWithValue("Potongan", txtPotongan.Text);
            insert.Parameters.AddWithValue("Peraturan", txtPeraturan.Text);



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

        private void txtNamaKategotiMember_Leave(object sender, EventArgs e)
        {
            if (txtNamaKategotiMember.Text == "")
            {
                epCorrect.SetError(txtNamaKategotiMember, "");
                epError.SetError(txtNamaKategotiMember, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaKategotiMember, "Benar");
                epError.SetError(txtNamaKategotiMember, "");
            }
        }

        private void txtNamaKategotiMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
