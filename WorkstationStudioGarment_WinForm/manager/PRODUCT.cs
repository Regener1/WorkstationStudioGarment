//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkstationStudioGarment_WinForm.manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.BASKETs = new HashSet<BASKET>();
            this.PRODUCT_STRUCTURE = new HashSet<PRODUCT_STRUCTURE>();
        }
    
        public int id_product { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public int size { get; set; }
        public string color { get; set; }
        public string photo { get; set; }
        public decimal price { get; set; }
        public int id_supply { get; set; }
        public int count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASKET> BASKETs { private get; set; }
        public virtual SUPPLY SUPPLY { private get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_STRUCTURE> PRODUCT_STRUCTURE { private get; set; }
    }
}
