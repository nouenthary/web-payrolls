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
    
    public partial class tblNotification
    {
        public long PK_Notification_ID { get; set; }
        public Nullable<long> FK_Staff_Id { get; set; }
        public string Link { get; set; }
        public string Notification { get; set; }
        public string Notification_Pending { get; set; }
        public string Date_Update { get; set; }
        public string Time_Update { get; set; }
        public string Option_Key { get; set; }
    
        public virtual tblStaff tblStaff { get; set; }
    }
}
