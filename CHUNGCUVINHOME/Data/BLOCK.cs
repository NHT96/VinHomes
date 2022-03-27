namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BLOCK")]
    public partial class BLOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BLOCK()
        {
            CANHOes = new HashSet<CANHO>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string MABLOCK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string TANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANHO> CANHOes { get; set; }
    }
}
