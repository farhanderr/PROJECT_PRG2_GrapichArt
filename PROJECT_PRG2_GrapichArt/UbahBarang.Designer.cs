namespace PROJECT_PRG2_GrapichArt
{
    partial class UbahBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahBarang));
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHapusBarang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCariBarang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateBarang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.BackColor = System.Drawing.Color.Olive;
            this.txtJumlahBarang.Location = new System.Drawing.Point(16, 305);
            this.txtJumlahBarang.Multiline = true;
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(280, 29);
            this.txtJumlahBarang.TabIndex = 46;
            this.txtJumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBarang_KeyPress);
            this.txtJumlahBarang.Leave += new System.EventHandler(this.txtJumlahBarang_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(14, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Jumlah";
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.BackColor = System.Drawing.Color.Olive;
            this.txtHargaBarang.Location = new System.Drawing.Point(16, 231);
            this.txtHargaBarang.Multiline = true;
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(280, 29);
            this.txtHargaBarang.TabIndex = 44;
            this.txtHargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBarang_KeyPress);
            this.txtHargaBarang.Leave += new System.EventHandler(this.txtHargaBarang_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(14, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Harga Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.BackColor = System.Drawing.Color.Olive;
            this.txtNamaBarang.Location = new System.Drawing.Point(16, 157);
            this.txtNamaBarang.Multiline = true;
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(280, 29);
            this.txtNamaBarang.TabIndex = 42;
            this.txtNamaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaBarang_KeyPress);
            this.txtNamaBarang.Leave += new System.EventHandler(this.txtNamaBarang_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(14, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nama Barang";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(-2, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(614, 10);
            this.label9.TabIndex = 40;
            this.label9.Text = "_______________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "KELOLA BARANG";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID Barang";
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.BackColor = System.Drawing.Color.Olive;
            this.txtIdBarang.Location = new System.Drawing.Point(16, 89);
            this.txtIdBarang.Multiline = true;
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(155, 29);
            this.txtIdBarang.TabIndex = 42;
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
            this.btnBatal.Location = new System.Drawing.Point(302, 351);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnBatal.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(136, 41);
            this.btnBatal.TabIndex = 47;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBatal.Textcolor = System.Drawing.Color.Black;
            this.btnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHapusBarang
            // 
            this.btnHapusBarang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusBarang.BackColor = System.Drawing.Color.LightYellow;
            this.btnHapusBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusBarang.BorderRadius = 0;
            this.btnHapusBarang.ButtonText = "Hapus";
            this.btnHapusBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusBarang.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapusBarang.ForeColor = System.Drawing.Color.Black;
            this.btnHapusBarang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapusBarang.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_delete_26px;
            this.btnHapusBarang.Iconimage_right = null;
            this.btnHapusBarang.Iconimage_right_Selected = null;
            this.btnHapusBarang.Iconimage_Selected = null;
            this.btnHapusBarang.IconMarginLeft = 0;
            this.btnHapusBarang.IconMarginRight = 0;
            this.btnHapusBarang.IconRightVisible = true;
            this.btnHapusBarang.IconRightZoom = 0D;
            this.btnHapusBarang.IconVisible = true;
            this.btnHapusBarang.IconZoom = 50D;
            this.btnHapusBarang.IsTab = false;
            this.btnHapusBarang.Location = new System.Drawing.Point(159, 351);
            this.btnHapusBarang.Name = "btnHapusBarang";
            this.btnHapusBarang.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnHapusBarang.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnHapusBarang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapusBarang.selected = false;
            this.btnHapusBarang.Size = new System.Drawing.Size(136, 41);
            this.btnHapusBarang.TabIndex = 47;
            this.btnHapusBarang.Text = "Hapus";
            this.btnHapusBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHapusBarang.Textcolor = System.Drawing.Color.Black;
            this.btnHapusBarang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusBarang.Click += new System.EventHandler(this.btnHapusBarang_Click);
            // 
            // btnCariBarang
            // 
            this.btnCariBarang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariBarang.BackColor = System.Drawing.Color.LightYellow;
            this.btnCariBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBarang.BorderRadius = 0;
            this.btnCariBarang.ButtonText = "Cari";
            this.btnCariBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariBarang.DisabledColor = System.Drawing.Color.Gray;
            this.btnCariBarang.ForeColor = System.Drawing.Color.Black;
            this.btnCariBarang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCariBarang.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_search_32px;
            this.btnCariBarang.Iconimage_right = null;
            this.btnCariBarang.Iconimage_right_Selected = null;
            this.btnCariBarang.Iconimage_Selected = null;
            this.btnCariBarang.IconMarginLeft = 0;
            this.btnCariBarang.IconMarginRight = 0;
            this.btnCariBarang.IconRightVisible = true;
            this.btnCariBarang.IconRightZoom = 0D;
            this.btnCariBarang.IconVisible = true;
            this.btnCariBarang.IconZoom = 60D;
            this.btnCariBarang.IsTab = false;
            this.btnCariBarang.Location = new System.Drawing.Point(176, 89);
            this.btnCariBarang.Name = "btnCariBarang";
            this.btnCariBarang.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnCariBarang.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnCariBarang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCariBarang.selected = false;
            this.btnCariBarang.Size = new System.Drawing.Size(136, 41);
            this.btnCariBarang.TabIndex = 48;
            this.btnCariBarang.Text = "Cari";
            this.btnCariBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCariBarang.Textcolor = System.Drawing.Color.Black;
            this.btnCariBarang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariBarang.Click += new System.EventHandler(this.btnCariBarang_Click);
            // 
            // btnUpdateBarang
            // 
            this.btnUpdateBarang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateBarang.BackColor = System.Drawing.Color.LightYellow;
            this.btnUpdateBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateBarang.BorderRadius = 0;
            this.btnUpdateBarang.ButtonText = "Ubah";
            this.btnUpdateBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBarang.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateBarang.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBarang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateBarang.Iconimage = global::PROJECT_PRG2_GrapichArt.Properties.Resources.icons8_update_24px;
            this.btnUpdateBarang.Iconimage_right = null;
            this.btnUpdateBarang.Iconimage_right_Selected = null;
            this.btnUpdateBarang.Iconimage_Selected = null;
            this.btnUpdateBarang.IconMarginLeft = 0;
            this.btnUpdateBarang.IconMarginRight = 0;
            this.btnUpdateBarang.IconRightVisible = true;
            this.btnUpdateBarang.IconRightZoom = 0D;
            this.btnUpdateBarang.IconVisible = true;
            this.btnUpdateBarang.IconZoom = 60D;
            this.btnUpdateBarang.IsTab = false;
            this.btnUpdateBarang.Location = new System.Drawing.Point(16, 351);
            this.btnUpdateBarang.Name = "btnUpdateBarang";
            this.btnUpdateBarang.Normalcolor = System.Drawing.Color.LightYellow;
            this.btnUpdateBarang.OnHovercolor = System.Drawing.Color.DarkKhaki;
            this.btnUpdateBarang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateBarang.selected = false;
            this.btnUpdateBarang.Size = new System.Drawing.Size(136, 41);
            this.btnUpdateBarang.TabIndex = 48;
            this.btnUpdateBarang.Text = "Ubah";
            this.btnUpdateBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateBarang.Textcolor = System.Drawing.Color.Black;
            this.btnUpdateBarang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBarang.Click += new System.EventHandler(this.btnUpdateBarang_Click);
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
            // UbahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(445, 407);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapusBarang);
            this.Controls.Add(this.btnCariBarang);
            this.Controls.Add(this.btnUpdateBarang);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHargaBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UbahBarang";
            this.Text = "UbahBarang";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnHapusBarang;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateBarang;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdBarang;
        private Bunifu.Framework.UI.BunifuFlatButton btnCariBarang;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}