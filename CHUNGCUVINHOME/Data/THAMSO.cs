namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THAMSO")]
    public partial class THAMSO
    {
        private Database db;

        [Key]
        [StringLength(3)]
        public string MATS { get; set; }

        [StringLength(30)]
        public string TENTS { get; set; }

        public double? GIATRI { get; set; }

        public void CapNhatDGD(double TD)
        {
            db = new Database();
            string str = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE MATS = 'D01'", TD);
            db.ExecuteNonQuery(str);
        }

        public void CapNhatDGN(double TN)
        {
            db = new Database();
            string str = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE MATS = 'N02'", TN);
            db.ExecuteNonQuery(str);
        }

        public void CapNhatDGDVC(double pan, double pmt, double pgx)
        {
            db = new Database();
            string str = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE MATS = 'R03'", pmt);
            string str1 = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE MATS = 'A04'", pgx);
            string str2 = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE MATS = 'G05'", pan);
            db.ExecuteNonQuery(str);
            db.ExecuteNonQuery(str1);
            db.ExecuteNonQuery(str2);
        }
    }
}
