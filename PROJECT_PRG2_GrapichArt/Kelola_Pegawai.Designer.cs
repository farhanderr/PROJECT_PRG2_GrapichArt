namespace PROJECT_PRG2_GrapichArt
{
    partial class Kelola_Pegawai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUbahData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTambahKaryawan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.db_GrapichArtDataSet = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSet();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiTableAdapter = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSetTableAdapters.PegawaiTableAdapter();
            this.idPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaakunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katasandiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolepegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_form = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(673, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "KELOLA DATA KARYAWAN";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(15, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1523, 10);
            this.label9.TabIndex = 25;
            this.label9.Text = "_______________";
            // 
            // btnUbahData
            // 
            this.btnUbahData.Activecolor = System.Drawing.Color.LightYellow;
            this.btnUbahData.BackColor = System.Drawing.Color.LightYellow;
            this.btnUbahData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbahData.BorderRadius = 0;
            this.btnUbahData.ButtonText = "Ubah Data Karyawan";
            this.btnUbahData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbahData.DisabledColor = System.Drawing.Color.Gray;
            this.btnUbahData.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUbahData.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_update_24px;
            this.btnUbahData.Iconimage_right = null;
            this.btnUbahData.Iconimage_right_Selected = null;
            this.btnUbahData.Iconimage_Selected = null;
            this.btnUbahData.IconMarginLeft = 0;
            this.btnUbahData.IconMarginRight = 0;
            this.btnUbahData.IconRightVisible = true;
            this.btnUbahData.IconRightZoom = 0D;
            this.btnUbahData.IconVisible = true;
            this.btnUbahData.IconZoom = 90D;
            this.btnUbahData.IsTab = false;
            this.btnUbahData.Location = new System.Drawing.Point(409, 116);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnUbahData.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnUbahData.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUbahData.selected = false;
            this.btnUbahData.Size = new System.Drawing.Size(241, 45);
            this.btnUbahData.TabIndex = 28;
            this.btnUbahData.Text = "Ubah Data Karyawan";
            this.btnUbahData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUbahData.Textcolor = System.Drawing.Color.Black;
            this.btnUbahData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahData.Click += new System.EventHandler(this.btnUbahData_Click);
            // 
            // btnTambahKaryawan
            // 
            this.btnTambahKaryawan.Activecolor = System.Drawing.Color.LightYellow;
            this.btnTambahKaryawan.BackColor = System.Drawing.Color.LightYellow;
            this.btnTambahKaryawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahKaryawan.BorderRadius = 0;
            this.btnTambahKaryawan.ButtonText = "Tambah Karyawan";
            this.btnTambahKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahKaryawan.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambahKaryawan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambahKaryawan.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_add_30px;
            this.btnTambahKaryawan.Iconimage_right = null;
            this.btnTambahKaryawan.Iconimage_right_Selected = null;
            this.btnTambahKaryawan.Iconimage_Selected = null;
            this.btnTambahKaryawan.IconMarginLeft = 0;
            this.btnTambahKaryawan.IconMarginRight = 0;
            this.btnTambahKaryawan.IconRightVisible = true;
            this.btnTambahKaryawan.IconRightZoom = 0D;
            this.btnTambahKaryawan.IconVisible = true;
            this.btnTambahKaryawan.IconZoom = 90D;
            this.btnTambahKaryawan.IsTab = false;
            this.btnTambahKaryawan.Location = new System.Drawing.Point(12, 116);
            this.btnTambahKaryawan.Name = "btnTambahKaryawan";
            this.btnTambahKaryawan.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnTambahKaryawan.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnTambahKaryawan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTambahKaryawan.selected = false;
            this.btnTambahKaryawan.Size = new System.Drawing.Size(241, 45);
            this.btnTambahKaryawan.TabIndex = 28;
            this.btnTambahKaryawan.Text = "Tambah Karyawan";
            this.btnTambahKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambahKaryawan.Textcolor = System.Drawing.Color.Black;
            this.btnTambahKaryawan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKaryawan.Click += new System.EventHandler(this.btnTambahKaryawan_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.Olive;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPegawaiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.namaakunDataGridViewTextBoxColumn,
            this.katasandiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.rolepegawaiDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.pegawaiBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(700, 116);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(826, 558);
            this.guna2DataGridView1.TabIndex = 29;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Olive;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // db_GrapichArtDataSet
            // 
            this.db_GrapichArtDataSet.DataSetName = "Db_GrapichArtDataSet";
            this.db_GrapichArtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "Pegawai";
            this.pegawaiBindingSource.DataSource = this.db_GrapichArtDataSet;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // idPegawaiDataGridViewTextBoxColumn
            // 
            this.idPegawaiDataGridViewTextBoxColumn.DataPropertyName = "Id_Pegawai";
            this.idPegawaiDataGridViewTextBoxColumn.HeaderText = "ID Pegawai";
            this.idPegawaiDataGridViewTextBoxColumn.Name = "idPegawaiDataGridViewTextBoxColumn";
            this.idPegawaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "Nomer Telepon";
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            this.nohpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaakunDataGridViewTextBoxColumn
            // 
            this.namaakunDataGridViewTextBoxColumn.DataPropertyName = "nama_akun";
            this.namaakunDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.namaakunDataGridViewTextBoxColumn.Name = "namaakunDataGridViewTextBoxColumn";
            this.namaakunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // katasandiDataGridViewTextBoxColumn
            // 
            this.katasandiDataGridViewTextBoxColumn.DataPropertyName = "kata_sandi";
            this.katasandiDataGridViewTextBoxColumn.HeaderText = "Password";
            this.katasandiDataGridViewTextBoxColumn.Name = "katasandiDataGridViewTextBoxColumn";
            this.katasandiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolepegawaiDataGridViewTextBoxColumn
            // 
            this.rolepegawaiDataGridViewTextBoxColumn.DataPropertyName = "role_pegawai";
            this.rolepegawaiDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.rolepegawaiDataGridViewTextBoxColumn.Name = "rolepegawaiDataGridViewTextBoxColumn";
            this.rolepegawaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Panel_form
            // 
            this.Panel_form.Location = new System.Drawing.Point(12, 195);
            this.Panel_form.Name = "Panel_form";
            this.Panel_form.ShadowDecoration.Parent = this.Panel_form;
            this.Panel_form.Size = new System.Drawing.Size(638, 839);
            this.Panel_form.TabIndex = 30;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_update_24px;
            this.btnRefresh.Location = new System.Drawing.Point(1042, 721);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(180, 45);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Kelola_Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1558, 1046);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Panel_form);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnUbahData);
            this.Controls.Add(this.btnTambahKaryawan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kelola_Pegawai";
            this.Text = "Kelola_Pegawai";
            this.Load += new System.EventHandler(this.Kelola_Pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btnTambahKaryawan;
        private Bunifu.Framework.UI.BunifuFlatButton btnUbahData;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Db_GrapichArtDataSet db_GrapichArtDataSet;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private Db_GrapichArtDataSetTableAdapters.PegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaakunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katasandiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolepegawaiDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel Panel_form;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}