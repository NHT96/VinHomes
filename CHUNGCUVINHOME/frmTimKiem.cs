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
    public partial class frmTimKiem : DevExpress.XtraEditors.XtraForm
    {
        Database db;
        DBVinHomes context = new DBVinHomes();
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void tpgNhanVien_Click(object sender, EventArgs e)
        {
            txtIDtk.Text = "";
            txtTentk.Text = "";
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
        private void BindGrid(List<NHANKHAU> listNK)
        {
            dgvNhanKhau.Rows.Clear();
            foreach (var item in listNK)
            {
                int index = dgvNhanKhau.Rows.Add();
                dgvNhanKhau.Rows[index].Cells[0].Value = item.MACH;
                dgvNhanKhau.Rows[index].Cells[1].Value = item.HOTENNK;
                DateTime tmp = (DateTime)item.NTNS;
                String dateInString = tmp.ToString("dd/MM/yyyy");
                dgvNhanKhau.Rows[index].Cells[2].Value = dateInString;
                dgvNhanKhau.Rows[index].Cells[3].Value = item.PHAINK;
                dgvNhanKhau.Rows[index].Cells[4].Value = item.QUEQUAN;
                dgvNhanKhau.Rows[index].Cells[5].Value = item.SDT;
            }
        }
        private void btnTKid_Click(object sender, EventArgs e)
        {
            txtTentk.Text = "";
            if (txtIDtk.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đủ 10 ký tự cho mã nhân viên!", "Thông báo!");
                return;
            }
            else
            {
                db = new Database();
                DataTable dt = db.Execute("select * from NHANVIEN where MANV = N'" + txtIDtk.Text + "'");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không có nhân viên với mã tìm kiếm ở trên!", "Thông báo");
                List<NHANVIEN> NVList = new List<NHANVIEN>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NHANVIEN nk = new NHANVIEN();
                    nk.MANV = dt.Rows[i][0].ToString();
                    nk.HOTENNV = dt.Rows[i][1].ToString();
                    DateTime ns = Convert.ToDateTime(dt.Rows[i][2].ToString());
                    nk.NS = ns;
                    nk.PHAI = dt.Rows[i][3].ToString();
                    nk.CHUCVU = dt.Rows[i][4].ToString();
                    nk.MAIL = dt.Rows[i][5].ToString();
                    NVList.Add(nk);
                }
                BindGrid(NVList);
            }
        }

        private void btnTKten_Click(object sender, EventArgs e)
        {
            txtIDtk.Text = "";
            if (txtTentk.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!", "Thông báo!");
                return;
            }
            else
            {
                db = new Database();
                DataTable dt = db.Execute("select * from NHANVIEN where HOTENNV like N'%" + txtTentk.Text + "%'");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không có nhân viên với tên tìm kiếm ở trên!", "Thông báo");
                List<NHANVIEN> NVList = new List<NHANVIEN>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NHANVIEN nk = new NHANVIEN();
                    nk.MANV = dt.Rows[i][0].ToString();
                    nk.HOTENNV = dt.Rows[i][1].ToString();
                    DateTime ns = Convert.ToDateTime(dt.Rows[i][2].ToString());
                    nk.NS = ns;
                    nk.PHAI = dt.Rows[i][3].ToString();
                    nk.CHUCVU = dt.Rows[i][4].ToString();
                    nk.MAIL = dt.Rows[i][5].ToString();
                    NVList.Add(nk);
                }
                BindGrid(NVList);
            }
        }

        private void btnTKTenNK_Click(object sender, EventArgs e)
        {
            txtDiaChiTK.Text = "";
            if (txtTenNKtk.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nhân khẩu cần tìm!", "Thông báo!");
                return;
            }
            else
            {
                db = new Database();
                DataTable dt = db.Execute("select MACH, HOTENNK,NTNS, PHAINK, QUEQUAN, SDT from NHANKHAU where HOTENNK like N'%" + txtTenNKtk.Text + "%'");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không có nhân khẩu với tên tìm kiếm ở trên!", "Thông báo");
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
                BindGrid(NKList);
            }
        }

        private void btnTKDC_Click(object sender, EventArgs e)
        {
            txtTenNKtk.Text = "";
            if (txtDiaChiTK.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập quê quán nhân khẩu cần tìm!", "Thông báo!");
                return;
            }
            else
            {
                db = new Database();
                DataTable dt = db.Execute("select MACH, HOTENNK,NTNS, PHAINK, QUEQUAN, SDT from NHANKHAU where QUEQUAN like N'%" + txtDiaChiTK.Text + "%'");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không có nhân khẩu với địa chỉ tìm kiếm ở trên!", "Thông báo");
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
                BindGrid(NKList);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}