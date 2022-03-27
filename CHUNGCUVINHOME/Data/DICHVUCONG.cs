namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVUCONG")]
    public partial class DICHVUCONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVUCONG()
        {
            CTHDDVCs = new HashSet<CTHDDVC>();
        }

        [Key]
        [StringLength(8)]
        public string MAHDDVC { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYTB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDDVC> CTHDDVCs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
