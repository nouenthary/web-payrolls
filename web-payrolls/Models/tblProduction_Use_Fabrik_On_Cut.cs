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
    
    public partial class tblProduction_Use_Fabrik_On_Cut
    {
        public long PK_Use_Fabrik_On_Cut_Id { get; set; }
        public Nullable<long> FK_Grade_Id { get; set; }
        public Nullable<int> FK_Com_Id { get; set; }
        public Nullable<long> Stock_In_Product_Cut_No { get; set; }
        public Nullable<int> In_QTY { get; set; }
        public string Stock_In_Type { get; set; }
        public Nullable<int> U_Update { get; set; }
        public string In_Date { get; set; }
        public string In_Time { get; set; }
    
        public virtual tblProduction_Grade tblProduction_Grade { get; set; }
    }
}
