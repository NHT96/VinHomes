namespace CHUNGCUVINHOME
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsNhanVien = new CHUNGCUVINHOME.dtsNhanVien();
            this.CHDBbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCHDaBan = new CHUNGCUVINHOME.dtsCHDaBan();
            this.CANHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCHChuaBan = new CHUNGCUVINHOME.dtsCHChuaBan();
            this.NHANKHAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsTCNK = new CHUNGCUVINHOME.dtsTCNK();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rpvNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatDSNV = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rpvCHDB = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatCHDB = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rpvCHCB = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatCHCB = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rpvNKTK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboBL = new System.Windows.Forms.ComboBox();
            this.btnThoat5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatTungKhu = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnThoat4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatBC4 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rpvTCNK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NHANVIENTableAdapter = new CHUNGCUVINHOME.dtsNhanVienTableAdapters.NHANVIENTableAdapter();
            this.NHANKHAUTableAdapter = new CHUNGCUVINHOME.dtsTCNKTableAdapters.NHANKHAUTableAdapter();
            this.cANHOTableAdapter1 = new CHUNGCUVINHOME.dtsCHDaBanTableAdapters.CANHOTableAdapter();
            this.CANHOTableAdapter = new CHUNGCUVINHOME.dtsCHChuaBanTableAdapters.CANHOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHDBbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCHDaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CANHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCHChuaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANKHAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTCNK)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // NHANVIENBindingSource
            // 
            this.NHANVIENBindingSource.DataMember = "NHANVIEN";
            this.NHANVIENBindingSource.DataSource = this.dtsNhanVien;
            // 
            // dtsNhanVien
            // 
            this.dtsNhanVien.DataSetName = "dtsNhanVien";
            this.dtsNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHDBbindingSource
            // 
            this.CHDBbindingSource.DataMember = "CANHO";
            this.CHDBbindingSource.DataSource = this.dtsCHDaBan;
            // 
            // dtsCHDaBan
            // 
            this.dtsCHDaBan.DataSetName = "dtsCHDaBan";
            this.dtsCHDaBan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CANHOBindingSource
            // 
            this.CANHOBindingSource.DataMember = "CANHO";
            this.CANHOBindingSource.DataSource = this.dtsCHChuaBan;
            // 
            // dtsCHChuaBan
            // 
            this.dtsCHChuaBan.DataSetName = "dtsCHChuaBan";
            this.dtsCHChuaBan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHANKHAUBindingSource
            // 
            this.NHANKHAUBindingSource.DataMember = "NHANKHAU";
            this.NHANKHAUBindingSource.DataSource = this.dtsTCNK;
            // 
            // dtsTCNK
            // 
            this.dtsTCNK.DataSetName = "dtsTCNK";
            this.dtsTCNK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 524);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.rpvNV);
            this.tabPage3.Controls.Add(this.btnThoat1);
            this.tabPage3.Controls.Add(this.btnXuatDSNV);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1107, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách nhân viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rpvNV
            // 
            this.rpvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetNV";
            reportDataSource1.Value = this.NHANVIENBindingSource;
            this.rpvNV.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvNV.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptNhanVien.rdlc";
            this.rpvNV.Location = new System.Drawing.Point(0, 77);
            this.rpvNV.Name = "rpvNV";
            this.rpvNV.ServerReport.BearerToken = null;
            this.rpvNV.Size = new System.Drawing.Size(1104, 418);
            this.rpvNV.TabIndex = 32;
            // 
            // btnThoat1
            // 
            this.btnThoat1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat1.ImageOptions.Image")));
            this.btnThoat1.Location = new System.Drawing.Point(845, 24);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(107, 32);
            this.btnThoat1.TabIndex = 31;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // btnXuatDSNV
            // 
            this.btnXuatDSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatDSNV.ImageOptions.Image")));
            this.btnXuatDSNV.Location = new System.Drawing.Point(130, 24);
            this.btnXuatDSNV.Name = "btnXuatDSNV";
            this.btnXuatDSNV.Size = new System.Drawing.Size(107, 32);
            this.btnXuatDSNV.TabIndex = 30;
            this.btnXuatDSNV.Text = "Xuất báo cáo";
            this.btnXuatDSNV.Click += new System.EventHandler(this.btnXuatDSNV_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(378, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.rpvCHDB);
            this.tabPage1.Controls.Add(this.btnThoat3);
            this.tabPage1.Controls.Add(this.btnXuatCHDB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Căn hộ đã bán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rpvCHDB
            // 
            this.rpvCHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CHDBbindingSource;
            this.rpvCHDB.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvCHDB.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptCHDB.rdlc";
            this.rpvCHDB.Location = new System.Drawing.Point(1, 91);
            this.rpvCHDB.Name = "rpvCHDB";
            this.rpvCHDB.ServerReport.BearerToken = null;
            this.rpvCHDB.Size = new System.Drawing.Size(1106, 404);
            this.rpvCHDB.TabIndex = 38;
            // 
            // btnThoat3
            // 
            this.btnThoat3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat3.ImageOptions.Image")));
            this.btnThoat3.Location = new System.Drawing.Point(856, 20);
            this.btnThoat3.Name = "btnThoat3";
            this.btnThoat3.Size = new System.Drawing.Size(107, 32);
            this.btnThoat3.TabIndex = 37;
            this.btnThoat3.Text = "Thoát";
            this.btnThoat3.Click += new System.EventHandler(this.btnThoat3_Click);
            // 
            // btnXuatCHDB
            // 
            this.btnXuatCHDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatCHDB.ImageOptions.Image")));
            this.btnXuatCHDB.Location = new System.Drawing.Point(141, 20);
            this.btnXuatCHDB.Name = "btnXuatCHDB";
            this.btnXuatCHDB.Size = new System.Drawing.Size(107, 32);
            this.btnXuatCHDB.TabIndex = 36;
            this.btnXuatCHDB.Text = "Xuất báo cáo";
            this.btnXuatCHDB.Click += new System.EventHandler(this.btnXuatCHDB_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(348, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "DANH SÁCH CĂN HỘ ĐÃ BÁN";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.rpvCHCB);
            this.tabPage2.Controls.Add(this.btnThoat2);
            this.tabPage2.Controls.Add(this.btnXuatCHCB);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Căn hộ chưa bán";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rpvCHCB
            // 
            this.rpvCHCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSetCB";
            reportDataSource3.Value = this.CANHOBindingSource;
            this.rpvCHCB.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvCHCB.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptCHCB.rdlc";
            this.rpvCHCB.Location = new System.Drawing.Point(0, 103);
            this.rpvCHCB.Name = "rpvCHCB";
            this.rpvCHCB.ServerReport.BearerToken = null;
            this.rpvCHCB.Size = new System.Drawing.Size(1107, 392);
            this.rpvCHCB.TabIndex = 35;
            // 
            // btnThoat2
            // 
            this.btnThoat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat2.ImageOptions.Image")));
            this.btnThoat2.Location = new System.Drawing.Point(860, 31);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(107, 32);
            this.btnThoat2.TabIndex = 34;
            this.btnThoat2.Text = "Thoát";
            this.btnThoat2.Click += new System.EventHandler(this.btnThoat2_Click);
            // 
            // btnXuatCHCB
            // 
            this.btnXuatCHCB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatCHCB.ImageOptions.Image")));
            this.btnXuatCHCB.Location = new System.Drawing.Point(145, 31);
            this.btnXuatCHCB.Name = "btnXuatCHCB";
            this.btnXuatCHCB.Size = new System.Drawing.Size(107, 32);
            this.btnXuatCHCB.TabIndex = 33;
            this.btnXuatCHCB.Text = "Xuất báo cáo";
            this.btnXuatCHCB.Click += new System.EventHandler(this.btnXuatCHCB_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(346, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "DANH SÁCH CĂN HỘ CHƯA BÁN";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.rpvNKTK);
            this.tabPage4.Controls.Add(this.cboBL);
            this.tabPage4.Controls.Add(this.btnThoat5);
            this.tabPage4.Controls.Add(this.btnXuatTungKhu);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1107, 495);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhân khẩu từng block";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rpvNKTK
            // 
            this.rpvNKTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DataSetRPTnktk";
            reportDataSource4.Value = this.NHANKHAUBindingSource;
            this.rpvNKTK.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvNKTK.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptNKTK.rdlc";
            this.rpvNKTK.Location = new System.Drawing.Point(3, 126);
            this.rpvNKTK.Name = "rpvNKTK";
            this.rpvNKTK.ServerReport.BearerToken = null;
            this.rpvNKTK.Size = new System.Drawing.Size(1101, 368);
            this.rpvNKTK.TabIndex = 42;
            // 
            // cboBL
            // 
            this.cboBL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBL.FormattingEnabled = true;
            this.cboBL.Items.AddRange(new object[] {
            "Block A",
            "Block B",
            "Block C",
            "Block D",
            "Block E",
            "Block F",
            "Block G",
            "Block H",
            "Block I"});
            this.cboBL.Location = new System.Drawing.Point(61, 34);
            this.cboBL.Name = "cboBL";
            this.cboBL.Size = new System.Drawing.Size(107, 27);
            this.cboBL.TabIndex = 41;
            // 
            // btnThoat5
            // 
            this.btnThoat5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat5.ImageOptions.Image")));
            this.btnThoat5.Location = new System.Drawing.Point(949, 34);
            this.btnThoat5.Name = "btnThoat5";
            this.btnThoat5.Size = new System.Drawing.Size(107, 32);
            this.btnThoat5.TabIndex = 40;
            this.btnThoat5.Text = "Thoát";
            this.btnThoat5.Click += new System.EventHandler(this.btnThoat5_Click);
            // 
            // btnXuatTungKhu
            // 
            this.btnXuatTungKhu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatTungKhu.ImageOptions.Image")));
            this.btnXuatTungKhu.Location = new System.Drawing.Point(61, 80);
            this.btnXuatTungKhu.Name = "btnXuatTungKhu";
            this.btnXuatTungKhu.Size = new System.Drawing.Size(107, 32);
            this.btnXuatTungKhu.TabIndex = 39;
            this.btnXuatTungKhu.Text = "Xuất báo cáo";
            this.btnXuatTungKhu.Click += new System.EventHandler(this.btnXuatTungKhu_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(283, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(543, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "DANH SÁCH NHÂN KHẨU TỪNG BLOCK";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.btnThoat4);
            this.tabPage5.Controls.Add(this.btnXuatBC4);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.rpvTCNK);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1107, 495);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tất cả nhân khẩu";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnThoat4
            // 
            this.btnThoat4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat4.ImageOptions.Image")));
            this.btnThoat4.Location = new System.Drawing.Point(945, 40);
            this.btnThoat4.Name = "btnThoat4";
            this.btnThoat4.Size = new System.Drawing.Size(107, 32);
            this.btnThoat4.TabIndex = 37;
            this.btnThoat4.Text = "Thoát";
            this.btnThoat4.Click += new System.EventHandler(this.btnThoat4_Click);
            // 
            // btnXuatBC4
            // 
            this.btnXuatBC4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatBC4.ImageOptions.Image")));
            this.btnXuatBC4.Location = new System.Drawing.Point(56, 40);
            this.btnXuatBC4.Name = "btnXuatBC4";
            this.btnXuatBC4.Size = new System.Drawing.Size(107, 32);
            this.btnXuatBC4.TabIndex = 36;
            this.btnXuatBC4.Text = "Xuất báo cáo";
            this.btnXuatBC4.Click += new System.EventHandler(this.btnXuatBC4_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(226, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(635, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "DANH SÁCH TẤT CẢ NHÂN KHẨU TRONG KHU";
            // 
            // rpvTCNK
            // 
            this.rpvTCNK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource5.Name = "DataSetTCNK";
            reportDataSource5.Value = this.NHANKHAUBindingSource;
            this.rpvTCNK.LocalReport.DataSources.Add(reportDataSource5);
            this.rpvTCNK.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptTCNK.rdlc";
            this.rpvTCNK.Location = new System.Drawing.Point(2, 113);
            this.rpvTCNK.Name = "rpvTCNK";
            this.rpvTCNK.ServerReport.BearerToken = null;
            this.rpvTCNK.Size = new System.Drawing.Size(1104, 385);
            this.rpvTCNK.TabIndex = 0;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // NHANKHAUTableAdapter
            // 
            this.NHANKHAUTableAdapter.ClearBeforeFill = true;
            // 
            // cANHOTableAdapter1
            // 
            this.cANHOTableAdapter1.ClearBeforeFill = true;
            // 
            // CANHOTableAdapter
            // 
            this.CANHOTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1116, 526);
            this.Controls.Add(this.tabControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmBaoCao.IconOptions.LargeImage")));
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO THỐNG KÊ";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHDBbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCHDaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CANHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCHChuaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANKHAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTCNK)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXuatDSNV;
        private DevExpress.XtraEditors.SimpleButton btnThoat1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvNV;
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private dtsNhanVien dtsNhanVien;
        private dtsNhanVienTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnThoat2;
        private DevExpress.XtraEditors.SimpleButton btnXuatCHCB;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvCHCB;
        private System.Windows.Forms.BindingSource CANHOBindingSource;
        private dtsCHChuaBan dtsCHChuaBan;
        private dtsCHChuaBanTableAdapters.CANHOTableAdapter CANHOTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnThoat3;
        private DevExpress.XtraEditors.SimpleButton btnXuatCHDB;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer rpvCHDB;
        private dtsCHDaBan dtsCHDaBan;
        private System.Windows.Forms.BindingSource CHDBbindingSource;
        private dtsCHDaBanTableAdapters.CANHOTableAdapter cANHOTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTCNK;
        private System.Windows.Forms.BindingSource NHANKHAUBindingSource;
        private dtsTCNK dtsTCNK;
        private dtsTCNKTableAdapters.NHANKHAUTableAdapter NHANKHAUTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnThoat4;
        private DevExpress.XtraEditors.SimpleButton btnXuatBC4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBL;
        private DevExpress.XtraEditors.SimpleButton btnThoat5;
        private DevExpress.XtraEditors.SimpleButton btnXuatTungKhu;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer rpvNKTK;
    }
}