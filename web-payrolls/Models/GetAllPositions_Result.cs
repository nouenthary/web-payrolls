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
    
    public partial class GetAllPositions_Result
    {
        public string Name { get; set; }
        public Nullable<int> FK_Boss_Id { get; set; }
        public string Comp_Name { get; set; }
        public Nullable<int> FK_Comp_Id { get; set; }
        public string Loc_Name { get; set; }
        public Nullable<int> FK_Loc_Id { get; set; }
        public string Deppart_Name { get; set; }
        public Nullable<int> FK_Depart_Id { get; set; }
        public string Pos_Name { get; set; }
        public int PK_Pos_Id { get; set; }
        public string Staff_Name { get; set; }
        public string Date_Update { get; set; }
        public string Time_Update { get; set; }
    }
}