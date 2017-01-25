namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAnswer")]
    public partial class tblAnswer
    {
        public int Id { get; set; }

        public int? QuestionId { get; set; }

        public int? AnswerType { get; set; }

        [StringLength(1000)]
        public string Answertext { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsCorrectAnswer { get; set; }

        public virtual tblQuestion tblQuestion { get; set; }
    }
}
