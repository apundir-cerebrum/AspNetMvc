namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserPaymentInfo")]
    public partial class tblUserPaymentInfo
    {
        public int Id { get; set; }

        public int? LoginId { get; set; }

        [StringLength(300)]
        public string AccountID { get; set; }

        public bool? IsBusinessAccount { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual UserLogin tblLogin { get; set; }
    }
}
