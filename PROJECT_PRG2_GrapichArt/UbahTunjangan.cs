using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_GrapichArt
{
    public partial class UbahTunjangan : Form
    {
        public UbahTunjangan()
        {
            InitializeComponent();
        }

        private void UbahTunjangan_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void txtNamaTunjangan_Leave(object sender, EventArgs e)
        {
            if (txtNamaTunjangan.Text == "")
            {
                epCorrect.SetError(txtNamaTunjangan, "");
                epError.SetError(txtNamaTunjangan, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtNamaTunjangan, "Benar");
                epError.SetError(txtNamaTunjangan, "");
            }
        }

        private void txtTotalTunjangan_Leave(object sender, EventArgs e)
        {
            if (txtTotalTunjangan.Text == "")
            {
                epCorrect.SetError(txtTotalTunjangan, "");
                epError.SetError(txtTotalTunjangan, "Kolom harus diisi!");
            }
            else
            {
                epCorrect.SetError(txtTotalTunjangan, "Benar");
                epError.SetError(txtTotalTunjangan, "");
            }
        }

        private void txtNamaTunjangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTotalTunjangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
