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
    public partial class frmNHANVIEN : DevExpress.XtraEditors.XtraForm
    {
        DBVinHomes context = new DBVinHomes();
        List<NHANVIEN> listNV;
        private Database db;

        void setButton(bool a)
        {
            btnThem.Enabled = a;
            btnXoa.Enabled = a;
            btnSua.Enabled = a;
            btnThoat.Enabled = a;
            btnLuu.Enabled = !a;
            btnKluu.Enabled = !a;
        }

        void setKhoa(bool a)
        {
            txtMANV.ReadOnly = a;
            txtHT.ReadOnly = a;
            txtMail.ReadOnly = a;
        }

        void setNull()
        {
            txtMANV.Text = "";
            txtHT.Text = "";
            txtMail.Text = "";
        }
        private void BindGrid(List<NHANVIEN> listNV)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNV)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MANV;
                dgvNhanVien.Rows[index].Cells[1].Value = item.HOTENNV;
                DateTime tmp = (DateTime)item.NS;
                String dateInString = tmp.ToString("dd/MM/yyyy");
                dgvNhanVien.Rows[index].Cells[2].Value = dateInString;
                dgvNhanVien.Rows[index].Cells[3].Value = item.PHAI;
                dgvNhanVien.Rows[index].Cells[4].Value = item.CHUCVU;
                dgvNhanVien.Rows[index].Cells[5].Value = item.MAIL;
            }
        }
        public frmNHANVIEN()
        {
            InitializeComponent();
        }

        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            
            setButton(true);
            setKhoa(true);
            setNull();
            try
            {
                listNV = context.NHANVIENs.ToList();
                BindGrid(listNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            db = new Database();
            DataTable dt = db.Execute("SELECT CHUCVU from TAIKHOAN t, NHANVIEN n where t.MANV=n.MANV and t.MANV ='" + frmDN.scrID + "'");
            DataRow dtr = dt.Rows[0];
            if (dtr[0].ToString() == "Phó giám đốc"||dtr[0].ToString() == "Giám đốc"||dtr[0].ToString() == "Quản lý")
            {
                btnTaoTK.Enabled = true;
            }
            else
            {
                btnTaoTK.Enabled = false;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    txtMANV.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                    txtHT.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                    DateTime ns = DateTime.ParseExact(dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNTNS.Text = ns.ToShortDateString();
                    cboPhai.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
                    cboChucVu.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
                    txtMail.Text = dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            txtMANV.Focus();
            setNull();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            txtMANV.Focus();
            txtMANV.ReadOnly = true;
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMANV.Text.Trim() == "" || this.txtHT.Text.Trim() == "" || this.txtMail.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
                    return;
                }
                    
                if (this.txtMANV.Text.Length != 10)
                {
                    MessageBox.Show("Phải nhập đủ 10 ký tự cho mã nhân viên!");
                    return;
                }
                    
                NHANVIEN findNV = context.NHANVIENs.FirstOrDefault(p => p.MANV == txtMANV.Text);
                if (findNV == null)
                {
                    findNV = new NHANVIEN();
                    findNV.MANV = txtMANV.Text;
                    findNV.HOTENNV = txtHT.Text;
                    findNV.NS = dtpNTNS.Value;
                    findNV.PHAI = cboPhai.SelectedItem.ToString();
                    findNV.CHUCVU = cboChucVu.SelectedItem.ToString();
                    findNV.MAIL = txtMail.Text;
                    context.NHANVIENs.Add(findNV);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                    setButton(true);
                    setKhoa(true);
                    setNull();
                }
                else
                {
                    findNV.HOTENNV = txtHT.Text;
                    DateTime ns = Convert.ToDateTime(dtpNTNS.Value.ToString("yyyy-MM-dd"));
                    findNV.NS = ns;
                    findNV.PHAI = cboPhai.SelectedItem.ToString();
                    findNV.CHUCVU = cboChucVu.SelectedItem.ToString();
                    findNV.MAIL = txtMail.Text;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    setButton(true);
                    setKhoa(true);
                    setNull();
                }

                BindGrid(context.NHANVIENs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NHANVIEN findNV = context.NHANVIENs.FirstOrDefault(p => p.MANV == txtMANV.Text);
            NHANVIEN dbDelete = context.NHANVIENs.FirstOrDefault(p => p.MANV == txtMANV.Text);
            TAIKHOAN findTK = context.TAIKHOANs.FirstOrDefault(p => p.MANV == txtMANV.Text);
            if (findNV == null)
            {
                MessageBox.Show("Không tìm thấy đối tượng cần xóa");
            }
            else
            {
                if (findTK == null)
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.NHANVIENs.Remove(findNV);
                        context.SaveChanges();
                        BindGrid(context.NHANVIENs.ToList());
                        MessageBox.Show("Xóa Thành Công!");
                        setButton(true);
                        setKhoa(true);
                        setNull();
                    }
                    if (dbDelete != null)
                    {
                        dgvNhanVien.Rows.Clear();
                        BindGrid(context.NHANVIENs.ToList());
                    }
                }
                else
                    MessageBox.Show("Nhân viên này có tài khoản đăng nhập. Nếu chắc chắn muốn xóa? Vui lòng xóa tài khoản nhân viên trước!", "Thông báo!");
            }
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new Database();
            DataTable dt = db.Execute("SELECT CHUCVU from TAIKHOAN t, NHANVIEN n where t.MANV=n.MANV and t.MANV ='" + frmDN.scrID + "'");
            DataRow dtr = dt.Rows[0];
            if (dtr[0].ToString() == "Quản lý")
            {
                if (cboChucVu.SelectedIndex == 0 || cboChucVu.SelectedIndex == 2 || cboChucVu.SelectedIndex == 3)
                {
                    cboChucVu.SelectedIndex = -1;
                    MessageBox.Show("Không có quyền thêm chức vụ này! Vui lòng chọn chức vụ thấp hơn!", "Thông báo!");
                }
            }

            if (dtr[0].ToString() == "Giám đốc")
            {
                if (cboChucVu.SelectedIndex == 2)
                {
                    cboChucVu.SelectedIndex = -1;
                    MessageBox.Show("Không có quyền thêm chức vụ này! Vui lòng chọn chức vụ thấp hơn!", "Thông báo!");
                }
            }

            if (dtr[0].ToString() == "Phó giám đốc")
            {
                if (cboChucVu.SelectedIndex == 2 || cboChucVu.SelectedIndex == 3)
                {
                    cboChucVu.SelectedIndex = -1;
                    MessageBox.Show("Không có quyền thêm chức vụ này! Vui lòng chọn chức vụ thấp hơn!", "Thông báo!");
                }
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmTaoTK frmTaoTK = new frmTaoTK();
            frmTaoTK.Show();
        }

        private void dtpNTNS_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            int tuoi = now.Year - dtpNTNS.Value.Year;
            if (tuoi < 18)
                MessageBox.Show("Người này chưa đủ tuổi để trở thành nhân viên. Vui lòng chọn lại!");
        }
    }
}