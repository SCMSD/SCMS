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
    
    public partial class WayBill
    {
        public System.Guid Id { get; set; }
        public string RefNumber { get; set; }
        public System.Guid WRNId { get; set; }
        public System.Guid IssuingOffice { get; set; }
        public System.Guid IssuerWarehouse { get; set; }
        public System.Guid DestinationOffice { get; set; }
        public System.Guid DestinationWarehouse { get; set; }
        public Nullable<System.DateTime> LoadingDate { get; set; }
        public Nullable<System.DateTime> DispatchDate { get; set; }
        public System.Guid Consignee { get; set; }
        public string DRCVehicleRegNo { get; set; }
        public double DRCVehicleMileage { get; set; }
        public string DRCVehicleContactNo { get; set; }
        public string LoadingRemarks { get; set; }
        public System.Guid CountryProgrammeId { get; set; }
        public System.Guid PreparedBy { get; set; }
        public string DriverName { get; set; }
        public string VehicleRegNo { get; set; }
        public string TransportCompany { get; set; }
        public string DriverLicenseNo { get; set; }
        public Nullable<System.Guid> ReceivedBy { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public Nullable<long> DRCVehicleTotalDistance { get; set; }
        public long RecordCount { get; set; }
        public Nullable<System.Guid> RecvDstnationOfficeId { get; set; }
        public Nullable<long> RecvDRCVehicleOdometer { get; set; }
        public Nullable<long> RecvDRCVehicleTotalDistance { get; set; }
        public Nullable<bool> IsReceived { get; set; }
        public System.DateTime PreparedOn { get; set; }
    
        public virtual CountryProgramme CountryProgramme { get; set; }
        public virtual CountrySubOffice CountrySubOffice { get; set; }
        public virtual CountrySubOffice CountrySubOffice1 { get; set; }
        public virtual CountrySubOffice CountrySubOffice2 { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
        public virtual Staff Staff2 { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public virtual WareHouse WareHouse1 { get; set; }
        public virtual WarehouseRelease WarehouseRelease { get; set; }
    }
}