using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class DayTiming : Properties
    {
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        public DayTiming()
        {
            new Properties();
        }
        public DayTiming(User user)
        {
            new Properties(user);
        }
    }

}
