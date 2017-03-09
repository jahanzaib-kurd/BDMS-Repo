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
    
    public partial class Application
    {
        public Application()
        {
            this.Areas = new HashSet<Area>();
            this.Banks = new HashSet<Bank>();
            this.Cheques = new HashSet<Cheque>();
            this.Expanses = new HashSet<Expanse>();
            this.ExpanseTypes = new HashSet<ExpanseType>();
            this.Inventories = new HashSet<Inventory>();
            this.Invoices = new HashSet<Invoice>();
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
            this.InvoiceReceipts = new HashSet<InvoiceReceipt>();
            this.Products = new HashSet<Product>();
            this.Purchases = new HashSet<Purchase>();
            this.PurchaseTargets = new HashSet<PurchaseTarget>();
            this.Shops = new HashSet<Shop>();
            this.StockPositions = new HashSet<StockPosition>();
            this.Suppliers = new HashSet<Supplier>();
            this.SupplierReciepts = new HashSet<SupplierReciept>();
        }
    
        public int ApplicationId { get; set; }
        public string ApplicationCode { get; set; }
        public string AppilicationName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<Expanse> Expanses { get; set; }
        public virtual ICollection<ExpanseType> ExpanseTypes { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<InvoiceReceipt> InvoiceReceipts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<PurchaseTarget> PurchaseTargets { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public virtual ICollection<StockPosition> StockPositions { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<SupplierReciept> SupplierReciepts { get; set; }
    }
}
