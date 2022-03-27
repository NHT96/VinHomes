using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
using Microsoft.Reporting.WinForms;
using CHUNGCUVINHOME.Data;

namespace CHUNGCUVINHOME
{
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        Database db;
        DBVinHomes context = new DBVinHomes();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void setVSFalse()
        {
            rpvNKTK.Visible = false;
            rpvTCNK.Visible = false;
            rpvCHDB.Visible = false;
            rpvCHCB.Visible = false;
            rpvNV.Visible = false;
        }
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsTCNK.NHANKHAU' table. You can move, or remove it, as needed.
            NHANKHAUTableAdapter.Fill(this.dtsTCNK.NHANKHAU);

            // TODO: This line of code loads data into the 'dtsCHDaBan.CANHO' table. You can move, or remove it, as needed.
            cANHOTableAdapter1.Fill1(this.dtsCHDaBan.CANHO);
            setVSFalse();
            // TODO: This line of code loads data into the 'dtsCHChuaBan.CANHO' table. You can move, or remove it, as needed.
            CANHOTableAdapter.Fill(this.dtsCHChuaBan.CANHO);

            // TODO: This line of code loads data into the 'dtsNhanVien.NHANVIEN' table. You can move, or remove it, as needed.
            NHANVIENTableAdapter.Fill(this.dtsNhanVien.NHANVIEN);

            this.rpvNV.RefreshReport();
            this.rpvCHCB.RefreshReport();
            this.rpvCHDB.RefreshReport();
            this.rpvTCNK.RefreshReport();
            this.rpvNKTK.RefreshReport();
        }


        private void btnXuatDSNV_Click(object sender, EventArgs e)
        {
            rpvNV.Visible = true;
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuatCHCB_Click(object sender, EventArgs e)
        {
            rpvCHCB.Visible = true;
        }

        private void btnThoat3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuatCHDB_Click(object sender, EventArgs e)
        {
            rpvCHDB.Visible = true;
        }

        private void btnThoat4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuatBC4_Click(object sender, EventArgs e)
        {
            rpvTCNK.Visible = true;
        }

        private void btnXuatTungKhu_Click(object sender, EventArgs e)
        {
            string s = cboBL.SelectedItem.ToString().Substring(cboBL.SelectedItem.ToString().Length - 1);
            db = new Database();
            DataTable dt = db.Execute("select MACH, HOTENNK,NTNS, PHAINK, QUEQUAN, SDT from NHANKHAU where MACH like '" + s + "%' order by MACH");
            List<NHANKHAU> NKList = new List<NHANKHAU>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NHANKHAU nk = new NHANKHAU();
                nk.MACH = dt.Rows[i][0].ToString();
                nk.HOTENNK = dt.Rows[i][1].ToString();
                DateTime ns = Convert.ToDateTime(dt.Rows[i][2].ToString());
                nk.NTNS = ns;
                nk.PHAINK = dt.Rows[i][3].ToString();
                nk.QUEQUAN = dt.Rows[i][4].ToString();
                nk.SDT = dt.Rows[i][5].ToString();
                NKList.Add(nk);
            }
            var reportDataSource = new ReportDataSource("DataSetRPTnktk", NKList);
            this.rpvNKTK.LocalReport.DataSources.Clear();
            this.rpvNKTK.LocalReport.DataSources.Add(reportDataSource);
            this.rpvNKTK.RefreshReport();
            rpvNKTK.Visible = true;
        }

        private void btnThoat5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            setVSFalse();
        }
    }
}