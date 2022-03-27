namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHDDVC")]
    public partial class CTHDDVC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MACH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MAHDDVC { get; set; }

        [Column(TypeName = "money")]
        public decimal PHIANNINH { get; set; }

        [Column(TypeName = "money")]
        public decimal PHIMOITRUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal PHIGIUXE { get; set; }

        [Column(TypeName = "money")]
        public decimal THANHTIEN { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual DICHVUCONG DICHVUCONG { get; set; }
    }
}
