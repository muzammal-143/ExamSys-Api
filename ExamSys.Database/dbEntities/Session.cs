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
        public Degree Degree { get; set; }
        
        public bool Active { get; set; }

        // Relatins

        public DayTiming DayTiming
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Session Session
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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

    public class SessionDegreeCourse : Properties
    {

        public int id { get; set; }
        public int Semester { get; set; }

        //Relations
        [Key]
        public DayTiming DayTiming { get; set; }
        [Key]

        public int CH { get; set; }

        public SessionDegreeCourse_ResultType SessionDegreeCourse_ResultType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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

        public Fachlty Fachlty
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SessionDegree SessionDegree
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SessionDegreeCourse()
        {
            new Properties();
        }
        public SessionDegreeCourse(User user)
        {
            new Properties(user);
        }

    }
    public class SessionDegreeCourse_ResultType : Properties
    {

        public int id { get; set; }
        public int Semester { get; set; }

        //Relations
        [Key]
        public SessionDegreeCourse SessionDegreeCourse { get; set; }
        [Key]
        public ResultType ResultType { get; set; }

        public SessionDegreeCourse_ResultType()
        {
            new Properties();
        }
        public SessionDegreeCourse_ResultType(User user)
        {
            new Properties(user);
        }

    }

    public class SessionDegreeStudent : Properties
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        // Relations
        [Key]
        public Session Session { get; set; }

        public SessionDegree SessionDegree
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
        

        public SessionDegreeStudent()
        {
            Semester = 1;
            new Properties();
        }
        public SessionDegreeStudent(User user)
        {
            Semester = 1;
            new Properties(user);
        }
    }

    public class SessionDepartment : Properties
    {
        public int Id { get; set; }

        public Session Session
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Department Department
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public SessionDepartment()
        {
            new Properties();
        }
        public SessionDepartment(User user)
        {
            new Properties(user);
        }
    }

    public class SessionDepartmentDegree : Properties
    {
        public int Id { get; set; }

        public Degree Degree
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SessionDepartment SessionDepartment
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
    }


}
