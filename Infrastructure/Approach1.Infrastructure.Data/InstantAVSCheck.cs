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
    
    public partial class InstantAVSCheck
    {
        public int InstantAVSCheckId { get; set; }
        public int BankId { get; set; }
        public string AccountNumber { get; set; }
        public byte Status { get; set; }
        public int UserId { get; set; }
        public Nullable<int> CampaignId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual User User { get; set; }
    }
}