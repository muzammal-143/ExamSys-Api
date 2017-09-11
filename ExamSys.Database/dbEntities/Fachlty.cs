using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Fachlty : Properties
    {

        public int Id { get; set; }
        public User User { get; set; }

        public Fachlty()
        {
            new Properties();
        }
        public Fachlty(User user)
        {
            new Properties(user);
        }
    }

    public class FacultyCourses : Properties
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        //Relation
        public Fachlty Faculty { get; set; }
        public Session Session { get; set; }
        public Department Department { get; set; }
        public Course Course { get; set; }

        public FacultyCourses()
        {
            new Properties();
        }
        public FacultyCourses(User user)
        {
            new Properties(user);
        }
    }
}
