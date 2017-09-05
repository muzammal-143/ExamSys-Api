using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public enum TaskStatus
    {
        START,
        COMPLETE,
        PENDING,
        DELAY
    } 
    public class Task
    {
        public int id { get; set; }
        public string Description { get; set; }
        
        public User assign_to { get; set; }
        public TaskStatus Status { get; set; }
        public bool       Active { get; set; }


        public User created_by { get; set; }
        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        

        public Task()
        {
            Status = TaskStatus.START;
            Active = true;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
