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
    
    public partial class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Ip { get; set; }
        public string status { get; set; }
        public string Image { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> Group { get; set; }
        public int Type { get; set; }
        public System.DateTime AddIn { get; set; }
        public Nullable<System.DateTime> TimeON { get; set; }
        public Nullable<System.DateTime> TimeOF { get; set; }
        public Nullable<int> DaysToCheck { get; set; }
        public Nullable<int> CheckEvery { get; set; }
        public string Log { get; set; }
        public Nullable<int> Warnings { get; set; }
        public Nullable<int> Location { get; set; }
        public Nullable<int> Services { get; set; }
    }
}
