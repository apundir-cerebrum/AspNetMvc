namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblUserPaymentInfo
    {
        public int Id { get; set; }

        public int? LoginId { get; set; }

        public string AccountID { get; set; }

        public bool? IsBusinessAccount { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual UserLogin tblLogin { get; set; }
    }
}
