namespace CHUNGCUVINHOME
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.tpgNhanKhau = new System.Windows.Forms.TabControl();
            this.tpgNhanVien = new System.Windows.Forms.TabPage();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTKten = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnTKid = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDtk = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.NhanKhau = new System.Windows.Forms.TabPage();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();
            this.mch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTKDC = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChiTK = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnTKTenNK = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNKtk = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.tpgNhanKhau.SuspendLayout();
            this.tpgNhanVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.NhanKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgNhanKhau
            // 
            this.tpgNhanKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpgNhanKhau.Controls.Add(this.tpgNhanVien);
            this.tpgNhanKhau.Controls.Add(this.NhanKhau);
            this.tpgNhanKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgNhanKhau.Location = new System.Drawing.Point(-1, 1);
            this.tpgNhanKhau.Name = "tpgNhanKhau";
            this.tpgNhanKhau.SelectedIndex = 0;
            this.tpgNhanKhau.Size = new System.Drawing.Size(1038, 522);
            this.tpgNhanKhau.TabIndex = 0;
            // 
            // tpgNhanVien
            // 
            this.tpgNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgNhanVien.BackgroundImage")));
            this.tpgNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpgNhanVien.Controls.Add(this.btnThoat);
            this.tpgNhanVien.Controls.Add(this.groupBox1);
            this.tpgNhanVien.Controls.Add(this.dgvNhanVien);
            this.tpgNhanVien.Controls.Add(this.label1);
            this.tpgNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgNhanVien.Location = new System.Drawing.Point(4, 28);
            this.tpgNhanVien.Name = "tpgNhanVien";
            this.tpgNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpgNhanVien.Size = new System.Drawing.Size(1030, 490);
            this.tpgNhanVien.TabIndex = 0;
            this.tpgNhanVien.Text = "Tìm kiếm Nhân viên";
            this.tpgNhanVien.UseVisualStyleBackColor = true;
            this.tpgNhanVien.Click += new System.EventHandler(this.tpgNhanVien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.ForeColor = System.Drawing.Color.Tomato;
            this.btnThoat.Location = new System.Drawing.Point(89, 432);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 32);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTKten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTentk);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.btnTKid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDtk);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 297);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tìm kiếm";
            // 
            // btnTKten
            // 
            this.btnTKten.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKten.ImageOptions.Image")));
            this.btnTKten.Location = new System.Drawing.Point(81, 238);
            this.btnTKten.Name = "btnTKten";
            this.btnTKten.Size = new System.Drawing.Size(86, 32);
            this.btnTKten.TabIndex = 19;
            this.btnTKten.Text = "Tìm kiếm";
            this.btnTKten.Click += new System.EventHandler(this.btnTKten_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(77, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhập Tên cần tìm";
            // 
            // txtTentk
            // 
            this.txtTentk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentk.Location = new System.Drawing.Point(80, 194);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(136, 29);
            this.txtTentk.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Location = new System.Drawing.Point(25, 191);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 32);
            this.labelControl2.TabIndex = 16;
            // 
            // btnTKid
            // 
            this.btnTKid.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKid.ImageOptions.Image")));
            this.btnTKid.Location = new System.Drawing.Point(81, 98);
            this.btnTKid.Name = "btnTKid";
            this.btnTKid.Size = new System.Drawing.Size(86, 32);
            this.btnTKid.TabIndex = 15;
            this.btnTKid.Text = "Tìm kiếm";
            this.btnTKid.Click += new System.EventHandler(this.btnTKid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(77, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập mã nhân viên cần tìm";
            // 
            // txtIDtk
            // 
            this.txtIDtk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDtk.Location = new System.Drawing.Point(80, 54);
            this.txtIDtk.Name = "txtIDtk";
            this.txtIDtk.Size = new System.Drawing.Size(136, 29);
            this.txtIDtk.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(25, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 32);
            this.labelControl1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 11;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTENNV,
            this.NS,
            this.PHAI,
            this.CV,
            this.MAIL});
            this.dgvNhanVien.Location = new System.Drawing.Point(277, 116);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(746, 297);
            this.dgvNhanVien.TabIndex = 29;
            // 
            // MANV
            // 
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            // 
            // HOTENNV
            // 
            this.HOTENNV.HeaderText = "Họ tên";
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Width = 155;
            // 
            // NS
            // 
            this.NS.HeaderText = "NTNS";
            this.NS.Name = "NS";
            this.NS.Width = 80;
            // 
            // PHAI
            // 
            this.PHAI.HeaderText = "Phái";
            this.PHAI.Name = "PHAI";
            this.PHAI.Width = 50;
            // 
            // CV
            // 
            this.CV.HeaderText = "Chức vụ";
            this.CV.Name = "CV";
            // 
            // MAIL
            // 
            this.MAIL.HeaderText = "Mail";
            this.MAIL.Name = "MAIL";
            this.MAIL.Width = 220;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(257, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            // 
            // NhanKhau
            // 
            this.NhanKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NhanKhau.BackgroundImage")));
            this.NhanKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NhanKhau.Controls.Add(this.btnThoat1);
            this.NhanKhau.Controls.Add(this.dgvNhanKhau);
            this.NhanKhau.Controls.Add(this.label8);
            this.NhanKhau.Controls.Add(this.groupBox2);
            this.NhanKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanKhau.Location = new System.Drawing.Point(4, 28);
            this.NhanKhau.Name = "NhanKhau";
            this.NhanKhau.Padding = new System.Windows.Forms.Padding(3);
            this.NhanKhau.Size = new System.Drawing.Size(1030, 490);
            this.NhanKhau.TabIndex = 1;
            this.NhanKhau.Text = "Tìm kiếm Nhân khẩu";
            this.NhanKhau.UseVisualStyleBackColor = true;
            // 
            // btnThoat1
            // 
            this.btnThoat1.BackColor = System.Drawing.Color.Black;
            this.btnThoat1.ForeColor = System.Drawing.Color.Tomato;
            this.btnThoat1.Location = new System.Drawing.Point(97, 433);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(85, 32);
            this.btnThoat1.TabIndex = 34;
            this.btnThoat1.Text = "THOÁT";
            this.btnThoat1.UseVisualStyleBackColor = false;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanKhau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mch,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.QUE,
            this.sdt});
            this.dgvNhanKhau.Location = new System.Drawing.Point(288, 108);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.Size = new System.Drawing.Size(736, 308);
            this.dgvNhanKhau.TabIndex = 33;
            // 
            // mch
            // 
            this.mch.HeaderText = "MãCH";
            this.mch.Name = "mch";
            this.mch.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 155;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NTNS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Phái";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // QUE
            // 
            this.QUE.HeaderText = "Quê quán";
            this.QUE.Name = "QUE";
            this.QUE.Width = 240;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số ĐT";
            this.sdt.Name = "sdt";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(269, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(486, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "TÌM KIẾM THÔNG TIN NHÂN KHẨU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTKDC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDiaChiTK);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.btnTKTenNK);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenNKtk);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 297);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Tìm kiếm";
            // 
            // btnTKDC
            // 
            this.btnTKDC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKDC.ImageOptions.Image")));
            this.btnTKDC.Location = new System.Drawing.Point(81, 238);
            this.btnTKDC.Name = "btnTKDC";
            this.btnTKDC.Size = new System.Drawing.Size(86, 32);
            this.btnTKDC.TabIndex = 19;
            this.btnTKDC.Text = "Tìm kiếm";
            this.btnTKDC.Click += new System.EventHandler(this.btnTKDC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(77, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nhập Quê quán cần tìm";
            // 
            // txtDiaChiTK
            // 
            this.txtDiaChiTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiTK.Location = new System.Drawing.Point(80, 194);
            this.txtDiaChiTK.Name = "txtDiaChiTK";
            this.txtDiaChiTK.Size = new System.Drawing.Size(136, 29);
            this.txtDiaChiTK.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.ImageOptions.Image")));
            this.labelControl3.Location = new System.Drawing.Point(25, 191);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 32);
            this.labelControl3.TabIndex = 16;
            // 
            // btnTKTenNK
            // 
            this.btnTKTenNK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKTenNK.ImageOptions.Image")));
            this.btnTKTenNK.Location = new System.Drawing.Point(81, 98);
            this.btnTKTenNK.Name = "btnTKTenNK";
            this.btnTKTenNK.Size = new System.Drawing.Size(86, 32);
            this.btnTKTenNK.TabIndex = 15;
            this.btnTKTenNK.Text = "Tìm kiếm";
            this.btnTKTenNK.Click += new System.EventHandler(this.btnTKTenNK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(77, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập Tên cần tìm";
            // 
            // txtTenNKtk
            // 
            this.txtTenNKtk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNKtk.Location = new System.Drawing.Point(80, 54);
            this.txtTenNKtk.Name = "txtTenNKtk";
            this.txtTenNKtk.Size = new System.Drawing.Size(136, 29);
            this.txtTenNKtk.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.ImageOptions.Image")));
            this.labelControl4.Location = new System.Drawing.Point(25, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 32);
            this.labelControl4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 11;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1035, 516);
            this.Controls.Add(this.tpgNhanKhau);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmTimKiem.IconOptions.LargeImage")));
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM THÔNG TIN";
            this.tpgNhanKhau.ResumeLayout(false);
            this.tpgNhanVien.ResumeLayout(false);
            this.tpgNhanVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.NhanKhau.ResumeLayout(false);
            this.NhanKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpgNhanKhau;
        private System.Windows.Forms.TabPage tpgNhanVien;
        private System.Windows.Forms.TabPage NhanKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnTKten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTentk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTKid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDtk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnTKDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChiTK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTKTenNK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNKtk;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn mch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}