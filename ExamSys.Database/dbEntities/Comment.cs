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
        public string Description { get; set; }
        public string Table { get; set; }
        public int TableId { get; set; }

        public Comment()
        {
            new Properties();
        }
        public Comment(User user)
        {
            new Properties(user);
        }
    }

}
