using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    
    public class Comment : Properties
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Table { get; set; }
        public int TableId { get; set; }

        public History()
        {
            new Properties();
        }
        public History(User user)
        {
            new Properties(user);
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
        public History()
        {
            new Properties();
        }
        public History(User user)
        {
            new Properties(user);
        }
    }
}
