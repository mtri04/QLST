    namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hoadon")]
    public partial class hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoadon()
        {
            chitiethoadons = new HashSet<chitiethoadon>();
        }

        [Key]
        [StringLength(50)]
        public string madh { get; set; }

        [StringLength(100)]
        public string tenkh { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaymua { get; set; }

        [StringLength(50)]
        public string manv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }

        public virtual nhanvien nhanvien { get; set; }
    }
}
