using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{


    public class Sheet : Properties
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }

        //Relations

        public bool Save { get; set; }
        public bool EditAble { get; set; }
        public bool Submited { get; set; }
        public bool approved { get; set; } // Summer or Semester // if summer then StateAct will be year else Semester#

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

        public bool Resit { get; set; }

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

        public Sheet()
        {
            Save = true;
            EditAble = true;
            Submited = false;
            approved = false;
            new Properties();
        }
        public Sheet(User user)
        {
            Save = true;
            EditAble = true;
            Submited = false;
            approved = false;
            new Properties(user);
        }
    }
    public class SheetMarks
    {
        public int id { get; set; }
        public double Obtain { get; set; }

        // Relations
        public Sheet Sheet
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

        public SheetMarks()
        {
        }
    }
    public class SheetApprove : Properties
    {
        public int id { get; set; }
        [Key]
        public User User { get; set; }

        public Sheet Sheet
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public SheetApprove()
        {
            new Properties();
        }
        public SheetApprove(User user)
        {
            new Properties(user);
        }
    }

}
