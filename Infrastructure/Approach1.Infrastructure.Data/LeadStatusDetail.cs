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
    
    public partial class LeadStatusDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeadStatusDetail()
        {
            this.CampaignLeadDetails = new HashSet<CampaignLeadDetail>();
            this.Leads = new HashSet<Lead>();
            this.LeadDetailHistories = new HashSet<LeadDetailHistory>();
            this.LeadStatusHistories = new HashSet<LeadStatusHistory>();
        }
    
        public int LeadStatusDetailId { get; set; }
        public string LeadStatusDetailText { get; set; }
        public int LeadStatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignLeadDetail> CampaignLeadDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lead> Leads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadDetailHistory> LeadDetailHistories { get; set; }
        public virtual LeadStatu LeadStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadStatusHistory> LeadStatusHistories { get; set; }
    }
}