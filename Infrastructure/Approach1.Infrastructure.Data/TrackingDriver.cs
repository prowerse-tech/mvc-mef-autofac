//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Approach1.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrackingDriver
    {
        public int TrackingDriverId { get; set; }
        public int TrackingProviderSpecificId { get; set; }
        public string DriverName { get; set; }
        public string DriverSurname { get; set; }
        public string DriverIdNumber { get; set; }
        public string DriverCellNumber { get; set; }
        public string DriverHomeNumber { get; set; }
        public string DriverWorkNumber { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public int SuburbId { get; set; }
        public int CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        public virtual Suburb Suburb { get; set; }
        public virtual TrackingProviderSpecific TrackingProviderSpecific { get; set; }
    }
}