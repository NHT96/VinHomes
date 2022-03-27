namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            CANHOes = new HashSet<CANHO>();
            DICHVUCONGs = new HashSet<DICHVUCONG>();
            NHANKHAUs = new HashSet<NHANKHAU>();
            TAIKHOANs = new HashSet<TAIKHOAN>();
            QLNUOCs = new HashSet<QLNUOC>();
            QLDIENs = new HashSet<QLDIEN>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string HOTENNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NS { get; set; }

        [StringLength(5)]
        public string PHAI { get; set; }

        [StringLength(30)]
        public string CHUCVU { get; set; }

        [StringLength(30)]
        public string MAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANHO> CANHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVUCONG> DICHVUCONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANKHAU> NHANKHAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLNUOC> QLNUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLDIEN> QLDIENs { get; set; }
    }
}
