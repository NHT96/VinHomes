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
    public partial class frmDVC : Form
    {
        private Database db;
        public string MDVC { get; set; }
        public frmDVC()
        {
            InitializeComponent();
        }

        private void frmDVC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsDVC.CTHDDVC' table. You can move, or remove it, as needed.
            this.CTHDDVCTableAdapter.Fill(this.dtsDVC.CTHDDVC);
            db = new Database();
            DataTable dt = db.Execute("select TOP 1  c.MACH, c.PHIANNINH,c.PHIMOITRUONG, c.PHIGIUXE, c.THANHTIEN from DICHVUCONG d, CTHDDVC c where c.MAHDDVC = '"+MDVC+"' and d.MAHDDVC = c.MAHDDVC ORDER BY MACH desc");
            List<CTHDDVC> HDList = new List<CTHDDVC>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTHDDVC dvc = new CTHDDVC();
                dvc.MACH = dt.Rows[i][0].ToString();
                dvc.PHIANNINH = Convert.ToDecimal(dt.Rows[i][1].ToString());
                dvc.PHIMOITRUONG = Convert.ToDecimal(dt.Rows[i][2].ToString());
                dvc.PHIGIUXE = Convert.ToDecimal(dt.Rows[i][3].ToString());
                dvc.THANHTIEN = Convert.ToDecimal(dt.Rows[i][4].ToString());
                HDList.Add(dvc);
            }
            var reportDataSource = new ReportDataSource("DataSetDVC", HDList);
            this.rpvDVC.LocalReport.DataSources.Clear();
            this.rpvDVC.LocalReport.DataSources.Add(reportDataSource);
            this.rpvDVC.RefreshReport();
            this.rpvDVC.RefreshReport();
        }
    }
}
