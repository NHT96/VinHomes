namespace CHUNGCUVINHOME.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBVinHomes : DbContext
    {
        public DBVinHomes()
            : base("name=DBVinHomes")
        {
        }

        public virtual DbSet<BLOCK> BLOCKs { get; set; }
        public virtual DbSet<CANHO> CANHOes { get; set; }
        public virtual DbSet<CTHDD> CTHDDs { get; set; }
        public virtual DbSet<CTHDDVC> CTHDDVCs { get; set; }
        public virtual DbSet<CTHDN> CTHDNs { get; set; }
        public virtual DbSet<DICHVUCONG> DICHVUCONGs { get; set; }
        public virtual DbSet<LoaiCH> LoaiCHes { get; set; }
        public virtual DbSet<NHANKHAU> NHANKHAUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<QLDIEN> QLDIENs { get; set; }
        public virtual DbSet<QLNUOC> QLNUOCs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BLOCK>()
                .Property(e => e.MABLOCK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BLOCK>()
                .Property(e => e.TANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BLOCK>()
                .HasMany(e => e.CANHOes)
                .WithOptional(e => e.BLOCK)
                .HasForeignKey(e => new { e.MABLOCK, e.TANG });

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MACH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MABLOCK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.TANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.NHANKHAUs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.CTHDDs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.CTHDNs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.CTHDDVCs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHDD>()
                .Property(e => e.MACH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHDD>()
                .Property(e => e.MAHDDIEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHDD>()
                .Property(e => e.DONGIADIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDD>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDDVC>()
                .Property(e => e.MACH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHDDVC>()
                .Property(e => e.MAHDDVC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHDDVC>()
                .Property(e => e.PHIANNINH)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDDVC>()
                .Property(e => e.PHIMOITRUONG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDDVC>()
                .Property(e => e.PHIGIUXE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDDVC>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDN>()
                .Property(e => e.MACH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHDN>()
                .Property(e => e.MAHDNUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTHDN>()
                .Property(e => e.DONGIANUOC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHDN>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICHVUCONG>()
                .Property(e => e.MAHDDVC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVUCONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVUCONG>()
                .HasMany(e => e.CTHDDVCs)
                .WithRequired(e => e.DICHVUCONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiCH>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANKHAU>()
                .Property(e => e.MACH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANKHAU>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANKHAU>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MAIL)
                .IsFixedLength();

            modelBuilder.Entity<QLDIEN>()
                .Property(e => e.MAHDDIEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QLDIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QLDIEN>()
                .HasMany(e => e.CTHDDs)
                .WithRequired(e => e.QLDIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QLNUOC>()
                .Property(e => e.MAHDNUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QLNUOC>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QLNUOC>()
                .HasMany(e => e.CTHDNs)
                .WithRequired(e => e.QLNUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.PASS)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THAMSO>()
                .Property(e => e.MATS)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
