using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class StudentAddCourse : Properties
    {
        public int id { get; set; }

        //Relations
        public Course Course { get; set; }

        public User User { get; set; }

        public StudentAddCourse()
        {
            new Properties();
        }
        public StudentAddCourse(User user)
        {
            new Properties(user);
        }

    }
}
