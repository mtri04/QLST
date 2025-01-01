namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhanvien")]
    public partial class nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhanvien()
        {
            hoadons = new HashSet<hoadon>();
            sanphams = new HashSet<sanpham>();
        }

        [Key]
        [StringLength(50)]
        public string manv { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [StringLength(150)]
        public string avatar { get; set; }

        [StringLength(50)]
        public string fullname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadon> hoadons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sanpham> sanphams { get; set; }

        public virtual taikhoan taikhoan { get; set; }
    }
}
