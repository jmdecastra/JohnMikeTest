//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JohnMikeTestCode.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MACHINE
    {
        public MACHINE()
        {
            this.MACHINETIMINGs = new HashSet<MACHINETIMING>();
        }
    
        public string MID { get; set; }
        public string MNAME { get; set; }
        public string WHID { get; set; }
        public string WHNAME { get; set; }
    
        public virtual ELSTWAREHOUSE ELSTWAREHOUSE { get; set; }
        public virtual ICollection<MACHINETIMING> MACHINETIMINGs { get; set; }
    }
}
