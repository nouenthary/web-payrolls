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
    
    public partial class tblLost_Inventory
    {
        public int PK_Lost_Inventor_Id { get; set; }
        public Nullable<int> FK_Inventory_Id { get; set; }
        public Nullable<int> FK_LostInventoryNo_Id { get; set; }
        public Nullable<int> Add_Lost_User_Update { get; set; }
        public string Add_Lost_Date_Update { get; set; }
        public string Add_Lost_Time_Update { get; set; }
        public Nullable<int> Lost_By_U { get; set; }
        public Nullable<int> Lost_QTY { get; set; }
        public Nullable<double> Unit_Price { get; set; }
        public Nullable<double> Total_Price { get; set; }
        public Nullable<int> User_Confrim { get; set; }
        public string Date_Confirm { get; set; }
        public string Time_Confirm { get; set; }
        public string Lost_Status { get; set; }
        public string Descr { get; set; }
    
        public virtual tblInventory tblInventory { get; set; }
        public virtual tblLostInventoryNo tblLostInventoryNo { get; set; }
    }
}