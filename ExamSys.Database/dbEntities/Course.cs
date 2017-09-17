using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Course : Properties
    {
        public int      id          { get; set; }
        [Key]
        public string   Code        { get; set; }
        public string   Name        { get; set; }
        public int CH { get; set; }

        public Course()
        {
            new Properties();
        }
        public Course(User user)
        {
            new Properties(user);
        }
    }
}
