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
    
    public partial class CLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT()
        {
            this.BASKETs = new HashSet<BASKET>();
        }
    
        public int id_client { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int access_level { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string mail { get; set; }
        public string phone_number { get; set; }
        public int sex { get; set; }
        public int growth { get; set; }
        public int chest { get; set; }
        public int waist { get; set; }
        public int hip { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BASKET> BASKETs { private get; set; }
    }
}
