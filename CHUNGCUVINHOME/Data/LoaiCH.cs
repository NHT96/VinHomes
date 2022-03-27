namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiCH")]
    public partial class LoaiCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiCH()
        {
            CANHOes = new HashSet<CANHO>();
        }

        [Key]
        [StringLength(5)]
        public string MALOAI { get; set; }

        public double? DIENTICH { get; set; }

        public int? SOPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANHO> CANHOes { get; set; }
    }
}
