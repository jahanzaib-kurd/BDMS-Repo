//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> TradeRate { get; set; }
        public Nullable<decimal> Scheme { get; set; }
        public Nullable<decimal> GrossAmount { get; set; }
        public Nullable<decimal> NetAmount { get; set; }
        public Nullable<decimal> Tonage { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
