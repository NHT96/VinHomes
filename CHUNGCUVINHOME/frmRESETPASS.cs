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
    public partial class frmRESETPASS : DevExpress.XtraEditors.XtraForm
    {
        frmDN formDN;
        Database db;
        TAIKHOAN tk = new TAIKHOAN();
        public frmRESETPASS(frmDN formDN)
        {
            InitializeComponent();
            this.formDN = formDN;
        }

        private void txtQLDN_Click(object sender, EventArgs e)
        {
            this.Close();
            formDN.Show();
        }

        private void txtRS_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập ID với 10 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (txtCFID.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên với 10 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            db = new Database();
            DataTable dt = db.Execute("SELECT ID, MANV FROM TAIKHOAN WHERE ID = '" + txtID.Text +"'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại tài khoản với ID đã nhập ở trên!", "Thông báo", MessageBoxButtons.OK);
            }
            else if(dt.Rows[0][1].ToString() == txtCFID.Text)
            {
                tk.ResetPW(txtID.Text, txtCFID.Text);
                MessageBox.Show("Khôi phục mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Khôi phục mật khẩu không thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void frmRESETPASS_Load(object sender, EventArgs e)
        {

        }

        private void frmRESETPASS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                formDN.Show();
            }
        }
    }
}