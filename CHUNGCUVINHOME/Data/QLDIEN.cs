namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLDIEN")]
    public partial class QLDIEN
    {
        private Database db;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QLDIEN()
        {
            CTHDDs = new HashSet<CTHDD>();
        }

        [Key]
        [StringLength(8)]
        public string MAHDDIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYKT { get; set; }

        public double CHISODIEN { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDD> CTHDDs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

    }
}
