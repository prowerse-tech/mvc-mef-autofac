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
    
    public partial class OrderTelcoAttribute
    {
        public int OrderTelcoAttributeId { get; set; }
        public int OrderId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public string PortStatus { get; set; }
        public Nullable<System.DateTime> PortDate { get; set; }
        public string PortFrom { get; set; }
        public string PortTo { get; set; }
        public string PortEmailSet { get; set; }
        public string PortInitialOrder { get; set; }
        public string PortInitialPre { get; set; }
        public string ExistingAccount { get; set; }
        public string ExistingNumber { get; set; }
        public string KeepPrepaid { get; set; }
        public string OnBilling { get; set; }
        public Nullable<System.DateTime> OnBillingDate { get; set; }
        public Nullable<decimal> OnBillingCharge { get; set; }
        public string OnBillingSubFlag { get; set; }
        public string RICA { get; set; }
        public string ItemisedBilling { get; set; }
        public int ItemisedBillingTypeId { get; set; }
    
        public virtual ItemisedBillingType ItemisedBillingType { get; set; }
        public virtual Order Order { get; set; }
    }
}
