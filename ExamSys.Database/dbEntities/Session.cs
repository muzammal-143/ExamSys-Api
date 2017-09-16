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

        public Faculty Fachlty
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

        public ResultTypeRule ResultTypeRule
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
        public History()
        {
            new Properties();
        }
        public History(User user)
        {
            new Properties(user);
        }
        
    }

    public enum SessionPart
    {
        SEMESTER,
        SUMMER
    }


}
