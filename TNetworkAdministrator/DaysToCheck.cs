//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TNetworkAdministrator
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaysToCheck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaysToCheck()
        {
            this.Sunday = 1;
            this.Monday = 2;
            this.Tuesday = 3;
            this.wednesday = 4;
            this.Thursday = 5;
            this.Friday = 6;
            this.Saturday = 7;
        }
    
        public int Id { get; set; }
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
    }
}
