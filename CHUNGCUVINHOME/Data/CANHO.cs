namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("CANHO")]
    public partial class CANHO
    {
        private Database db;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANHO()
        {
            NHANKHAUs = new HashSet<NHANKHAU>();
            CTHDDs = new HashSet<CTHDD>();
            CTHDNs = new HashSet<CTHDN>();
            CTHDDVCs = new HashSet<CTHDDVC>();
        }

        [Key]
        [StringLength(7)]
        public string MACH { get; set; }

        public bool? TRANGTHAI { get; set; }

        [StringLength(5)]
        public string MALOAI { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(1)]
        public string MABLOCK { get; set; }

        [StringLength(4)]
        public string TANG { get; set; }

        public virtual BLOCK BLOCK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANKHAU> NHANKHAUs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDD> CTHDDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDN> CTHDNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDDVC> CTHDDVCs { get; set; }

        public virtual LoaiCH LoaiCH { get; set; }

        public DataTable XEMTT(string ch)
        {
            db = new Database();
            DataTable dt = db.Execute("SELECT TRANGTHAI, MALOAI from CANHO where MACH= N'" + ch + "'");
            return dt;
        }

        public void SetDaBan(string mch, string id)
        {
            db = new Database();
            db.ExecuteNonQuery("UPDATE CANHO  SET TRANGTHAI = 1, MANV = N'" + id + "' where MACH=N'" + mch + "'");
        }

        public void SetChuaBan(string mch, string id)
        {
            db = new Database();
            db.ExecuteNonQuery("UPDATE CANHO  SET TRANGTHAI = 0, MANV = N'" + id + "' where MACH=N'" + mch + "'");
            db.ExecuteNonQuery("DELETE FROM NHANKHAU WHERE MACH=N'" + mch + "'");
        }
    }
}
