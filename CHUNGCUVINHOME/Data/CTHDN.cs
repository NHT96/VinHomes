namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHDN")]
    public partial class CTHDN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MACH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MAHDNUOC { get; set; }

        [Column(TypeName = "money")]
        public decimal DONGIANUOC { get; set; }

        public int TONGLNTT { get; set; }

        [Column(TypeName = "money")]
        public decimal THANHTIEN { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual QLNUOC QLNUOC { get; set; }
    }
}
