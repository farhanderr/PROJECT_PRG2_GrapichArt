namespace PROJECT_PRG2_GrapichArt
{
    partial class TambahMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahMember));
            this.txtNamaMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbJenisMember = new System.Windows.Forms.ComboBox();
            this.katMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_GrapichArtDataSet = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSet();
            this.katMemberTableAdapter = new PROJECT_PRG2_GrapichArt.Db_GrapichArtDataSetTableAdapters.KatMemberTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.katMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamaMember
            // 
            this.txtNamaMember.BackColor = System.Drawing.Color.Olive;
            this.txtNamaMember.Location = new System.Drawing.Point(19, 222);
            this.txtNamaMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamaMember.Multiline = true;
            this.txtNamaMember.Name = "txtNamaMember";
            this.txtNamaMember.Size = new System.Drawing.Size(372, 35);
            this.txtNamaMember.TabIndex = 64;
            this.txtNamaMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaMember_KeyPress);
            this.txtNamaMember.Leave += new System.EventHandler(this.txtNamaMember_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(16, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nama Member";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Jenis Member";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(-5, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1065, 10);
            this.label9.TabIndex = 60;
            this.label9.Text = "_______________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "TAMBAH MEMBER";
            // 
            // btnBatal
            // 
            this.btnBatal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBatal.BackColor = System.Drawing.Color.LightYellow;
            this.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatal.BorderRadius = 0;
            this.btnBatal.ButtonText = "Batal";
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.DisabledColor = System.Drawing.Color.Gray;
            this.btnBatal.ForeColor = System.Drawing.Color.Black;
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
            this.btnBatal.IconZoom = 50D;
            this.btnBatal.IsTab = false;
            this.btnBatal.Location = new System.Drawing.Point(209, 295);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnBatal.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(181, 50);
            this.btnBatal.TabIndex = 65;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBatal.Textcolor = System.Drawing.Color.Black;
            this.btnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSimpan
            // 
            this.btnSimpan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSimpan.BackColor = System.Drawing.Color.LightYellow;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderRadius = 0;
            this.btnSimpan.ButtonText = "Simpan";
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledColor = System.Drawing.Color.Gray;
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
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
            this.btnSimpan.IconZoom = 60D;
            this.btnSimpan.IsTab = false;
            this.btnSimpan.Location = new System.Drawing.Point(19, 295);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(181, 50);
            this.btnSimpan.TabIndex = 66;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpan.Textcolor = System.Drawing.Color.Black;
            this.btnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // cmbJenisMember
            // 
            this.cmbJenisMember.BackColor = System.Drawing.Color.Olive;
            this.cmbJenisMember.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.katMemberBindingSource, "Nama_KatMember", true));
            this.cmbJenisMember.DataSource = this.katMemberBindingSource;
            this.cmbJenisMember.DisplayMember = "Nama_KatMember";
            this.cmbJenisMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisMember.FormattingEnabled = true;
            this.cmbJenisMember.IntegralHeight = false;
            this.cmbJenisMember.Location = new System.Drawing.Point(19, 139);
            this.cmbJenisMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJenisMember.Name = "cmbJenisMember";
            this.cmbJenisMember.Size = new System.Drawing.Size(372, 24);
            this.cmbJenisMember.TabIndex = 67;
            this.cmbJenisMember.ValueMember = "Nama_KatMember";
            // 
            // katMemberBindingSource
            // 
            this.katMemberBindingSource.DataMember = "KatMember";
            this.katMemberBindingSource.DataSource = this.db_GrapichArtDataSet;
            // 
            // db_GrapichArtDataSet
            // 
            this.db_GrapichArtDataSet.DataSetName = "Db_GrapichArtDataSet";
            this.db_GrapichArtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katMemberTableAdapter
            // 
            this.katMemberTableAdapter.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // TambahMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(413, 367);
            this.Controls.Add(this.cmbJenisMember);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNamaMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TambahMember";
            this.Text = "TambahMember";
            this.Load += new System.EventHandler(this.TambahMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.katMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_GrapichArtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnSimpan;
        private System.Windows.Forms.TextBox txtNamaMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJenisMember;
        private Db_GrapichArtDataSet db_GrapichArtDataSet;
        private System.Windows.Forms.BindingSource katMemberBindingSource;
        private Db_GrapichArtDataSetTableAdapters.KatMemberTableAdapter katMemberTableAdapter;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}