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
        public Session Session { get; set; }
        public int Semester { get; set; }

        //Relations
        public Department Department { get; set; }
        public Course Course { get; set; }

        public User User { get; set; }

        public StudentAddCourse()
        {
            created_at = DateTime.Now;
            edited_at  = DateTime.Now;
        }

    }
}
