namespace PROJECT_PRG2_GrapichArt
{
    partial class Kelola_KatMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUbahDataJenisMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTambahJenisMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel_form = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.db_GrapichArtDataSet = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSet();
            this.katMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katMemberTableAdapter = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSetTableAdapters.KatMemberTableAdapter();
            this.idKatMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKatMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peraturanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(9, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1513, 10);
            this.label9.TabIndex = 40;
            this.label9.Text = "_______________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(689, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "KELOLA JENIS MEMBER";
            // 
            // btnUbahDataJenisMember
            // 
            this.btnUbahDataJenisMember.Activecolor = System.Drawing.Color.LightYellow;
            this.btnUbahDataJenisMember.BackColor = System.Drawing.Color.LightYellow;
            this.btnUbahDataJenisMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbahDataJenisMember.BorderRadius = 0;
            this.btnUbahDataJenisMember.ButtonText = "Ubah Data Jenis Member";
            this.btnUbahDataJenisMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbahDataJenisMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnUbahDataJenisMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUbahDataJenisMember.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_update_24px;
            this.btnUbahDataJenisMember.Iconimage_right = null;
            this.btnUbahDataJenisMember.Iconimage_right_Selected = null;
            this.btnUbahDataJenisMember.Iconimage_Selected = null;
            this.btnUbahDataJenisMember.IconMarginLeft = 0;
            this.btnUbahDataJenisMember.IconMarginRight = 0;
            this.btnUbahDataJenisMember.IconRightVisible = true;
            this.btnUbahDataJenisMember.IconRightZoom = 0D;
            this.btnUbahDataJenisMember.IconVisible = true;
            this.btnUbahDataJenisMember.IconZoom = 90D;
            this.btnUbahDataJenisMember.IsTab = false;
            this.btnUbahDataJenisMember.Location = new System.Drawing.Point(417, 86);
            this.btnUbahDataJenisMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbahDataJenisMember.Name = "btnUbahDataJenisMember";
            this.btnUbahDataJenisMember.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnUbahDataJenisMember.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnUbahDataJenisMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUbahDataJenisMember.selected = false;
            this.btnUbahDataJenisMember.Size = new System.Drawing.Size(241, 45);
            this.btnUbahDataJenisMember.TabIndex = 41;
            this.btnUbahDataJenisMember.Text = "Ubah Data Jenis Member";
            this.btnUbahDataJenisMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUbahDataJenisMember.Textcolor = System.Drawing.Color.Black;
            this.btnUbahDataJenisMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahDataJenisMember.Click += new System.EventHandler(this.btnUbahDataJenisMember_Click);
            // 
            // btnTambahJenisMember
            // 
            this.btnTambahJenisMember.Activecolor = System.Drawing.Color.LightYellow;
            this.btnTambahJenisMember.BackColor = System.Drawing.Color.LightYellow;
            this.btnTambahJenisMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahJenisMember.BorderRadius = 0;
            this.btnTambahJenisMember.ButtonText = "Tambah Jenis Member";
            this.btnTambahJenisMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahJenisMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambahJenisMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambahJenisMember.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_add_30px;
            this.btnTambahJenisMember.Iconimage_right = null;
            this.btnTambahJenisMember.Iconimage_right_Selected = null;
            this.btnTambahJenisMember.Iconimage_Selected = null;
            this.btnTambahJenisMember.IconMarginLeft = 0;
            this.btnTambahJenisMember.IconMarginRight = 0;
            this.btnTambahJenisMember.IconRightVisible = true;
            this.btnTambahJenisMember.IconRightZoom = 0D;
            this.btnTambahJenisMember.IconVisible = true;
            this.btnTambahJenisMember.IconZoom = 90D;
            this.btnTambahJenisMember.IsTab = false;
            this.btnTambahJenisMember.Location = new System.Drawing.Point(46, 86);
            this.btnTambahJenisMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahJenisMember.Name = "btnTambahJenisMember";
            this.btnTambahJenisMember.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnTambahJenisMember.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnTambahJenisMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTambahJenisMember.selected = false;
            this.btnTambahJenisMember.Size = new System.Drawing.Size(241, 45);
            this.btnTambahJenisMember.TabIndex = 42;
            this.btnTambahJenisMember.Text = "Tambah Jenis Member";
            this.btnTambahJenisMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambahJenisMember.Textcolor = System.Drawing.Color.Black;
            this.btnTambahJenisMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahJenisMember.Click += new System.EventHandler(this.btnTambahJenisMember_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowUserToAddRows = false;
            this.btnRefresh.AllowUserToDeleteRows = false;
            this.btnRefresh.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.btnRefresh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.btnRefresh.AutoGenerateColumns = false;
            this.btnRefresh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.Olive;
            this.btnRefresh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnRefresh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.btnRefresh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.btnRefresh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.btnRefresh.ColumnHeadersHeight = 40;
            this.btnRefresh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.btnRefresh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKatMemberDataGridViewTextBoxColumn,
            this.namaKatMemberDataGridViewTextBoxColumn,
            this.potonganDataGridViewTextBoxColumn,
            this.peraturanDataGridViewTextBoxColumn});
            this.btnRefresh.DataSource = this.katMemberBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.btnRefresh.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnRefresh.EnableHeadersVisualStyles = false;
            this.btnRefresh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.btnRefresh.Location = new System.Drawing.Point(684, 86);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ReadOnly = true;
            this.btnRefresh.RowHeadersVisible = false;
            this.btnRefresh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.btnRefresh.Size = new System.Drawing.Size(826, 558);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.btnRefresh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.btnRefresh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.btnRefresh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.btnRefresh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.btnRefresh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.btnRefresh.ThemeStyle.BackColor = System.Drawing.Color.Olive;
            this.btnRefresh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.btnRefresh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.btnRefresh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.btnRefresh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnRefresh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.btnRefresh.ThemeStyle.HeaderStyle.Height = 40;
            this.btnRefresh.ThemeStyle.ReadOnly = true;
            this.btnRefresh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.btnRefresh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.btnRefresh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnRefresh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.ThemeStyle.RowsStyle.Height = 22;
            this.btnRefresh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.btnRefresh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Panel_form
            // 
            this.Panel_form.Location = new System.Drawing.Point(20, 147);
            this.Panel_form.Name = "Panel_form";
            this.Panel_form.ShadowDecoration.Parent = this.Panel_form;
            this.Panel_form.Size = new System.Drawing.Size(638, 839);
            this.Panel_form.TabIndex = 44;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LightYellow;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.LightYellow;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_update_24px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(937, 668);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.LightYellow;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 45);
            this.bunifuFlatButton1.TabIndex = 45;
            this.bunifuFlatButton1.Text = "refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // db_GrapichArtDataSet
            // 
            this.db_GrapichArtDataSet.DataSetName = "Db_GrapichArtDataSet";
            this.db_GrapichArtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katMemberBindingSource
            // 
            this.katMemberBindingSource.DataMember = "KatMember";
            this.katMemberBindingSource.DataSource = this.db_GrapichArtDataSet;
            // 
            // katMemberTableAdapter
            // 
            this.katMemberTableAdapter.ClearBeforeFill = true;
            // 
            // idKatMemberDataGridViewTextBoxColumn
            // 
            this.idKatMemberDataGridViewTextBoxColumn.DataPropertyName = "Id_KatMember";
            this.idKatMemberDataGridViewTextBoxColumn.HeaderText = "ID Kategori";
            this.idKatMemberDataGridViewTextBoxColumn.Name = "idKatMemberDataGridViewTextBoxColumn";
            this.idKatMemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaKatMemberDataGridViewTextBoxColumn
            // 
            this.namaKatMemberDataGridViewTextBoxColumn.DataPropertyName = "Nama_KatMember";
            this.namaKatMemberDataGridViewTextBoxColumn.HeaderText = "Nama Kategori";
            this.namaKatMemberDataGridViewTextBoxColumn.Name = "namaKatMemberDataGridViewTextBoxColumn";
            this.namaKatMemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potonganDataGridViewTextBoxColumn
            // 
            this.potonganDataGridViewTextBoxColumn.DataPropertyName = "Potongan";
            this.potonganDataGridViewTextBoxColumn.HeaderText = "Potongan";
            this.potonganDataGridViewTextBoxColumn.Name = "potonganDataGridViewTextBoxColumn";
            this.potonganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peraturanDataGridViewTextBoxColumn
            // 
            this.peraturanDataGridViewTextBoxColumn.DataPropertyName = "Peraturan";
            this.peraturanDataGridViewTextBoxColumn.HeaderText = "Peraturan";
            this.peraturanDataGridViewTextBoxColumn.Name = "peraturanDataGridViewTextBoxColumn";
            this.peraturanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kelola_KatMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1542, 1007);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Panel_form);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUbahDataJenisMember);
            this.Controls.Add(this.btnTambahJenisMember);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Kelola_KatMember";
            this.Text = "Refresh";
            this.Load += new System.EventHandler(this.Kelola_KatMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnUbahDataJenisMember;
        private Bunifu.Framework.UI.BunifuFlatButton btnTambahJenisMember;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView btnRefresh;
        private Guna.UI2.WinForms.Guna2Panel Panel_form;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Db_GrapichArtDataSet db_GrapichArtDataSet;
        private System.Windows.Forms.BindingSource katMemberBindingSource;
        private Db_GrapichArtDataSetTableAdapters.KatMemberTableAdapter katMemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKatMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKatMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potonganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peraturanDataGridViewTextBoxColumn;
    }
}