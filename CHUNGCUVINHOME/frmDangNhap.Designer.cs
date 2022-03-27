namespace CHUNGCUVINHOME
{
    partial class frmDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnDN = new DevExpress.XtraEditors.SimpleButton();
            this.txtThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnRSP = new System.Windows.Forms.Button();
            this.btnDongCT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtnHienMK = new DevExpress.XtraEditors.CheckButton();
            this.btnHDSD = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(139, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 32);
            this.labelControl1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(139, 212);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 32);
            this.labelControl2.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(194, 146);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 29);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(194, 213);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(136, 29);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnDN
            // 
            this.btnDN.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDN.Appearance.Options.UseFont = true;
            this.btnDN.Appearance.Options.UseForeColor = true;
            this.btnDN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDN.ImageOptions.Image")));
            this.btnDN.Location = new System.Drawing.Point(194, 268);
            this.btnDN.Name = "btnDN";
            this.btnDN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDN.Size = new System.Drawing.Size(120, 36);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtThoat
            // 
            this.txtThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtThoat.ImageOptions.Image")));
            this.txtThoat.Location = new System.Drawing.Point(371, 336);
            this.txtThoat.Name = "txtThoat";
            this.txtThoat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.txtThoat.Size = new System.Drawing.Size(0, 0);
            this.txtThoat.TabIndex = 7;
            // 
            // btnRSP
            // 
            this.btnRSP.BackColor = System.Drawing.Color.Black;
            this.btnRSP.ForeColor = System.Drawing.Color.Tomato;
            this.btnRSP.Location = new System.Drawing.Point(86, 336);
            this.btnRSP.Name = "btnRSP";
            this.btnRSP.Size = new System.Drawing.Size(85, 32);
            this.btnRSP.TabIndex = 4;
            this.btnRSP.Text = "RESET PASS";
            this.btnRSP.UseVisualStyleBackColor = false;
            this.btnRSP.Click += new System.EventHandler(this.txtRSP_Click);
            // 
            // btnDongCT
            // 
            this.btnDongCT.BackColor = System.Drawing.Color.Black;
            this.btnDongCT.ForeColor = System.Drawing.Color.Tomato;
            this.btnDongCT.Location = new System.Drawing.Point(329, 336);
            this.btnDongCT.Name = "btnDongCT";
            this.btnDongCT.Size = new System.Drawing.Size(85, 32);
            this.btnDongCT.TabIndex = 5;
            this.btnDongCT.Text = "THOÁT";
            this.btnDongCT.UseVisualStyleBackColor = false;
            this.btnDongCT.Click += new System.EventHandler(this.txtDongCT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(191, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(191, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập PassWord";
            // 
            // cbtnHienMK
            // 
            this.cbtnHienMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbtnHienMK.ImageOptions.Image")));
            this.cbtnHienMK.ImageOptions.ImageIndex = 1;
            this.cbtnHienMK.Location = new System.Drawing.Point(330, 213);
            this.cbtnHienMK.Name = "cbtnHienMK";
            this.cbtnHienMK.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.cbtnHienMK.Size = new System.Drawing.Size(35, 29);
            this.cbtnHienMK.TabIndex = 12;
            this.cbtnHienMK.ToolTip = "Hiển thị mật khẩu";
            this.cbtnHienMK.CheckedChanged += new System.EventHandler(this.cbtnHienMK_CheckedChanged);
            // 
            // btnHDSD
            // 
            this.btnHDSD.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDSD.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnHDSD.Appearance.Options.UseFont = true;
            this.btnHDSD.Appearance.Options.UseForeColor = true;
            this.btnHDSD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHDSD.ImageOptions.Image")));
            this.btnHDSD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHDSD.Location = new System.Drawing.Point(478, 2);
            this.btnHDSD.Name = "btnHDSD";
            this.btnHDSD.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnHDSD.Size = new System.Drawing.Size(36, 36);
            this.btnHDSD.TabIndex = 6;
            this.btnHDSD.ToolTip = "Hướng dẫn sử dụng phần mềm chung cư VinHomes";
            this.btnHDSD.Click += new System.EventHandler(this.btnHDSD_Click);
            // 
            // frmDN
            // 
            this.AcceptButton = this.btnDN;
            this.ActiveGlowColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(514, 443);
            this.Controls.Add(this.btnHDSD);
            this.Controls.Add(this.cbtnHienMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDongCT);
            this.Controls.Add(this.btnRSP);
            this.Controls.Add(this.txtThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmDN.IconOptions.Image")));
            this.InactiveGlowColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.Name = "frmDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.SimpleButton btnDN;
        private DevExpress.XtraEditors.SimpleButton txtThoat;
        private System.Windows.Forms.Button btnRSP;
        private System.Windows.Forms.Button btnDongCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CheckButton cbtnHienMK;
        private DevExpress.XtraEditors.SimpleButton btnHDSD;
    }
}

