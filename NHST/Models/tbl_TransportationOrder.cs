//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NHST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_TransportationOrder
    {
        public int ID { get; set; }
        public Nullable<int> UID { get; set; }
        public string Username { get; set; }
        public Nullable<int> WarehouseFromID { get; set; }
        public Nullable<int> WarehouseID { get; set; }
        public Nullable<int> ShippingTypeID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<double> TotalWeight { get; set; }
        public Nullable<double> Currency { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public string Description { get; set; }
        public Nullable<double> Deposited { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<double> WarehouseFee { get; set; }
        public Nullable<double> CheckProductFee { get; set; }
        public Nullable<double> PackagedFee { get; set; }
        public Nullable<double> TotalCODTQCYN { get; set; }
        public Nullable<double> TotalCODTQVND { get; set; }
        public Nullable<double> InsurranceFee { get; set; }
    }
}
