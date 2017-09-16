using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Faculty : Properties
    {

        public int Id { get; set; }

        public FacultyCourse FacultyCourses
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public User User
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool Active { get; set; }

        public Faculty()
        {
            new Properties();
        }
        public Faculty(User user)
        {
            new Properties(user);
        }
    }

    public class FacultyCourse : Properties
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        //Relation
        public Faculty Faculty { get; set; }
        public Session Session { get; set; }
        public Department Department { get; set; }

        public Course Course
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        

        public FacultyCourse()
        {
            new Properties();
        }
        public FacultyCourse(User user)
        {
            new Properties(user);
        }
    }
}
