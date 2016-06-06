//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentRequest
    {
        public PaymentRequest()
        {
            this.Notifications = new HashSet<Notification>();
            this.PaymentDossierDocuments = new HashSet<PaymentDossierDocument>();
            this.PaymentVouchers = new HashSet<PaymentVoucher>();
            this.PaymentRequestBudgetLines = new HashSet<PaymentRequestBudgetLine>();
        }
    
        public System.Guid Id { get; set; }
        public string RefNumber { get; set; }
        public string PaymentRqstType { get; set; }
        public string VoucherNumber { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string Subject { get; set; }
        public decimal TotalAmount { get; set; }
        public Nullable<System.Guid> PurchaseOrderId { get; set; }
        public Nullable<System.Guid> SPMId { get; set; }
        public System.Guid CurrencyId { get; set; }
        public System.Guid SupplierId { get; set; }
        public string RequestFor { get; set; }
        public System.Guid PaymentTermId { get; set; }
        public System.Guid PaymentTypeId { get; set; }
        public string Remarks { get; set; }
        public System.Guid PreparedBy { get; set; }
        public Nullable<System.Guid> ReviewedBy { get; set; }
        public Nullable<System.Guid> AuthorizedBy { get; set; }
        public Nullable<bool> IsReviewed { get; set; }
        public Nullable<bool> IsAuthorized { get; set; }
        public Nullable<System.DateTime> ReviewedOn { get; set; }
        public Nullable<System.DateTime> AuthorizedOn { get; set; }
        public System.DateTime PreparedOn { get; set; }
        public string RejectedReviewRemarks { get; set; }
        public string RejectedAuthorizeRemarks { get; set; }
        public long RecordCount { get; set; }
        public System.Guid CountryProgrammeId { get; set; }
        public Nullable<System.Guid> MBCurrencyId { get; set; }
        public Nullable<decimal> MBValue { get; set; }
        public bool IsRejected { get; set; }
        public bool FundsPosted { get; set; }
        public Nullable<System.DateTime> PostedOn { get; set; }
        public Nullable<System.Guid> PostedBy { get; set; }
        public bool IsSubmitted { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PaymentDossierDocument> PaymentDossierDocuments { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual ICollection<PaymentVoucher> PaymentVouchers { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual Staff Staff1 { get; set; }
        public virtual Staff Staff2 { get; set; }
        public virtual Staff Staff3 { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PaymentRequestBudgetLine> PaymentRequestBudgetLines { get; set; }
    }
}