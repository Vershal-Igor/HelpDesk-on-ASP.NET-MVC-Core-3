using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWebApplication.Models
{
    public class Request
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Название заявки")]
        [MaxLength(50, ErrorMessage = "Превышена максимальная длина записи")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Описание")]
        [MaxLength(200, ErrorMessage = "Превышена максимальная длина записи")]
        public string Description { get; set; }
        
        [Display(Name = "Комментарий")]
        [MaxLength(200, ErrorMessage = "Превышена максимальная длина записи")]
        public string Comment { get; set; }
        
        [Display(Name = "Статус")]
        public int Status { get; set; }
        
        [Display(Name = "Приоритет")]
        public int Priority { get; set; }
       
        [Display(Name = "Кабинет")]
        public int? ActivId { get; set; }
        public Activ Activ { get; set; }
        
        [Display(Name = "Файл с ошибкой")]
        public string File { get; set; }

        [Display(Name = "Категория")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? ExecutorId { get; set; }
        public User Executor { get; set; }
        public int LifecycleId { get; set; }
        public Lifecycle Lifecycle { get; set; }
        public enum RequestStatus
        {
            Open = 1,
            Distributed = 2,
            Proccesing = 3,
            Checking = 4,
            Closed = 5
        }

        public enum RequestPriority
        {
            Low = 1,
            Medium = 2,
            High = 3,
            Critical = 4
        }
    }
}
