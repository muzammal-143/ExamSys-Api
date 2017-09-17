using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{

    public class File : Properties
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Table { get; set; }
        public int TableId { get; set; }

        public File()
        {
            new Properties();
        }
        public File(User user)
        {
            new Properties(user);
        }
    }
}
