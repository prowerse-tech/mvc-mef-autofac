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
    
    public partial class OrderCancelReasonDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderCancelReasonDetail()
        {
            this.OrderCancelReasonDetailCampaignMappings = new HashSet<OrderCancelReasonDetailCampaignMapping>();
            this.OrderItems = new HashSet<OrderItem>();
            this.OrderStatusHistories = new HashSet<OrderStatusHistory>();
        }
    
        public int OrderCancelReasonDetailId { get; set; }
        public int OrderCancelReasonId { get; set; }
        public string ReasonDetail { get; set; }
        public bool IsActive { get; set; }
    
        public virtual OrderCancelReason OrderCancelReason { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCancelReasonDetailCampaignMapping> OrderCancelReasonDetailCampaignMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
}
