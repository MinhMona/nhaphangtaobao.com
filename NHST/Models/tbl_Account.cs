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
    
    public partial class tbl_Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> LevelID { get; set; }
        public Nullable<double> Wallet { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> SaleID { get; set; }
        public Nullable<int> DathangID { get; set; }
        public Nullable<int> VIPLevel { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<double> WalletCYN { get; set; }
        public Nullable<int> WarehouseFrom { get; set; }
        public Nullable<int> WarehouseTo { get; set; }
        public Nullable<double> Currency { get; set; }
        public string FeeBuyPro { get; set; }
        public string FeeTQVNPerWeight { get; set; }
        public Nullable<double> Deposit { get; set; }
        public Nullable<int> ShippingType { get; set; }
        public string LoginStatus { get; set; }
        public Nullable<int> WareHouseTQ { get; set; }
        public Nullable<int> WareHouseVN { get; set; }
        public string Token { get; set; }
        public string TienTichLuy { get; set; }
    }
}
