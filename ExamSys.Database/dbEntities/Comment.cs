using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public enum CommentType
    {
        COMMENT,
        COURSE,
        HISTORY,
        INVOICE,
        POST,
        RESULT,
        SHEET,
        TASK,
        USER

    }
    public class Comment : Properties
    {
        public int id { get; set; }
        public CommentType CommentType { get; set; }
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
        public User User { get; set; }
        public bool Active { get; set; }

        public Comment Comment
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
