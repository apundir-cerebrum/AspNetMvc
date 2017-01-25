namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblTestResult
    {
        public int Id { get; set; }

        public int? Assignee { get; set; }

        public int? TestId { get; set; }

        public int? QuestionId { get; set; }

        public string Answer { get; set; }

        public int? MarksObtained { get; set; }

        public TimeSpan? TimeElapsed { get; set; }

        public int? AttemptNumber { get; set; }

        public DateTime? AttemptDate { get; set; }

        public virtual UserLogin tblLogin { get; set; }

        public virtual tblQuestion tblQuestion { get; set; }
    }
}
