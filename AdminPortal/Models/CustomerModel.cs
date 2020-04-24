using System;

namespace AdminPortal.Models
{
    public class CustomerModel
    {
        public long Id { get; set; }
        public string ProductCategory { get; set; }
        public string Conditions_Allowed { get; set; }
        public string Approval_Required { get; set; }

    
    }
}
