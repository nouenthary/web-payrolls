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
    
    public partial class tblProduction_PK_Stock_In_Product_Import_Balance
    {
        public long PK_Stock_In_Product_Import_Bal_Id { get; set; }
        public Nullable<long> FK_Grade_Id { get; set; }
        public Nullable<int> FK_Com_Id { get; set; }
        public string Stock_In_Type { get; set; }
        public string Type { get; set; }
        public Nullable<int> QTY_Balance { get; set; }
    
        public virtual tblProduction_Grade tblProduction_Grade { get; set; }
    }
}
