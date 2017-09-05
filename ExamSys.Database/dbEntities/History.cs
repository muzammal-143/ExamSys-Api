using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class History
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
        
        [Display(Name = "Created by")]
        public User Created_by { get; set; }
        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public History()
        {
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
