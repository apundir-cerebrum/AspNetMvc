namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUserSubscription
    {
        public int Id { get; set; }

        public int? SubscriptionPlanId { get; set; }

        public int? LoginId { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public DateTime? ValidUpto { get; set; }

        public bool? IsSuspended { get; set; }

        public virtual UserLogin tblLogin { get; set; }

        public virtual tblSubscriptionPlan tblSubscriptionPlan { get; set; }
    }
}
