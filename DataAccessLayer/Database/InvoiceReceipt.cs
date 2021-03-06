//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceReceipt
    {
        public int InvoiceReceiptId { get; set; }
        public Nullable<int> ShopId { get; set; }
        public Nullable<int> BankId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string PersonalName { get; set; }
        public string PaymentMedium { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> ApplicationId { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
