namespace CHUNGCUVINHOME
{
    partial class frmHDN
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtsHDN = new CHUNGCUVINHOME.dtsHDN();
            this.dtsHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CTHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CTHDNTableAdapter = new CHUNGCUVINHOME.dtsHDNTableAdapters.CTHDNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsHDN
            // 
            this.dtsHDN.DataSetName = "dtsHDN";
            this.dtsHDN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtsHDNBindingSource
            // 
            this.dtsHDNBindingSource.DataSource = this.dtsHDN;
            this.dtsHDNBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHDN";
            reportDataSource1.Value = this.CTHDNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptHDN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(482, 293);
            this.reportViewer1.TabIndex = 0;
            // 
            // CTHDNBindingSource
            // 
            this.CTHDNBindingSource.DataMember = "CTHDN";
            this.CTHDNBindingSource.DataSource = this.dtsHDN;
            // 
            // CTHDNTableAdapter
            // 
            this.CTHDNTableAdapter.ClearBeforeFill = true;
            // 
            // frmHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 293);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmHDN";
            this.Text = "QUẢN LÝ SỬ DỤNG NƯỚC";
            this.Load += new System.EventHandler(this.frmHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtsHDNBindingSource;
        private dtsHDN dtsHDN;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CTHDNBindingSource;
        private dtsHDNTableAdapters.CTHDNTableAdapter CTHDNTableAdapter;
    }
}