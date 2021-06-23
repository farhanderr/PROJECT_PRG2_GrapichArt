namespace PROJECT_PRG2_GrapichArt
{
    partial class TambahKaryawan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomerTelepon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.db_GrapichArtDataSet = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSet();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jabatanTableAdapter = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSetTableAdapters.JabatanTableAdapter();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBATL = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(-5, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(662, 8);
            this.label9.TabIndex = 27;
            this.label9.Text = "_______________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "KELOLA DATA KARYAWAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(89, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama Karyawan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.BackColor = System.Drawing.Color.Olive;
            this.txtNamaKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNamaKaryawan.Location = new System.Drawing.Point(88, 133);
            this.txtNamaKaryawan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamaKaryawan.Multiline = true;
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(188, 38);
            this.txtNamaKaryawan.TabIndex = 1;
            this.txtNamaKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaKaryawan_KeyPress);
            this.txtNamaKaryawan.Leave += new System.EventHandler(this.txtNamaKaryawan_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(86, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nomer Telepon";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomerTelepon
            // 
            this.txtNomerTelepon.BackColor = System.Drawing.Color.Olive;
            this.txtNomerTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomerTelepon.Location = new System.Drawing.Point(89, 231);
            this.txtNomerTelepon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomerTelepon.Multiline = true;
            this.txtNomerTelepon.Name = "txtNomerTelepon";
            this.txtNomerTelepon.Size = new System.Drawing.Size(188, 37);
            this.txtNomerTelepon.TabIndex = 2;
            this.txtNomerTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomerTelepon_KeyPress);
            this.txtNomerTelepon.Leave += new System.EventHandler(this.txtNomerTelepon_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(90, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Olive;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(88, 327);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 39);
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(90, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Alamat";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.BackColor = System.Drawing.Color.Olive;
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAlamat.Location = new System.Drawing.Point(93, 450);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(392, 140);
            this.txtAlamat.TabIndex = 4;
            this.txtAlamat.Leave += new System.EventHandler(this.txtAlamat_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightYellow;
            this.label6.Location = new System.Drawing.Point(313, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Jabatan";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(314, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Username";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightYellow;
            this.label8.Location = new System.Drawing.Point(307, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Olive;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(311, 231);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 37);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Olive;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(310, 328);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 38);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Activecolor = System.Drawing.Color.LightYellow;
            this.btnSimpan.BackColor = System.Drawing.Color.LightYellow;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderRadius = 0;
            this.btnSimpan.ButtonText = "Simpan";
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledColor = System.Drawing.Color.Gray;
            this.btnSimpan.ForeColor = System.Drawing.Color.LightYellow;
            this.btnSimpan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSimpan.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_save_30px;
            this.btnSimpan.Iconimage_right = null;
            this.btnSimpan.Iconimage_right_Selected = null;
            this.btnSimpan.Iconimage_Selected = null;
            this.btnSimpan.IconMarginLeft = 0;
            this.btnSimpan.IconMarginRight = 0;
            this.btnSimpan.IconRightVisible = true;
            this.btnSimpan.IconRightZoom = 0D;
            this.btnSimpan.IconVisible = true;
            this.btnSimpan.IconZoom = 70D;
            this.btnSimpan.IsTab = false;
            this.btnSimpan.Location = new System.Drawing.Point(94, 625);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(178, 52);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpan.Textcolor = System.Drawing.Color.Black;
            this.btnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.BackColor = System.Drawing.Color.Olive;
            this.cmbJabatan.DataSource = this.jabatanBindingSource;
            this.cmbJabatan.DisplayMember = "Nama_Jabatan";
            this.cmbJabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbJabatan.ForeColor = System.Drawing.Color.LightYellow;
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(310, 133);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(180, 28);
            this.cmbJabatan.TabIndex = 29;
            this.cmbJabatan.ValueMember = "Nama_Jabatan";
            // 
            // db_GrapichArtDataSet
            // 
            this.db_GrapichArtDataSet.DataSetName = "Db_GrapichArtDataSet";
            this.db_GrapichArtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "Jabatan";
            this.jabatanBindingSource.DataSource = this.db_GrapichArtDataSet;
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Activecolor = System.Drawing.Color.LightYellow;
            this.btnBatal.BackColor = System.Drawing.Color.LightYellow;
            this.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatal.BorderRadius = 0;
            this.btnBatal.ButtonText = "Batal";
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.DisabledColor = System.Drawing.Color.Gray;
            this.btnBatal.ForeColor = System.Drawing.Color.LightYellow;
            this.btnBatal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBatal.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_cancel_26px;
            this.btnBatal.Iconimage_right = null;
            this.btnBatal.Iconimage_right_Selected = null;
            this.btnBatal.Iconimage_Selected = null;
            this.btnBatal.IconMarginLeft = 0;
            this.btnBatal.IconMarginRight = 0;
            this.btnBatal.IconRightVisible = true;
            this.btnBatal.IconRightZoom = 0D;
            this.btnBatal.IconVisible = true;
            this.btnBatal.IconZoom = 70D;
            this.btnBatal.IsTab = false;
            this.btnBatal.Location = new System.Drawing.Point(460, 1055);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnBatal.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(267, 80);
            this.btnBatal.TabIndex = 30;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBatal.Textcolor = System.Drawing.Color.Black;
            this.btnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnBATL
            // 
            this.btnBATL.Activecolor = System.Drawing.Color.LightYellow;
            this.btnBATL.BackColor = System.Drawing.Color.LightYellow;
            this.btnBATL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBATL.BorderRadius = 0;
            this.btnBATL.ButtonText = "Simpan";
            this.btnBATL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBATL.DisabledColor = System.Drawing.Color.Gray;
            this.btnBATL.ForeColor = System.Drawing.Color.LightYellow;
            this.btnBATL.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBATL.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_save_30px;
            this.btnBATL.Iconimage_right = null;
            this.btnBATL.Iconimage_right_Selected = null;
            this.btnBATL.Iconimage_Selected = null;
            this.btnBATL.IconMarginLeft = 0;
            this.btnBATL.IconMarginRight = 0;
            this.btnBATL.IconRightVisible = true;
            this.btnBATL.IconRightZoom = 0D;
            this.btnBATL.IconVisible = true;
            this.btnBATL.IconZoom = 70D;
            this.btnBATL.IsTab = false;
            this.btnBATL.Location = new System.Drawing.Point(318, 625);
            this.btnBATL.Margin = new System.Windows.Forms.Padding(4);
            this.btnBATL.Name = "btnBATL";
            this.btnBATL.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnBATL.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnBATL.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBATL.selected = false;
            this.btnBATL.Size = new System.Drawing.Size(178, 52);
            this.btnBATL.TabIndex = 31;
            this.btnBATL.Text = "Simpan";
            this.btnBATL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBATL.Textcolor = System.Drawing.Color.Black;
            this.btnBATL.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBATL.Click += new System.EventHandler(this.btnBATL_Click);
            // 
            // TambahKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(622, 690);
            this.Controls.Add(this.btnBATL);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.cmbJabatan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNomerTelepon);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TambahKaryawan";
            this.Text = "TambahKaryawan";
            this.Load += new System.EventHandler(this.TambahKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomerTelepon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnSimpan;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private Db_GrapichArtDataSet db_GrapichArtDataSet;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private Db_GrapichArtDataSetTableAdapters.JabatanTableAdapter jabatanTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnBATL;
    }
}