using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public enum Comment_Type
    {
        COMMENT         = 1,
        COURSE          = 2,
        HISTORY         = 3,
        INVOICE         = 4,
        SEMESTER_RESULT = 5,
        TASK            = 6,
        USER            = 7,

    }
    public class Comment : Properties
    {
        public int id { get; set; }
        public Comment_Type CommentType { get; set; }
        public string Message { get; set; }
        public int TargetId { get; set; }
        
        public Comment()
        {
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
