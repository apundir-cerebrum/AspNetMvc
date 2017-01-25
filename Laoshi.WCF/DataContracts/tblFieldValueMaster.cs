namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblFieldValueMaster
    {
        public tblFieldValueMaster()
        {
            tblFieldValueMaster1 = new HashSet<tblFieldValueMaster>();
            tblQuestions = new HashSet<tblQuestion>();
            tblQuestions1 = new HashSet<tblQuestion>();
            tblQuestions2 = new HashSet<tblQuestion>();
            tblSubscriptionPlans = new HashSet<tblSubscriptionPlan>();
            tblSubscriptionPlans1 = new HashSet<tblSubscriptionPlan>();
            tblSubscriptionPlans2 = new HashSet<tblSubscriptionPlan>();
            tblTestTemplates = new HashSet<tblTestTemplate>();
            tblTestTemplates1 = new HashSet<tblTestTemplate>();
        }

        public int Id { get; set; }

        public int? FieldId { get; set; }

        public string FieldValueName { get; set; }

        public int? Parentid { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public virtual tblFieldMaster tblFieldMaster { get; set; }

        public virtual ICollection<tblFieldValueMaster> tblFieldValueMaster1 { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster2 { get; set; }

        public virtual ICollection<tblQuestion> tblQuestions { get; set; }

        public virtual ICollection<tblQuestion> tblQuestions1 { get; set; }

        public virtual ICollection<tblQuestion> tblQuestions2 { get; set; }

        public virtual ICollection<tblSubscriptionPlan> tblSubscriptionPlans { get; set; }

        public virtual ICollection<tblSubscriptionPlan> tblSubscriptionPlans1 { get; set; }

        public virtual ICollection<tblSubscriptionPlan> tblSubscriptionPlans2 { get; set; }

        public virtual ICollection<tblTestTemplate> tblTestTemplates { get; set; }

        public virtual ICollection<tblTestTemplate> tblTestTemplates1 { get; set; }
    }
}
