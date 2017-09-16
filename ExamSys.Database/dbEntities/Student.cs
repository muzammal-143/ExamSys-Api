using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Student : Properties
    {
        
        public int          id { get; set; }
        [UniqueRollNo]
        public string RollNo { get; set; }
        //Relations
        public Status Status { get; set; }

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

        public StudentStatus StudentStatus
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Student()
        {
            new Properties();
        }
        public Student(User user)
        {
            new Properties(user);
        }


    }


    public enum StudentCourse_Status 
    {
        ACTIVE,
        PASS,
        DROP,
    }
    public class StudentCourse 
    {
        public int Id { get; set; }
        [Key]
        
        public int Semester { get; set; }
        public int CH { get; set; }

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

        public StudentCourse_Status StudentCourse_Status
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

    // Validation
    public class UniqueRollNo : ValidationAttribute
    {
        public ExamDB db = new ExamDB();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                Student student = db.Student.Where(m => m.RollNo == value).FirstOrDefault();
                if (student != null)
                {
                    return new ValidationResult("Error | Already exists");
                }
                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message);
            }
        }
    }
    public class UniqueRegistrationNo : ValidationAttribute
    {
        public ExamDB db = new ExamDB();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                Student student = db.Student.Where(m => m.RegistrationNo == value).FirstOrDefault();
                if (student != null)
                {
                    return new ValidationResult("Error | Already exists");
                }
                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message);
            }
        }
    }

    public class StudentDegree
    {
        public int Id
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

        public StudentDegreeStatus StudentDegreeStatus
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

    public enum StudentStatus
    {
        ACTIVE,
        COMPLETED,
        FREEZE,
    }

    public class StudentSession
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        [Key]
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

        [Key]
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
        public History()
        {
            new Properties();
        }
        public History(User user)
        {
            new Properties(user);
        }
    }

    public class Registration
    {
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

        [UniqueRegistrationNo]
        public string RegistrationNo { get; set; }

        public int id { get; set; }

        public int Active
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

        public class StudentAddCourse : Properties
    {
        public int id { get; set; }

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

        //Relations

        public StudentAddCourse()
        {
            new Properties();
        }
        public StudentAddCourse(User user)
        {
            new Properties(user);
        }

    }
    public class StudentResit
    {
        public ExamSys.Database.dbEntities.StudentCourse StudentCourse
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int id { get; set; }

        public ExamSys.Database.dbEntities.SessionPart SessionPart
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

        public ExamSys.Database.dbEntities.ResultType ResultType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
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
