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
    
    public partial class NGUYENLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUYENLIEU()
        {
            this.CHITIET_HDN = new HashSet<CHITIET_HDN>();
            this.CHITIET_HDX = new HashSet<CHITIET_HDX>();
            this.KHO_NL = new HashSet<KHO_NL>();
        }
    
        public string nguyenieuID { get; set; }
        public string tenNL { get; set; }
        public string DonGia { get; set; }
        public string LoaiNL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HDN> CHITIET_HDN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HDX> CHITIET_HDX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_NL> KHO_NL { get; set; }
    }
}
