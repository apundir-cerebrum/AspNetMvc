namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblSubscriptionPlan
    {
        public tblSubscriptionPlan()
        {
            tblUserSubscriptions = new HashSet<tblUserSubscription>();
        }

        public int Id { get; set; }

        public string SubscriptionTitle { get; set; }

        public int? SubscriptionType { get; set; }

        public int? MaxAssignees { get; set; }

        public int? MaxTests { get; set; }

        public decimal? SubscriptionPrice { get; set; }

        public bool? IsTestCreator { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster1 { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster2 { get; set; }

        public virtual ICollection<tblUserSubscription> tblUserSubscriptions { get; set; }
    }
}
