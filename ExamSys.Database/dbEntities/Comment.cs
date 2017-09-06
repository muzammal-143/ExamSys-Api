using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Comment_Type 
    {
        [Key]
        public int id { get; set; }

        //[Index(IsUnique = true)]
        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public Comment_Type()
        {
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class Comment
    {
        public int id { get; set; }
        
        [Display(Name = "Message")]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
        [Display(Name = "Assign to")]
        public int? Assign_to { get; set; }
        [Display(Name = "Parent")]
        public int? TargetId { get; set; }
        [Display(Name = "Comment Type")]
        public Comment_Type CommentType { get; set; }
        [Display(Name = "Active")]
        public bool Active { get; set; }


        public User created_by { get; set; }
        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public Comment()
        {
            Active = true;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
