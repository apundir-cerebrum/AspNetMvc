namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTestResult")]
    public partial class tblTestResult
    {
        public int Id { get; set; }

        public int? Assignee { get; set; }

        public int? TestId { get; set; }

        public int? QuestionId { get; set; }

        [StringLength(1000)]
        public string Answer { get; set; }

        public int? MarksObtained { get; set; }

        public TimeSpan? TimeElapsed { get; set; }

        public int? AttemptNumber { get; set; }

        public DateTime? AttemptDate { get; set; }

        public virtual UserLogin tblLogin { get; set; }

        public virtual tblQuestion tblQuestion { get; set; }
    }
}
