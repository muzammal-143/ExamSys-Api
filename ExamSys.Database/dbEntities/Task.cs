using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class TaskStatus : Properties
    {
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        
        public TaskStatus()
        {
            new Properties();
        }
        public TaskStatus(User user)
        {
            new Properties(user);
        }
    }

    public class Task : Properties
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public bool       Active { get; set; }

        public Task()
        {
            Active = true;
            new Properties();
        }
        public Task(User user)
        {
            Active = true;
            new Properties(user);
        }
    }

    public class TaskAssign : Properties
    {
        public int id { get; set; }
        [Key]
        public Task Task { get; set; }
        [Key]
        public User User { get; set; }
        public TaskStatus Status { get; set; }
        public bool Active { get; set; }
        
        public TaskAssign()
        {
            new Properties();
        }
        public TaskAssign(User user)
        {
            new Properties(user);
        }
    }


}
