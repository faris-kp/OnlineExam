﻿using OnlineExamination.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class QnAsViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Exam")]
        public int ExamsId { get; set; }

        [Required]
        [Display(Name = "Question")]
        public string Question { get; set; }

        [Required]
        [Display(Name = "Answer")]
        public int Answer { get; set; }
        [Required]
        [Display(Name = "Option 1")]
        public string Option1 { get; set; }
        [Required]
        [Display(Name = "Option 2")]
        public string Option2 { get; set; }
        [Required]
        [Display(Name = "Option 3")]
        public string Option3 { get; set; }
        [Required]
        [Display(Name = "Option 4")]
        public string Option4 { get; set; }

        public List<QnAsViewModel> QnAsList { get; set; }   
        public  IEnumerable<Exams> ExamLIst { get; set; }
        public int TotalCount { get; set; } 
        public int SelectedAnswer { get; set; }

        public QnAsViewModel(QnAs model)
        {
             Id = model.Id;
            Question = model.Question ?? "";
            Answer = model.Answer;
            Option1 = model.Option1 ?? "";    
            Option2 = model.Option2 ?? "";
            Option3 = model.Option3 ?? "";
            Option4 = model.Option4 ?? "";

        }
        public QnAs ConvertViewModel(QnAsViewModel vm)
        {
            return new QnAs
            {

            Id = vm.Id,
            Question = vm.Question ?? "",
            Answer = vm.Answer,
            Option1 = vm.Option1 ?? "",
            Option2 = vm.Option2 ?? "",
            Option3 = vm.Option3 ?? "",
            Option4 = vm.Option4 ?? "",

        };

        }

    }
}
