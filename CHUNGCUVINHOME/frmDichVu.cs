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
using CHUNGCUVINHOME.Data;

namespace CHUNGCUVINHOME
{
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        Database db;
        DBVinHomes context = new DBVinHomes();
        List<THAMSO> listTS;
        THAMSO TS;
        QLDIEN qld = new QLDIEN();
        CTHDD ctd = new CTHDD();

        public frmDichVu()
        {
            InitializeComponent();
        }
        private void FillMaCHLKE()
        {
            db = new Database();
            DataTable dt = db.Execute("select MACH from CANHO where TRANGTHAI = 1");
            lkeMCH.Properties.DataSource = dt;
            lkeMCH.Properties.DisplayMember = "MACH";
            lkeMCH.Properties.ValueMember = "MACH";
        }

        private void HienCTD(List<QLDIEN> listHDD)
        {
            dgvTD.Rows.Clear();
            foreach (var item in listHDD)
            {
                int index = dgvTD.Rows.Add();
                dgvTD.Rows[index].Cells[0].Value = item.MAHDDIEN;
                DateTime tmp = (DateTime)item.NGAYKT;
                String dateInString = tmp.ToString("MM/yyyy");
                dgvTD.Rows[index].Cells[1].Value = dateInString;
                dgvTD.Rows[index].Cells[2].Value = item.CHISODIEN;
            }
        }

        private void LoadHDD()
        {
            db = new Database();
            DataTable dt = db.Execute("select c.MAHDDIEN, q.NGAYKT, q.CHISODIEN from CTHDD c, QLDIEN q where c.MACH = '" + lkeMCH.Text + "' and c.MAHDDIEN = q.MAHDDIEN");
            List<QLDIEN> HDDList = new List<QLDIEN>();
            for (int i = 0; i < dt.Rows.Count; i++) // chuyển dữ liệu từ datatable thành list
            {
                QLDIEN hdd = new QLDIEN();
                hdd.MAHDDIEN = dt.Rows[i][0].ToString();
                DateTime nkt = Convert.ToDateTime(dt.Rows[i][1].ToString());
                hdd.NGAYKT = nkt;
                hdd.CHISODIEN = Convert.ToDouble(dt.Rows[i][2].ToString());
                HDDList.Add(hdd);
            }
            HienCTD(HDDList);
        }

        private void HienCTN(List<QLNUOC> listHDN)
        {
            dgvTN.Rows.Clear();
            foreach (var item in listHDN)
            {
                int index = dgvTN.Rows.Add();
                dgvTN.Rows[index].Cells[0].Value = item.MAHDNUOC;
                DateTime tmp = (DateTime)item.NGAYCHOT;
                String dateInString = tmp.ToString("MM/yyyy");
                dgvTN.Rows[index].Cells[1].Value = dateInString;
                dgvTN.Rows[index].Cells[2].Value = item.CHISONUOC;
            }
        }

        private void LoadHDN()
        {
            db = new Database();
            DataTable dt = db.Execute("select c.MAHDNUOC, q.NGAYCHOT, q.CHISONUOC from CTHDN c, QLNUOC q where c.MACH = '" + lkeMCH.Text + "'and c.MAHDNUOC = q.MAHDNUOC");
            List<QLNUOC> HDNList = new List<QLNUOC>();
            for (int i = 0; i < dt.Rows.Count; i++) // chuyển dữ liệu từ datatable thành list
            {
                QLNUOC hdn = new QLNUOC();
                hdn.MAHDNUOC = dt.Rows[i][0].ToString();
                DateTime nkt = Convert.ToDateTime(dt.Rows[i][1].ToString());
                hdn.NGAYCHOT = nkt;
                hdn.CHISONUOC = Convert.ToDouble(dt.Rows[i][2].ToString());
                HDNList.Add(hdn);
            }
            HienCTN(HDNList);
        }

        private void HienDVC(List<DICHVUCONG> listDVC)
        {
            dgvDVC.Rows.Clear();
            foreach (var item in listDVC)
            {
                int index = dgvDVC.Rows.Add();
                dgvDVC.Rows[index].Cells[0].Value = item.MAHDDVC;
                DateTime tmp = (DateTime)item.NGAYTB;
                String dateInString = tmp.ToString("MM/yyyy");
                dgvDVC.Rows[index].Cells[1].Value = dateInString;
            }
        }

        private void LoadDVC()
        {
            db = new Database();
            DataTable dt = db.Execute("select d.MAHDDVC, d.NGAYTB from DICHVUCONG d, CTHDDVC c where MACH = '" + lkeMCH.Text + "' and c.MAHDDVC = d.MAHDDVC");
            List<DICHVUCONG> DVCList = new List<DICHVUCONG>();
            for (int i = 0; i < dt.Rows.Count; i++) // chuyển dữ liệu từ datatable thành list
            {
                DICHVUCONG dvc = new DICHVUCONG();
                dvc.MAHDDVC = dt.Rows[i][0].ToString();
                DateTime nkt = Convert.ToDateTime(dt.Rows[i][1].ToString());
                dvc.NGAYTB = nkt;
                DVCList.Add(dvc);
            }
            HienDVC(DVCList);
        }

        private void btnThoat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setDG(bool a)
        {
            btnSuaDGN.Enabled = a;
            btnSuaDGDVC.Enabled = a;
            btnDoiDGD.Enabled = a;
        }
        private void SETSHD()
        {
            db = new Database();
            DataTable dtD = db.Execute("SELECT TOP 1 MAHDDIEN FROM QLDIEN ORDER BY MAHDDIEN DESC");
            string hdd = (dtD.Rows[0][0].ToString()).Substring(dtD.Rows[0][0].ToString().Length - 7);
            txtSoHDD.Text = ("D" + (Convert.ToInt32(hdd) + 1)).ToString();

            DataTable dtN = db.Execute("SELECT TOP 1 MAHDNUOC FROM QLNUOC ORDER BY MAHDNUOC DESC");
            string hdn = (dtN.Rows[0][0].ToString()).Substring(dtN.Rows[0][0].ToString().Length - 7);
            txtSoHDN.Text = ("N" + (Convert.ToInt32(hdn) + 1)).ToString();

            DataTable dtDVC = db.Execute("SELECT TOP 1 MAHDDVC FROM DICHVUCONG ORDER BY MAHDDVC DESC");
            string hdDVC = (dtDVC.Rows[0][0].ToString()).Substring(dtDVC.Rows[0][0].ToString().Length - 7);
            txtSoHDDVC.Text = ("C" + (Convert.ToInt32(hdDVC) + 1)).ToString();
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            db = new Database();
            DataTable dtCV = db.Execute("SELECT CHUCVU from TAIKHOAN t, NHANVIEN n where t.MANV=n.MANV and t.MANV ='" + frmDN.scrID + "'");
            DataRow dtr = dtCV.Rows[0];
            if (dtr[0].ToString() == "Phó giám đốc" || dtr[0].ToString() == "Giám đốc" || dtr[0].ToString() == "Quản lý")
            {
                setDG(true);
            }
            else
                setDG(false);
            btnXNDGD.Visible = false;
            btnXNDGN.Visible = false;
            btnXNdgDVC.Visible = false;
            FillMaCHLKE();
            DataTable dt = db.Execute("select * from THAMSO");
            txtDGD.Text = dt.Rows[1][2].ToString();
            txtDGN.Text = dt.Rows[3][2].ToString();
            txtPAN.Text = dt.Rows[0][2].ToString();
            txtPMT.Text = dt.Rows[4][2].ToString();
            txtPGX.Text = dt.Rows[2][2].ToString();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            SETSHD();
            LoadHDD();
            LoadHDN();
            LoadDVC();
        }

        private void txtTD_TextChanged(object sender, EventArgs e)
        {
            txtTD.Text = (Convert.ToDouble(txtDGD.Text) * Convert.ToDouble(txtLDTT.Text)).ToString();
        }

        private void dgvTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTD.SelectedRows.Count > 0)
                {
                    txtSoHDD.Text = dgvTD.SelectedRows[0].Cells[0].Value.ToString();
                    dtpNTTD.Text = dgvTD.SelectedRows[0].Cells[1].Value.ToString();
                    txtCSD.Text = dgvTD.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTN.SelectedRows.Count > 0)
                {
                    txtSoHDN.Text = dgvTN.SelectedRows[0].Cells[0].Value.ToString();
                    dtpNTTN.Text = dgvTN.SelectedRows[0].Cells[1].Value.ToString();
                    txtCSN.Text = dgvTN.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDVC.SelectedRows.Count > 0)
                {
                    txtSoHDDVC.Text = dgvDVC.SelectedRows[0].Cells[0].Value.ToString();
                    dtpNTTDVC.Text = dgvDVC.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDoiDGD_Click(object sender, EventArgs e)
        {
            txtDGD.ReadOnly = false;
            btnXNDGD.Visible = true;
        }

        private void btnXNDGD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa đơn giá?", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TS = new THAMSO();
                TS.CapNhatDGD(Convert.ToDouble(txtDGD.Text));
                MessageBox.Show("Cập nhật đơn giá điện thành công!", "Thông báo!");
                txtDGD.ReadOnly = true;
                btnXNDGD.Visible = false;
            }
        }

        private void txtCSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDGD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnXNDGN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa đơn giá?", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TS = new THAMSO();
                TS.CapNhatDGN(Convert.ToDouble(txtDGN.Text));
                MessageBox.Show("Cập nhật đơn giá nước thành công!", "Thông báo!");
                txtDGN.ReadOnly = true;
                btnXNDGN.Visible = false;
            }
        }

        private void btnSuaDGN_Click(object sender, EventArgs e)
        {
            txtDGN.ReadOnly = false;
            btnXNDGN.Visible = true;
        }

        private void txtPAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPGX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSuaDGDVC_Click(object sender, EventArgs e)
        {
            txtPAN.ReadOnly = false;
            txtPGX.ReadOnly = false;
            txtPMT.ReadOnly = false;
            btnXNdgDVC.Visible = true;
        }

        private void btnXNdgDVC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa đơn giá?", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TS = new THAMSO();
                TS.CapNhatDGDVC(Convert.ToDouble(txtPAN.Text), Convert.ToDouble(txtPMT.Text), Convert.ToDouble(txtPGX.Text));
                MessageBox.Show("Cập nhật đơn giá dịch vụ công thành công!", "Thông báo!");
                txtPAN.ReadOnly = true;
                txtPGX.ReadOnly = true;
                txtPMT.ReadOnly = true;
                btnXNdgDVC.Visible = false;
            }
        }

        private void btnThemD_Click(object sender, EventArgs e)
        {
            SETSHD();
            dtpNTTD.Text = DateTime.Now.ToShortDateString();
            txtCSD.Text = "";
        }

        private void btnThemN_Click(object sender, EventArgs e)
        {
            SETSHD();
            dtpNTTN.Text = DateTime.Now.ToShortDateString();
            txtCSN.Text = "";
        }

        private void btnThemDVC_Click(object sender, EventArgs e)
        {
            SETSHD();
            dtpNTTDVC.Text = DateTime.Now.ToShortDateString();
        }
        
        private void cbPAN_CheckedChanged(object sender, EventArgs e)
        {
            double tt = Convert.ToDouble(txtTDVC.Text);
            if (cbPAN.Checked == true)
                tt = tt + Convert.ToDouble(txtPAN.Text);
            else
                tt = tt - Convert.ToDouble(txtPAN.Text);
            txtTDVC.Text = tt.ToString();
        }

        private void cbPMT_CheckedChanged(object sender, EventArgs e)
        {
            double tt = Convert.ToDouble(txtTDVC.Text);
            if (cbPMT.Checked == true)
                tt = tt + Convert.ToDouble(txtPMT.Text);
            else
                tt = tt - Convert.ToDouble(txtPMT.Text);
            txtTDVC.Text = tt.ToString();
        }

        private void cbPGX_CheckedChanged(object sender, EventArgs e)
        {
            double tt = Convert.ToDouble(txtTDVC.Text);
            if (cbPGX.Checked == true)
                tt = tt + Convert.ToDouble(txtPGX.Text);
            else
                tt = tt - Convert.ToDouble(txtPGX.Text);
            txtTDVC.Text = tt.ToString();
        }

        private void txtLDTT_TextChanged(object sender, EventArgs e)
        {
            txtTD.Text = (Convert.ToDouble(txtDGD.Text) * Convert.ToDouble(txtLDTT.Text)).ToString();
        }

        private void txtCSD_TextChanged(object sender, EventArgs e)
        {
            try {
                DataTable dtDtl = db.Execute("SELECT TOP 2 c.MAHDDIEN, q.CHISODIEN FROM QLDIEN q, CTHDD c where q.MAHDDIEN = c.MAHDDIEN and c.MACH = '" + lkeMCH.Text + "' ORDER BY MAHDDIEN desc");
                if(dtDtl.Rows.Count >1)
                {
                    int tlcsd = Convert.ToInt32(txtCSD.Text) - Convert.ToInt32(dtDtl.Rows[1][1].ToString());
                    txtLDTT.Text = tlcsd.ToString();
                }
                else
                {
                    int tlcsd = Convert.ToInt32(txtCSD.Text) - 0;
                    txtLDTT.Text = tlcsd.ToString();
                }
                    
            }
            catch { }
        }

        private void txtLNTT_TextChanged(object sender, EventArgs e)
        {
            txtTN.Text = (Convert.ToDouble(txtDGN.Text) * Convert.ToDouble(txtLNTT.Text)).ToString();
        }

        private void txtCSN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCSN = db.Execute("select TOP 2 c.MAHDNUOC, q.CHISONUOC from QLNUOC q, CTHDN c where q.MAHDNUOC = c.MAHDNUOC and c.MACH = '" + lkeMCH.Text + "' ORDER BY MAHDNUOC desc");
                if (dtCSN.Rows.Count > 1)
                {
                    int tlcsn = Convert.ToInt32(txtCSN.Text) - Convert.ToInt32(dtCSN.Rows[1][1].ToString());
                    txtLNTT.Text = tlcsn.ToString();
                }
                else
                {
                    int tlcsn = Convert.ToInt32(txtCSN.Text) - 0;
                    txtLNTT.Text = tlcsn.ToString();
                }
            }
            catch { }
        }

        private void btnCapNhatD_Click(object sender, EventArgs e)
        {
            db = new Database();
            DataTable dtD = db.Execute("SELECT TOP 1 MAHDDIEN FROM QLDIEN ORDER BY MAHDDIEN DESC");
            string hdd = (dtD.Rows[0][0].ToString()).Substring(dtD.Rows[0][0].ToString().Length - 7);
            string mahdd = ("D" + (Convert.ToInt32(hdd) + 1)).ToString();
            try
            {
                QLDIEN findD = context.QLDIENs.FirstOrDefault(p => p.MAHDDIEN == mahdd);
                CTHDD findCTHDD = context.CTHDDs.FirstOrDefault(p => p.MAHDDIEN == mahdd && p.MACH == lkeMCH.Text);
                if (findD == null && findCTHDD == null)
                {
                    findD = new QLDIEN();
                    findCTHDD = new CTHDD();
                    findD.MAHDDIEN = txtSoHDD.Text;
                    findD.NGAYKT = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    findD.CHISODIEN = float.Parse(txtCSD.Text);
                    findD.MANV = frmDN.scrID;
                    findCTHDD.MACH = lkeMCH.Text;
                    findCTHDD.MAHDDIEN = txtSoHDD.Text;
                    findCTHDD.DONGIADIEN = Convert.ToDecimal(txtDGD.Text);
                    findCTHDD.TONGLDTT = Convert.ToInt32(txtLDTT.Text);
                    findCTHDD.THANHTIEN = Convert.ToDecimal(txtTD.Text);
                    context.QLDIENs.Add(findD);
                    context.CTHDDs.Add(findCTHDD);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Hóa Đơn Thành Công!", "Thông Báo");
                }
                LoadHDD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInHDD_Click(object sender, EventArgs e)
        {
            frmHDD frmHDD = new frmHDD();
            frmHDD.MHDD = txtSoHDD.Text;
            frmHDD.Show();
            
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            frmHDN frmHDN = new frmHDN();
            frmHDN.MHD = txtSoHDN.Text;
            frmHDN.Show();
        }

        private void btnCapNhatN_Click(object sender, EventArgs e)
        {
            db = new Database();
            DataTable dtN = db.Execute("SELECT TOP 1 MAHDNUOC FROM QLNUOC ORDER BY MAHDNUOC DESC");
            string hdn = (dtN.Rows[0][0].ToString()).Substring(dtN.Rows[0][0].ToString().Length - 7);
            string mahdn = ("D" + (Convert.ToInt32(hdn) + 1)).ToString();
            try
            {
                QLNUOC findN = context.QLNUOCs.FirstOrDefault(p => p.MAHDNUOC == mahdn);
                CTHDN findCTHDN = context.CTHDNs.FirstOrDefault(p => p.MAHDNUOC == mahdn && p.MACH == lkeMCH.Text);
                if (findN == null && findCTHDN == null)
                {
                    findN = new QLNUOC();
                    findCTHDN = new CTHDN();
                    findN.MAHDNUOC = txtSoHDN.Text;
                    findN.NGAYCHOT = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    findN.CHISONUOC = float.Parse(txtCSN.Text);
                    findN.MANV = frmDN.scrID;
                    findCTHDN.MACH = lkeMCH.Text;
                    findCTHDN.MAHDNUOC = txtSoHDN.Text;
                    findCTHDN.DONGIANUOC = Convert.ToDecimal(txtDGN.Text);
                    findCTHDN.TONGLNTT = Convert.ToInt32(txtLNTT.Text);
                    findCTHDN.THANHTIEN = Convert.ToDecimal(txtTN.Text);
                    context.QLNUOCs.Add(findN);
                    context.CTHDNs.Add(findCTHDN);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Hóa Đơn Thành Công!", "Thông Báo");
                }
                LoadHDN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatDVC_Click(object sender, EventArgs e)
        {
            db = new Database();
            DataTable dtDVC = db.Execute("SELECT TOP 1 MAHDDVC FROM DICHVUCONG ORDER BY MAHDDVC DESC");
            string hdn = (dtDVC.Rows[0][0].ToString()).Substring(dtDVC.Rows[0][0].ToString().Length - 7);
            string mahdDVC = ("D" + (Convert.ToInt32(hdn) + 1)).ToString();
            try
            {
                DICHVUCONG findDVC = context.DICHVUCONGs.FirstOrDefault(p => p.MAHDDVC == mahdDVC);
                CTHDDVC findCTHDDVC = context.CTHDDVCs.FirstOrDefault(p => p.MAHDDVC == mahdDVC && p.MACH == lkeMCH.Text);
                if (findDVC == null && findCTHDDVC == null)
                {
                    findDVC = new DICHVUCONG();
                    findCTHDDVC = new CTHDDVC();
                    findDVC.MAHDDVC = txtSoHDDVC.Text;
                    findDVC.NGAYTB = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    findDVC.MANV = frmDN.scrID;
                    findCTHDDVC.MACH = lkeMCH.Text;
                    findCTHDDVC.MAHDDVC = txtSoHDDVC.Text;
                    if(cbPAN.Checked == true)
                        findCTHDDVC.PHIANNINH = Convert.ToDecimal(txtPAN.Text);
                    else
                        findCTHDDVC.PHIANNINH = 0;
                    if(cbPMT.Checked == true)
                        findCTHDDVC.PHIMOITRUONG = Convert.ToDecimal(txtPMT.Text);
                    else
                        findCTHDDVC.PHIMOITRUONG = 0;
                    if(cbPGX.Checked == true)
                        findCTHDDVC.PHIGIUXE = Convert.ToDecimal(txtPGX.Text);
                    else
                        findCTHDDVC.PHIGIUXE = 0;
                    findCTHDDVC.THANHTIEN = Convert.ToDecimal(txtTDVC.Text);
                    context.DICHVUCONGs.Add(findDVC);
                    context.CTHDDVCs.Add(findCTHDDVC);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Hóa Đơn Thành Công!", "Thông Báo");
                }
                LoadDVC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHDDVC_Click(object sender, EventArgs e)
        {
            frmDVC frmDVC = new frmDVC();
            frmDVC.MDVC = txtSoHDDVC.Text;
            frmDVC.Show();
        }
    }
}