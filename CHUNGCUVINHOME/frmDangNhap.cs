using CHUNGCUVINHOME.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHUNGCUVINHOME
{
    public partial class frmDN : DevExpress.XtraEditors.XtraForm
    {
        TAIKHOAN tk = new TAIKHOAN();
        public static string scrName = "";
        public static string scrID = "";
        public frmDN()
        {
            InitializeComponent();
        }

        private void setNull()
        {
            txtID.Text = "";
            txtPass.Text = "";
            txtID.Focus();
        }
        private void txtDongCT_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtRSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRESETPASS rs = new frmRESETPASS(this);
            rs.Show();          
        }
        
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập ID đăng nhập. Vui lòng nhập đúng 10 ký tự cho ID!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtPass.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu. Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtID.Text.Length !=10)
            {
                MessageBox.Show("Vui lòng nhập đúng 10 ký tự cho ID!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (txtPass.Text.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu lớn hơn hoặc bằng 6 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (tk.login(txtID.Text, txtPass.Text))
                {
                    scrName = tk.LayTenDN(txtID.Text);
                    scrID = tk.LayIDDN(txtID.Text);
                    frmTrangChu f = new frmTrangChu(this);
                    setNull();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                    txtPass.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                txtPass.Text = "";
            }
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            setNull();
            
        }

        private void cbtnHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtnHienMK.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Focus();
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Focus();
            }
        }

        private void btnHDSD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("HDSD.chm");
        }
    }
}
