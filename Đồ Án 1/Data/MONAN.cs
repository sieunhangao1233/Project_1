//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Đồ_Án_1.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            this.CHITIET_HOADON = new HashSet<CHITIET_HOADON>();
        }
    
        public string monanID { get; set; }
        public string TenMon { get; set; }
        public string LoaiMon { get; set; }
        public Nullable<int> DonGia { get; set; }
        public string TrangThai { get; set; }
        public string NhanVienID { get; set; }
        public string Ngaytao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HOADON> CHITIET_HOADON { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
