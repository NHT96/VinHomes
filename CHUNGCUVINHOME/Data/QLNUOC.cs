namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLNUOC")]
    public partial class QLNUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QLNUOC()
        {
            CTHDNs = new HashSet<CTHDN>();
        }

        [Key]
        [StringLength(8)]
        public string MAHDNUOC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYCHOT { get; set; }

        public double? CHISONUOC { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDN> CTHDNs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
