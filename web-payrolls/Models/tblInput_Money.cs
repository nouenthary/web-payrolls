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
    
    public partial class tblInput_Money
    {
        public long PK_Input_Money_Id { get; set; }
        public Nullable<long> FK_Staff_Id { get; set; }
        public Nullable<double> Total_Price { get; set; }
        public string Status { get; set; }
        public string Picture { get; set; }
        public string Descr { get; set; }
        public Nullable<int> User_Update { get; set; }
        public string Date_Update { get; set; }
        public string Time_Update { get; set; }
        public Nullable<int> User_Confirm { get; set; }
        public string Date_Confirm { get; set; }
        public string Time_Confirm { get; set; }
    }
}