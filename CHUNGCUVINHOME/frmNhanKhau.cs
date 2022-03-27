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
    public partial class frmNhanKhau : DevExpress.XtraEditors.XtraForm
    {
        Database db; //3 lớp
        DBVinHomes context = new DBVinHomes(); //Entity
        NHANKHAU nk = new NHANKHAU(); // Khai báo nhân khẩu mới
        public frmNhanKhau()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NHANKHAU> listNK)
        {
            dgvNhanKhau.Rows.Clear();
            foreach (var item in listNK)
            {
                int index = dgvNhanKhau.Rows.Add();
                dgvNhanKhau.Rows[index].Cells[0].Value = item.STT;
                dgvNhanKhau.Rows[index].Cells[1].Value = item.HOTENNK;
                DateTime tmp = (DateTime)item.NTNS;
                String dateInString = tmp.ToString("dd/MM/yyyy");
                dgvNhanKhau.Rows[index].Cells[2].Value = dateInString;
                dgvNhanKhau.Rows[index].Cells[3].Value = item.PHAINK;
                dgvNhanKhau.Rows[index].Cells[4].Value = item.QUEQUAN;
                dgvNhanKhau.Rows[index].Cells[5].Value = item.SDT;
            }
        }
        private void frmNhanKhau_Load(object sender, EventArgs e)
        {
            FillMaCHLKE();
            setButton(true);
            setKhoa(true);
            setNull();
            dgvNhanKhau.Rows.Clear();
        }
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
            txtHT.ReadOnly = a;
            txtSDT.ReadOnly = a;
        }

        void setNull()
        {
            txtSTT.Text = "";
            txtHT.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text = "";
            cboPhai.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            db = new Database();
            DataTable dt = db.Execute("select STT, HOTENNK,NTNS, PHAINK, QUEQUAN, SDT from NHANKHAU where MACH = '" + lkeMCH.Text + "'");
            List<NHANKHAU> NKList = new List<NHANKHAU>();
            for (int i = 0; i < dt.Rows.Count; i++) // chuyển dữ liệu từ datatable thành list
            {
                NHANKHAU nk = new NHANKHAU();
                nk.STT = Convert.ToInt32(dt.Rows[i][0]);
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
        private void FillMaCHLKE()
        {
            db = new Database();
            DataTable dt = db.Execute("select MACH from CANHO where TRANGTHAI = 1");
            lkeMCH.Properties.DataSource = dt;
            lkeMCH.Properties.DisplayMember = "MACH";
            lkeMCH.Properties.ValueMember = "MACH";

        }

        private void dgvNhanKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNhanKhau.SelectedRows.Count > 0)
                {
                    txtSTT.Text = dgvNhanKhau.SelectedRows[0].Cells[0].Value.ToString();
                    txtHT.Text = dgvNhanKhau.SelectedRows[0].Cells[1].Value.ToString();
                    DateTime ns = DateTime.ParseExact(dgvNhanKhau.SelectedRows[0].Cells[2].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNTNS.Text = ns.ToShortDateString();
                    cboPhai.Text = dgvNhanKhau.SelectedRows[0].Cells[3].Value.ToString();
                    txtQueQuan.Text = dgvNhanKhau.SelectedRows[0].Cells[4].Value.ToString();
                    txtSDT.Text = dgvNhanKhau.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            db = new Database();
            DataTable dt = db.Execute("select max(STT) from NHANKHAU");
            txtSTT.Text = (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString();
            setButton(false);
            setKhoa(false);
            txtHT.Focus();
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
            if (txtHT.Text.Length == 0)
            {
                MessageBox.Show("Chọn đối tượng cần sửa!");
                setButton(true);
                setKhoa(true);
                setNull();
            }
            else
            {
                setButton(false);
                setKhoa(false);
                txtHT.Focus();
            }
        }

        private void btnKluu_Click(object sender, EventArgs e)
        {
            setButton(true);
            setKhoa(true);
            setNull();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(txtSTT.Text);
                NHANKHAU findNK = context.NHANKHAUs.FirstOrDefault(p => p.STT == tmp && p.MACH == lkeMCH.Text);
                NHANKHAU dbDelete = context.NHANKHAUs.FirstOrDefault(p => p.STT == tmp && p.MACH == lkeMCH.Text);
                if (findNK == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.NHANKHAUs.Remove(findNK);
                        context.SaveChanges();
                        BindGrid(context.NHANKHAUs.ToList());
                        MessageBox.Show("Xóa Thành Công!");
                        setButton(true);
                        setKhoa(true);
                        setNull();
                    }
                    if (dbDelete != null)
                    {
                        dgvNhanKhau.Rows.Clear();
                        Reload();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn đối tượng cần xóa. Vui lòng thử lại!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtHT.Text.Trim() == "" || this.txtQueQuan.Text.Trim() == "" || this.txtSDT.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân khẩu!");
                    return;
                }
                int tt = int.Parse(txtSTT.Text);
                NHANKHAU findNK = context.NHANKHAUs.FirstOrDefault(p => p.STT == tt && p.MACH == lkeMCH.Text);
                if (findNK == null)
                {
                    DateTime ns = Convert.ToDateTime(dtpNTNS.Value.ToString("yyyy-MM-dd"));
                    nk.ThemNK(txtHT.Text, ns, cboPhai.SelectedItem.ToString(), txtQueQuan.Text, txtSDT.Text, frmDN.scrID, lkeMCH.Text);
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                }
                else //cập nhật bằng két nối 3 lớp
                {
                    DateTime ns = Convert.ToDateTime(dtpNTNS.Value.ToString("yyyy-MM-dd"));
                    nk.CapNhatNK(txtHT.Text, ns, cboPhai.SelectedItem.ToString(), txtQueQuan.Text, txtSDT.Text, frmDN.scrID, lkeMCH.Text, txtSTT.Text);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                setButton(true);
                setKhoa(true);
                setNull();
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}