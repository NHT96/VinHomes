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
    public partial class frmTaoTK : DevExpress.XtraEditors.XtraForm
    {
        DBVinHomes context = new DBVinHomes();
        Database db;
        List<NHANVIEN> listNV;
        List<TAIKHOAN> listTK;
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void FillMnvCbo()
        {
            db = new Database();
            DataTable dt = db.Execute("SELECT distinct n.MANV FROM TAIKHOAN t, NHANVIEN n WHERE n.MANV not in (SELECT MANV FROM TAIKHOAN)");
            cboMNV.DataSource = dt;
            cboMNV.DisplayMember = "MANV";
            cboMNV.ValueMember = "MANV";
        }
        private void frmTaoTK_Load(object sender, EventArgs e)
        {
            FillMnvCbo();
        }

        private void btnXN_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.txtID.Text.Trim() == "" || this.txtPass.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!");
                    return;
                }

                if (this.txtID.Text.Length != 10)
                {
                    MessageBox.Show("Phải nhập đủ 10 ký tự cho ID đăng nhập!");
                    return;
                }
                if (this.txtPass.Text.Length < 6 || this.txtPass.Text.Length >15)
                {
                    MessageBox.Show("Mật khẩu phải có đồ dài từ 6-15 ký tự!");
                    return;
                }

                TAIKHOAN findTK = context.TAIKHOANs.FirstOrDefault(p => p.ID == txtID.Text);
                if (findTK != null)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng nhập ID khác!", "Thông báo!");
                    return;
                }

                if (findTK == null)
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.ID = txtID.Text;
                    tk.PASS = txtID.Text;
                    tk.MANV = cboMNV.Text;
                    context.TAIKHOANs.Add(tk);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                    txtID.Text = "";
                    txtPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDongCT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDY_Click(object sender, EventArgs e)
        {
            if (this.txtIDx.Text.Trim() == "" || this.txtMNVx.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản cần xóa!");
                return;
            }

            if (this.txtIDx.Text.Length != 10 && this.txtMNVx.Text.Length != 10)
            {
                MessageBox.Show("Phải nhập đủ 10 ký tự cho mã nhân viên!");
                return;
            }
            TAIKHOAN findTK = context.TAIKHOANs.FirstOrDefault(p => p.ID == txtIDx.Text && p.MANV == txtMNVx.Text);
            if(txtMNVx.Text == frmDN.scrID)
            {
                MessageBox.Show("Tài khoản này hiện tại đang sử dụng. Vui lòng thử lại sau!", "Thông báo!");
                return;
            }
            if (findTK == null)
            {
                MessageBox.Show("Tài khoản này không tồn tại!", "Thông báo!");
                return;
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    context.TAIKHOANs.Remove(findTK);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!");
                    txtIDx.Text = "";
                    txtMNVx.Text = "";
                }
            }
        }
    }
}