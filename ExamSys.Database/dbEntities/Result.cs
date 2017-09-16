using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Result
    {
        public int           id          { get; set; }
        public double        Obtain      { get; set; }

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

        public ResultType ResultType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public StudentCourse StudentCourse
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int SessionPartValue
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SessionPart SessionPart
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // Relations

        public History()
        {
            new Properties();
        }
        public History(User user)
        {
            new Properties(user);
        }
    }

}
