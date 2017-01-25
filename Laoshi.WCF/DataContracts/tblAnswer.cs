namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblAnswer
    {
        public int Id { get; set; }

        public int? QuestionId { get; set; }

        public int? AnswerType { get; set; }

        public string Answertext { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsCorrectAnswer { get; set; }

        public virtual tblQuestion tblQuestion { get; set; }
    }
}
