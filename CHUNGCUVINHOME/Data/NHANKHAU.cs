namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("NHANKHAU")]
    public partial class NHANKHAU
    {
        private Database db;

        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MACH { get; set; }

        [Key]
        [Column(Order = 1)]
        public int STT { get; set; }

        [StringLength(50)]
        public string HOTENNK { get; set; }

        [Column(TypeName = "date")]
        public DateTime NTNS { get; set; }

        [StringLength(5)]
        public string PHAINK { get; set; }

        [StringLength(50)]
        public string QUEQUAN { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
        public void CapNhatNK(string ht, DateTime ntns, string gt, string qq, string sdt, string manv, string mach, string stt)
        {
            db = new Database();
            string str = string.Format("UPDATE NHANKHAU SET HOTENNK = N'{0}', NTNS = '{1}', PHAINK = N'{2}', QUEQUAN = N'{3}', SDT = {4}, MANV = '{5}' WHERE MACH = '{6}' and STT = '{7}'", ht, ntns, gt, qq, sdt, manv, mach, stt);
            db.ExecuteNonQuery(str);
        }
        public void ThemNK(string ht, DateTime ntns, string gt, string qq, string sdt, string manv, string mach)
        {
            db = new Database();
            string str = string.Format("INSERT [dbo].[NHANKHAU] ([MACH], [HOTENNK], [NTNS], [PHAINK], [QUEQUAN], [SDT], [MANV]) VALUES (N'{0}',N'{1}', CAST(N'{2}' AS Date), N'{3}', N'{4}', N'{5}', N'{6}')", mach, ht, ntns, gt, qq, sdt, manv);
            db.ExecuteNonQuery(str);
        }
    }
}
