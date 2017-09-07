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
    public class Task : Properties
    {
        public int id { get; set; }
        public string Description { get; set; }
        
        public User assign_to { get; set; }
        public TaskStatus Status { get; set; }
        public bool       Active { get; set; }


       

        public Task()
        {
            Status = TaskStatus.START;
            Active = true;
        }
    }
}
