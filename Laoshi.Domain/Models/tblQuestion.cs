namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuestion")]
    public partial class tblQuestion
    {
        public tblQuestion()
        {
            tblAnswers = new HashSet<tblAnswer>();
            tblTestResults = new HashSet<tblTestResult>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string QuestionTitle { get; set; }

        public int? QuestionPoints { get; set; }

        public int? QuestionCategory { get; set; }

        public int? QuestionArea { get; set; }

        public int? QuestionComplexity { get; set; }

        public int? AnswerSelection { get; set; }

        [StringLength(10)]
        public string IsRandomAnswer { get; set; }

        public TimeSpan? PlannedTimeToAnswer { get; set; }

        public int? NegativeMarkingPercentage { get; set; }

        public virtual ICollection<tblAnswer> tblAnswers { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster1 { get; set; }

        public virtual tblFieldValueMaster tblFieldValueMaster2 { get; set; }

        public virtual ICollection<tblTestResult> tblTestResults { get; set; }
    }
}
