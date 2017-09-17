using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{

    public class TASK : Properties
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public TASKStatus TaskStatus { get; set; }

        public TASK()
        {
            Active = true;
            new Properties();
        }
        public TASK(User user)
        {
            Active = true;
            new Properties(user);
        }
    }

    public class TASKStatus : Properties
    {
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        public TASKStatus()
        {
            new Properties();
        }
        public TASKStatus(User user)
        {
            new Properties(user);
        }
    }
    
    public class TaskAssign : Properties
    {
        public int id { get; set; }
        [Key]
        public TASK Task { get; set; }
        [Key]
        public User User { get; set; }
        public TASKStatus Status { get; set; }
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
