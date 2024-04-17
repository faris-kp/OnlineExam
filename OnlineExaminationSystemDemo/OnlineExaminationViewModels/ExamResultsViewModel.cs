using OnlineExamination.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class ExamResultsViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public int StudentsId { get; set; }
        [Required]
        [Display(Name = "Exam Name")]
        public int ExamId { get; set; }
      
        public int QnAsId { get; set; }
      
        public int Answer { get; set; }
        List<ExamResultsViewModel> ListOfResults { get; set; }
        public int TotalCount { get; set; } 
        public ExamResultsViewModel(ExamResults model)
        {
            Id = model.Id;
            StudentsId = model.StudentsId;
            ExamId = model.ExamId;
            QnAsId = model.QnAsId;
            Answer = model.Answer;

        }
        public ExamResults ConvertViewModel(ExamResultsViewModel vm)
        {
            return new ExamResults
            {
                Id = vm.Id,
                StudentsId = vm.StudentsId,
                ExamId = vm.ExamId,
                QnAsId = vm.QnAsId,
                Answer = vm.Answer
            };
        }
    }
    
}
