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
    
    public partial class StockTakeItem
    {
        public int StockTakeItemsId { get; set; }
        public int StockTakeId { get; set; }
        public string IMEI { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
    }
}