//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamOnline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamAnswer
    {
        public int ID { get; set; }
        public int ExamID { get; set; }
        public int AnswerID { get; set; }
        public System.DateTime InsertionTime { get; set; }
    
        public virtual Answer Answer { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
