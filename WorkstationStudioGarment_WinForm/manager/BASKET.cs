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
    
    public partial class BASKET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BASKET()
        {
            this.ORDERs = new HashSet<ORDER>();
        }
    
        public int id_basket { get; set; }
        public int count { get; set; }
        public int id_client { get; set; }
        public int id_product { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual CLIENT CLIENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERs { get; set; }
    }
}
