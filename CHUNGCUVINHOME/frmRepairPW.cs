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
    public partial class frmRepairPW : DevExpress.XtraEditors.XtraForm
    {
        TAIKHOAN tk = new TAIKHOAN();
        Database db;
        public frmRepairPW()
        {
            InitializeComponent();
        }

        private void btnDongCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập ID với 10 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (txtPass.Text.Length < 6 || txtPass.Text.Length >15)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu có độ dài từ 6-15 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (txtNewPass.Text.Length < 6 || txtNewPass.Text.Length >15)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới có độ dài từ 6-15 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (tk.login(txtID.Text, txtPass.Text))
            {
                tk.UpDatePW(txtID.Text,txtPass.Text,txtNewPass.Text);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                txtPass.Text = "";
                txtNewPass.Text = "";
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại chưa chính xác. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);
                txtPass.Text = "";
                txtNewPass.Text = "";
                txtPass.Focus();
            }
        }

        private void frmRepairPW_Load(object sender, EventArgs e)
        {
            txtPass.Focus();
            db = new Database();
            DataTable Id = db.Execute("SELECT ID FROM TAIKHOAN WHERE MANV = '" + frmDN.scrID + "'");
            txtID.Text = Id.Rows[0][0].ToString();
        }
    }
}
