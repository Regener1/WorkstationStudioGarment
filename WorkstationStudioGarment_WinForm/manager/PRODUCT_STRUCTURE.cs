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
    
    public partial class PRODUCT_STRUCTURE
    {
        public int id_product_structure { get; set; }
        public int count { get; set; }
        public int id_product { get; set; }
        public int id_material { get; set; }
    
        public virtual MATERIAL MATERIAL { private get; set; }
        public virtual PRODUCT PRODUCT { private get; set; }
    }
}
