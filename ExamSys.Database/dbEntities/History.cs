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
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage="Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public string Table { get; set; }
        public int TableId { get; set; }
        
        public History()
        {
            new Properties();
        }
        public History(User user)
        {
            new Properties(user);
        }

    }
}
