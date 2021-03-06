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
    
    public partial class tblDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartment()
        {
            this.tblPositions = new HashSet<tblPosition>();
            this.tblStockBalanceInventoryInDepartments = new HashSet<tblStockBalanceInventoryInDepartment>();
            this.tblStockinventoryOnDepartments = new HashSet<tblStockinventoryOnDepartment>();
        }
    
        public int PK_Depart_Id { get; set; }
        public Nullable<int> FK_Loc_Id { get; set; }
        public string Deppart_Name { get; set; }
        public string Descr { get; set; }
        public Nullable<int> User_Update { get; set; }
        public string Date_Update { get; set; }
        public string Time_Update { get; set; }
        public Nullable<int> Number_Staff_Transaction { get; set; }
    
        public virtual tblLocation tblLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPosition> tblPositions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStockBalanceInventoryInDepartment> tblStockBalanceInventoryInDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStockinventoryOnDepartment> tblStockinventoryOnDepartments { get; set; }
    }
}
