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
    
    public partial class tblProduction_Repair_Closth_Balance
    {
        public long PK_Reepair_Closth_Balance_Id { get; set; }
        public Nullable<long> FK_Grade_Id { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<long> FK_From_Com_Id { get; set; }
        public Nullable<long> FK_To_Loc_Id { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Total { get; set; }
    }
}
