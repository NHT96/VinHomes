namespace CHUNGCUVINHOME
{
    partial class frmHDD
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
            this.CTHDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsHDD = new CHUNGCUVINHOME.dtsHDD();
            this.rpvHDD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CTHDDTableAdapter = new CHUNGCUVINHOME.dtsHDDTableAdapters.CTHDDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDD)).BeginInit();
            this.SuspendLayout();
            // 
            // CTHDDBindingSource
            // 
            this.CTHDDBindingSource.DataMember = "CTHDD";
            this.CTHDDBindingSource.DataSource = this.dtsHDD;
            // 
            // dtsHDD
            // 
            this.dtsHDD.DataSetName = "dtsHDD";
            this.dtsHDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvHDD
            // 
            this.rpvHDD.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsHDD";
            reportDataSource1.Value = this.CTHDDBindingSource;
            this.rpvHDD.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHDD.LocalReport.ReportEmbeddedResource = "CHUNGCUVINHOME.rptHDD.rdlc";
            this.rpvHDD.Location = new System.Drawing.Point(0, 0);
            this.rpvHDD.Margin = new System.Windows.Forms.Padding(5);
            this.rpvHDD.Name = "rpvHDD";
            this.rpvHDD.ServerReport.BearerToken = null;
            this.rpvHDD.Size = new System.Drawing.Size(496, 240);
            this.rpvHDD.TabIndex = 0;
            // 
            // CTHDDTableAdapter
            // 
            this.CTHDDTableAdapter.ClearBeforeFill = true;
            // 
            // frmHDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 240);
            this.Controls.Add(this.rpvHDD);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHDD";
            this.Text = "CHI TIẾT HÓA ĐƠN ĐIỆN";
            this.Load += new System.EventHandler(this.frmHDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsHDD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHDD;
        private System.Windows.Forms.BindingSource CTHDDBindingSource;
        private dtsHDD dtsHDD;
        private dtsHDDTableAdapters.CTHDDTableAdapter CTHDDTableAdapter;
    }
}