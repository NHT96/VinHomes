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
    
    public partial class frmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        frmDN formDN;
        static string bl = "";
        static string ta = "";
        static string ch = "";
        private CANHO c;
        Database db;
        public frmTrangChu(frmDN formDN)
        {
            InitializeComponent();
            this.formDN = formDN;
        }
        
        private void setDisAble(bool a)
        {
            rdnDaBan.Enabled = a;
            rdnChuaBan.Enabled = a;
            btnLuuTT.Enabled = a;
            btnHuy.Enabled = a;
            btnCapNhatCH.Enabled = !a;
        }
        private void setDisable3()
        {
            btnT24.Enabled = true;
            btnT25.Enabled = true;
            btnT26.Enabled = true;
            btnT27.Enabled = true;
            btnT28.Enabled = false;
            btnT29.Enabled = false;

        }

        private void setDisable5()
        {
            btnT24.Enabled = true;
            btnT25.Enabled = true;
            btnT26.Enabled = false;
            btnT27.Enabled = false;
            btnT28.Enabled = false;
            btnT29.Enabled = false;

        }

        private void setDisable7()
        {
            btnT24.Enabled = false;
            btnT25.Enabled = false;
            btnT26.Enabled = false;
            btnT27.Enabled = false;
            btnT28.Enabled = false;
            btnT29.Enabled = false;

        }
        private void setAable7()
        {
            btnT24.Enabled = true;
            btnT25.Enabled = true;
            btnT26.Enabled = true;
            btnT27.Enabled = true;
            btnT28.Enabled = true;
            btnT29.Enabled = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetEvent(Control spbtn)
        {
            foreach (Control ctrl in spbtn.Controls)
            {
                if (ctrl is SimpleButton)
                {
                    SimpleButton btn = (SimpleButton)ctrl; //ép kiểu dạng diễn viên (Cast)
                    btn.MouseDown += new MouseEventHandler(frmTrangChu_MouseClick);
                }
                if (ctrl.HasChildren)
                    SetEvent(ctrl);
            }
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            txtDispalyName.Text = frmDN.scrName;
            SetEvent(this);
            setDisAble(false);
            db = new Database();
            DataTable dt = db.Execute("SELECT CHUCVU from TAIKHOAN t, NHANVIEN n where t.MANV=n.MANV and t.MANV ='" + frmDN.scrID + "'");
            DataRow dtr = dt.Rows[0];
            if (dtr[0].ToString() == "Quản lý" || dtr[0].ToString() == "Giám đốc" || dtr[0].ToString() == "Phó giám đốc")
            {
                btnNhanVien.Enabled = true;
            }
            else
                btnNhanVien.Enabled = false;
        }
        private void frmTrangChu_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SimpleButton btn = (SimpleButton)sender;
                if (btn.Appearance.BackColor == Color.White)
                {
                    btn.Appearance.BackColor = Color.DimGray;

                    if (btn.Name.Contains("btnBl") == true)
                    {
                        bl = btn.Text.Substring(btn.Text.Length - 1); //Lấy ký tự cuối cùng của tên simplebutton
                    }
                    else if (btn.Name.Contains("btnT") == true)
                    {
                        if (btn.Text == "xx")
                        {
                            MessageBox.Show("Tầng thượng không có phòng! Vui lòng chọn tầng khác", "Thông báo!");
                            return;
                        }
                        if (Convert.ToInt32(btn.Text.Substring(btn.Text.Length - 1)) % 2 == 0)
                        {
                            btnCH07.Enabled = true;
                            btnCH08.Enabled = true;
                        }
                        else
                        {
                            btnCH07.Enabled = false;
                            btnCH08.Enabled = false;
                        }
                        ta = btn.Text.Substring(btn.Text.Length - 2); //Lấy 2 ký tự cuối cùng của tầng (01-02-03)
                    }
                    else if (btn.Name.Contains("btnCH") == true)
                    {
                        ch = btn.Text.Substring(btn.Text.Length - 2); //Lấy 2 ký tự cuối cùng của tên mã căn hộ (01-02-03)
                    }
                    txtLuaChon.Text = bl + "-" + ta + "-" + ch; // Tương đương mã căn hộ
                }
                else if (btn.Appearance.BackColor == Color.DimGray)
                {
                    btn.Appearance.BackColor = Color.White;
                    if (btn.Name.Contains("btnBl") == true)
                    {
                        bl = "";
                    }
                    else if (btn.Name.Contains("btnT") == true)
                    {
                        ta = "";
                    }
                    else if (btn.Name.Contains("btnCH") == true)
                    {
                        ch = "";
                    }
                    txtLuaChon.Text = "";
                }
            }
            catch(Exception)
            {
            }
            
        }
        private void btnCanHo_Click(object sender, EventArgs e)
        {

        }

        private void btnBlA_Click(object sender, EventArgs e)
        {
            setDisable5();
        }

        private void btnBlB_Click(object sender, EventArgs e)
        {
            setDisable3();
        }

        private void btnBlC_Click(object sender, EventArgs e)
        {
            setAable7();
        }

        private void btnBlE_Click(object sender, EventArgs e)
        {
            setDisable5();
        }

        private void btnBlF_Click(object sender, EventArgs e)
        {
            setDisable3();
        }

        private void btnBlI_Click(object sender, EventArgs e)
        {
            setDisable7();
        }

        private void btnBlD_Click(object sender, EventArgs e)
        {
            setAable7();
        }

        private void btnBlG_Click(object sender, EventArgs e)
        {
            setAable7();
        }

        private void btnBlH_Click(object sender, EventArgs e)
        {
            setAable7();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void brnDoiMK_Click(object sender, EventArgs e)
        {
            frmRepairPW f = new frmRepairPW();
            f.Show();
        }

        private void btnCapNhatCH_Click(object sender, EventArgs e)
        {
            setDisAble(true);
           
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            setDisAble(false);
            if (rdnDaBan.Checked == true)
                c.SetDaBan(txtLuaChon.Text, frmDN.scrID);
            else
            {
                DialogResult result = MessageBox.Show("Thao tác này sẽ xóa dữ liệu nhân khẩu thuộc căn hộ này. Bạn có muốn tiếp tục không?", "Thông báo!", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                    c.SetChuaBan(txtLuaChon.Text, frmDN.scrID);
            }   
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setDisAble(false);
        }

        private void txtLuaChon_TextChanged(object sender, EventArgs e)
        {
            if (txtLuaChon.Text.Length == 7)
            {
                c = new CANHO();
                DataTable dt = c.XEMTT(txtLuaChon.Text);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow dtr = dt.Rows[0];
                    string a = dtr[0].ToString();
                    string b = dtr[1].ToString();
                    if (a == "False")
                    {
                        rdnChuaBan.Checked = true;
                        
                    }
                    else
                    {
                        
                        rdnDaBan.Checked = true;
                    }

                    if (b == "LOAI1")
                    {
                        cboLoaiCH.SelectedIndex = 0;
                    }
                    else if (b == "LOAI2")
                    {
                        cboLoaiCH.SelectedIndex = 1;
                    }
                    else
                    {
                        cboLoaiCH.SelectedIndex = 2;
                    }
                }
                else
                {
                    cboLoaiCH.Text = null;
                    rdnChuaBan.Checked = false;
                    rdnDaBan.Checked = false;
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNHANVIEN f = new frmNHANVIEN();
            f.Show();
        }

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            frmNhanKhau frmNhanKhau = new frmNhanKhau();
            frmNhanKhau.Show();
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            frmDichVu frmDichVu = new frmDichVu();
            frmDichVu.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frmBaoCao = new frmBaoCao();
            frmBaoCao.Show();
        }

        private void TimeClock_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                formDN.Show();
            }
            else
                e.Cancel = true;
        }

    }
}