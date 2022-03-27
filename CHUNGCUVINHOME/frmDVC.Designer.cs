namespace CHUNGCUVINHOME
{
    partial class frmDVC
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
            this.rpvDVC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsDVC = new CHUNGCUVINHOME.dtsDVC();
            this.CTHDDVCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CTHDDVCTableAdapter = new CHUNGCUVINHOME.dtsDVCTableAdapters.CTHDDVCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDDVCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvDVC
            // 
            this.rpvDVC.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDVC";
            reportDataSource1.Value = this.CTHDDVCBindingSource;
            this.rpvDVC.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDVC.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptDVC.rdlc";
            this.rpvDVC.Location = new System.Drawing.Point(0, 0);
            this.rpvDVC.Name = "rpvDVC";
            this.rpvDVC.ServerReport.BearerToken = null;
            this.rpvDVC.Size = new System.Drawing.Size(511, 301);
            this.rpvDVC.TabIndex = 0;
            // 
            // dtsDVC
            // 
            this.dtsDVC.DataSetName = "dtsDVC";
            this.dtsDVC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CTHDDVCBindingSource
            // 
            this.CTHDDVCBindingSource.DataMember = "CTHDDVC";
            this.CTHDDVCBindingSource.DataSource = this.dtsDVC;
            // 
            // CTHDDVCTableAdapter
            // 
            this.CTHDDVCTableAdapter.ClearBeforeFill = true;
            // 
            // frmDVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 301);
            this.Controls.Add(this.rpvDVC);
            this.Name = "frmDVC";
            this.Text = "BIỂU PHÍ DỊCH VỤ CÔNG";
            this.Load += new System.EventHandler(this.frmDVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsDVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDDVCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDVC;
        private System.Windows.Forms.BindingSource CTHDDVCBindingSource;
        private dtsDVC dtsDVC;
        private dtsDVCTableAdapters.CTHDDVCTableAdapter CTHDDVCTableAdapter;
    }
}