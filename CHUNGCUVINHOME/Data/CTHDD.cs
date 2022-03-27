namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHDD")]
    public partial class CTHDD
    {
        private Database db;

        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MACH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MAHDDIEN { get; set; }

        [Column(TypeName = "money")]
        public decimal DONGIADIEN { get; set; }

        public int TONGLDTT { get; set; }

        [Column(TypeName = "money")]
        public decimal THANHTIEN { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual QLDIEN QLDIEN { get; set; }

    }
}
