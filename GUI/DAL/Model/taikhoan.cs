namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("taikhoan")]
    public partial class taikhoan
    {
        [Key]
        [StringLength(50)]
        public string manv { get; set; }

        [Required]
        [StringLength(50)]
        public string user { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datecreate { get; set; }

        public bool? isAdmin { get; set; }

        public virtual nhanvien nhanvien { get; set; }
    }
}
