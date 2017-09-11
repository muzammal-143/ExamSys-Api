using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Session : Properties
    {
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public Session()
        {
            new Properties();
        }
        public Session(User user)
        {
            new Properties(user);
        }
    }

    public class SessionDegree : Properties
    {
        public int id { get; set; }
        [Key]
        public Session Session { get; set; }
        [Key]
        public Degree Degree { get; set; }
        
        public bool Active { get; set; }

        public SessionDegree()
        {
            Active = true;
            new Properties();
        }
        public SessionDegree(User user)
        {
            Active = true;
            new Properties(user);
        }
    }

    public class SessionCourse : Properties
    {

        public int id { get; set; }
        public int Semester { get; set; }

        //Relations
        [Key]
        public Session Session { get; set; }
        public Department Department { get; set; }
        [Key]
        public Course Course { get; set; }



        public SessionCourse()
        {
            new Properties();
        }
        public SessionCourse(User user)
        {
            new Properties(user);
        }

    }

    public class SessionStudent : Properties
    {
        public int Id { get; set; }
        [Key]
        public Student Student { get; set; }
        [Key]
        public Session Session { get; set; }
        public int Semester { get; set; }

        public SessionStudent()
        {
            Semester = 1;
            new Properties();
        }
        public SessionStudent(User user)
        {
            Semester = 1;
            new Properties(user);
        }
    }


}
