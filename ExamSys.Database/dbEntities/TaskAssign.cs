using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class TaskAssign
    {
        [Key]
        public Task Task { get; set; }
        [Key]
        public User User { get; set; }
    }
}
