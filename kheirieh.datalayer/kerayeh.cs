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
    
    public partial class kerayeh
    {
        public int id { get; set; }
        public Nullable<int> usertraf { get; set; }
        public Nullable<int> tarh { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<int> ispardakht { get; set; }
        public Nullable<int> amountpay { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> count { get; set; }
        public int marhom { get; set; }
    
        public virtual person person { get; set; }
        public virtual taj taj { get; set; }
        public virtual template template { get; set; }
        public virtual marhoom marhoom1 { get; set; }
    }
}
