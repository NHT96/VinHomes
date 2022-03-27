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
    public partial class frmHDD : Form
    {
        private Database db;
        public string MHDD { get; set; }

        public frmHDD()
        {
            InitializeComponent();
        }

        private void frmHDD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsHDD.CTHDD' table. You can move, or remove it, as needed.
            this.CTHDDTableAdapter.Fill(this.dtsHDD.CTHDD);
            db = new Database();
            DataTable dt = db.Execute("select TOP 1 c.MACH, c.MAHDDIEN, q.NGAYKT,q.CHISODIEN, c.TONGLDTT,c.DONGIADIEN, c.THANHTIEN from QLDIEN q, CTHDD c where c.MAHDDIEN = '"+ MHDD +"' and q.MAHDDIEN = c.MAHDDIEN ORDER BY CHISODIEN desc");
            List<CTHDD> HDList = new List<CTHDD>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTHDD hdd = new CTHDD();
                hdd.MACH = dt.Rows[i][0].ToString();
                hdd.MAHDDIEN = dt.Rows[i][1].ToString();
                hdd.TONGLDTT = Convert.ToInt32(dt.Rows[i][4].ToString());
                hdd.DONGIADIEN = Convert.ToDecimal(dt.Rows[i][5].ToString());
                hdd.THANHTIEN = Convert.ToDecimal(dt.Rows[i][6].ToString());
                HDList.Add(hdd);
            }
            var reportDataSource = new ReportDataSource("dtsHDD", HDList);
            this.rpvHDD.LocalReport.DataSources.Clear();
            this.rpvHDD.LocalReport.DataSources.Add(reportDataSource);
            this.rpvHDD.RefreshReport();
        }
    }
}
