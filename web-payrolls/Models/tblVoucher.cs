//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_payrolls.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblVoucher
    {
        public long PK_Voucher_Id { get; set; }
        public Nullable<int> FK_Voucher_Rent_Other_Id { get; set; }
        public Nullable<int> FK_Voucher_No_Id { get; set; }
        public Nullable<long> FK_Staff_Id { get; set; }
        public string Rec_Date { get; set; }
        public string Rec_Time { get; set; }
        public string Voucher_Name { get; set; }
        public Nullable<int> Voucher_FK_Staff_Id { get; set; }
        public string Date_Voucher { get; set; }
        public string Time_Voucher { get; set; }
        public Nullable<double> PCC { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<double> UoM { get; set; }
        public Nullable<double> Unit_Cost { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Total { get; set; }
        public Nullable<double> Discount { get; set; }
        public string Voucher_Status { get; set; }
        public string Voucher_Picure { get; set; }
        public Nullable<int> Confirm_PK_U_Id { get; set; }
        public string Confirm_Date { get; set; }
        public string Confirm_time { get; set; }
        public string Descr { get; set; }
    
        public virtual tblVoucher_No tblVoucher_No { get; set; }
        public virtual tblVoucher_Rent_Invertory_Rent_And_Other_Voucher tblVoucher_Rent_Invertory_Rent_And_Other_Voucher { get; set; }
    }
}