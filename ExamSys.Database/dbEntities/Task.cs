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

        
        public TASK(USER user)
        {
            Active = true;
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class TASKStatus : Properties
    {
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        
        public TASKStatus(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    
    public class TaskAssign : Properties
    {
        public int id { get; set; }
        [Key]
        public TASK Task { get; set; }
        [Key]
        public USER User { get; set; }
        public TASKStatus Status { get; set; }
        public bool Active { get; set; }

        
        public TaskAssign(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

}
