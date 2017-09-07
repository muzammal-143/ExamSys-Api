using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class CommentAssign
    {
        [Key]
        public Comment Comment { get; set; }
        [Key]
        public User User { get; set; }
        public bool Active { get; set; }
    }
}
