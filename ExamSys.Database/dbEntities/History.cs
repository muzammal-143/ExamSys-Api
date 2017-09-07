using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class History : Properties
    {
        public int id { get; set; }

        [Required(ErrorMessage="Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [Display(Name = "Message")]
        public string Message { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }
        
        public History()
        {
        }
    }
}
