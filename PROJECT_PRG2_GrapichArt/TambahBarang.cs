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
    public partial class TambahBarang : Form
    {
        public TambahBarang()
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
    }
}
