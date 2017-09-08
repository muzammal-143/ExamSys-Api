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
        COMMENT,
        COURSE,
        HISTORY,
        INVOICE,
        SEMESTER_RESULT,
        SHEET,
        TASK,
        USER

    }
    public class Comment : Properties
    {
        public int id { get; set; }
        public Comment_Type CommentType { get; set; }
        public string Message { get; set; }
        public int TargetId { get; set; }
        
        public Comment()
        {
            new Properties();
        }
    }

    public class CommentAssign
    {
        public int id { get; set; }
        [Key]
        public Comment Comment { get; set; }
        [Key]
        public User User { get; set; }
        public bool Active { get; set; }
    }
}
