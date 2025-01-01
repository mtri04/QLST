using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Model
{
    public partial class MarketModel : DbContext
    {
        public MarketModel()
            : base("name=MarketModel")
        {
        }

        public virtual DbSet<chitiethoadon> chitiethoadons { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<nhacungcap> nhacungcaps { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }
        public virtual DbSet<taikhoan> taikhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<hoadon>()
                .HasMany(e => e.chitiethoadons)
                .WithRequired(e => e.hoadon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhanvien>()
                .HasOptional(e => e.taikhoan)
                .WithRequired(e => e.nhanvien);

            modelBuilder.Entity<sanpham>()
                .HasMany(e => e.chitiethoadons)
                .WithRequired(e => e.sanpham)
                .WillCascadeOnDelete(false);
        }
    }
}
