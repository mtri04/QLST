namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanpham()
        {
            chitiethoadons = new HashSet<chitiethoadon>();
        }

        [Key]
        [StringLength(50)]
        public string masp { get; set; }

        [StringLength(50)]
        public string tensp { get; set; }

        public int? mancc { get; set; }

        public int? gianhap { get; set; }

        public int? giaban { get; set; }

        public int? solg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? hsd { get; set; }

        [Required]
        [StringLength(50)]
        public string noisx { get; set; }

        [Required]
        [StringLength(50)]
        public string manv { get; set; }

        [StringLength(150)]
        public string avatar { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaynhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }

        public virtual nhacungcap nhacungcap { get; set; }

        public virtual nhanvien nhanvien { get; set; }
    }
}
