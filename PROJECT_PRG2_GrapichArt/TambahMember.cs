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
    public partial class TambahMember : Form
    {
        public TambahMember()
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

        private void TambahMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_GrapichArtDataSet.KatMember' table. You can move, or remove it, as needed.
            this.katMemberTableAdapter.Fill(this.db_GrapichArtDataSet.KatMember);


        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security = true; data source =DESKTOP-4OL84HG\\SQLEXPRESS; initial catalog = Db_GrapichArt";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("[sp_InsertMember]", connection);
            insert.CommandType = CommandType.StoredProcedure;

            string query = "select top 1 Id_Member from Member order by Id_Member desc";
            string ID = autogenerateID("MBR", query);

            insert.Parameters.AddWithValue("Id_Member", ID);
            insert.Parameters.AddWithValue("Jenis_member", cmbJenisMember.SelectedValue);
            insert.Parameters.AddWithValue("Nama", txtNamaMember.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan: " + ex.Message);
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
   