namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chitiethoadon")]
    public partial class chitiethoadon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string madh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string masp { get; set; }

        public int? soluong { get; set; }

        public decimal? dongia { get; set; }

        public virtual hoadon hoadon { get; set; }

        public virtual sanpham sanpham { get; set; }
    }
}
