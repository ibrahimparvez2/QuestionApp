using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestionApp.Models
{
    public class QViewModel
    {
        //[Required]
        //[MinLength(10)]
        //[MaxLength(100)]
        [Display(Name = "Ask for magic 8 ball any question?")]
         public string Question { get; set; }

         public string Answer { get; set; }

        //public QViewModel(string question) {
        //    this.Question = question;
        //}

    }
}