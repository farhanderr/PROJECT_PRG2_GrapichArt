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
    public partial class KelolaMember : Form
    {
        public KelolaMember()
        {
            InitializeComponent();
        }

        private void btnTambahMember_Click(object sender, EventArgs e)
        {
            TambahMember a = new TambahMember();
            a.Show();
        }

        private void btnUbahDataMember_Click(object sender, EventArgs e)
        {
            UbahMember b = new UbahMember();
            b.Show();
        }
    }
}
