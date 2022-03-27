using CHUNGCUVINHOME.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGCUVINHOME
{
    public partial class frmHDN : Form
    {
        private Database db;

        public frmHDN()
        {
            InitializeComponent();
        }
        public string MHD { get; set; }
        private void frmHDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsHDN.CTHDN' table. You can move, or remove it, as needed.
            this.CTHDNTableAdapter.Fill(this.dtsHDN.CTHDN);
            db = new Database();
            DataTable dt = db.Execute("select TOP 1 c.MACH, q.NGAYCHOT,q.CHISONUOC, c.TONGLNTT,c.DONGIANUOC, c.THANHTIEN from QLNUOC q, CTHDN c where c.MAHDNUOC = '"+MHD+"' and q.MAHDNUOC = c.MAHDNUOC ORDER BY CHISONUOC desc");
            List<CTHDN> HDList = new List<CTHDN>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTHDN hdn = new CTHDN();
                hdn.MACH = dt.Rows[i][0].ToString();
                hdn.MAHDNUOC = dt.Rows[i][1].ToString();
                hdn.TONGLNTT = Convert.ToInt32(dt.Rows[i][3].ToString());
                hdn.DONGIANUOC = Convert.ToDecimal(dt.Rows[i][4].ToString());
                hdn.THANHTIEN = Convert.ToDecimal(dt.Rows[i][5].ToString());
                HDList.Add(hdn);
            }
            var reportDataSource = new ReportDataSource("DataSetHDN", HDList);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
