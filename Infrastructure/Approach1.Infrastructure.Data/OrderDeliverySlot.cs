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
    
    public partial class OrderDeliverySlot
    {
        public int OrderDeliverySlotId { get; set; }
        public int OrderDeliveryId { get; set; }
        public int SlotNumber { get; set; }
        public string IMEI { get; set; }
        public string SIM { get; set; }
        public string HLR { get; set; }
        public string ControlCell { get; set; }
    
        public virtual OrderDelivery OrderDelivery { get; set; }
    }
}
