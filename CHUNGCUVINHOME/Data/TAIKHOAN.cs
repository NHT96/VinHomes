namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        private Database db;

        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(15)]
        public string PASS { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
        public TAIKHOAN()
        {
            db = new Database();
        }

        public bool login(string id, string pass)
        {
            DataTable dt = db.Execute("SELECT ID,PASS from TAIKHOAN where ID='" + id + "' and PASS='" + pass + "'");
            if (dt.Rows.Count > 0 && dt.Rows[0][1].ToString().Contains(pass) == true)
                return true;
            else
                return false;
        }

        public void ResetPW(string id, string mnv)
        {
            db.ExecuteNonQuery("UPDATE TAIKHOAN  SET PASS ='" + id + "' where ID='" + id + "' and MANV = '" + mnv + "'");
        }

        public void UpDatePW(string id, string pass, string newPass)
        {
            DataTable dt = db.Execute("SELECT * from TAIKHOAN where ID='" + id + "'and PASS='" + pass + "'");
            if (dt.Rows.Count > 0)
                db.ExecuteNonQuery("UPDATE TAIKHOAN  SET PASS ='" + newPass + "' where ID='" + id + "'and PASS='" + pass + "'");
        }


        public string LayTenDN(string id)
        {

            DataTable dt = db.Execute("SELECT n.HOTENNV from TAIKHOAN t, NHANVIEN n where t.MANV=n.MANV and t.ID ='" + id + "'");
            DataRow dtr = dt.Rows[0];
            return dtr[0].ToString();
        }

        public string LayIDDN(string id)
        {

            DataTable dt = db.Execute("SELECT t.MANV from TAIKHOAN t, NHANVIEN n where t.MANV=n.MANV and t.ID ='" + id + "'");
            DataRow dtr = dt.Rows[0];
            return dtr[0].ToString();
        }
    }
}
