//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kheirieh.datalayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class taj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public taj()
        {
            this.kerayehs = new HashSet<kerayeh>();
        }
    
        public int id { get; set; }
        public string typename { get; set; }
        public int amount { get; set; }
        public string description { get; set; }
        public Nullable<int> count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kerayeh> kerayehs { get; set; }
    }
}
