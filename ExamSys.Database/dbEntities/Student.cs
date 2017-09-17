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

        public DayTiming DayTiming{ get; set; }

        public Degree Degree{ get; set; }

        public StudentStatus StudentStatus{ get; set; }

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
    public class StudentCourse  : Properties
    {
        public int Id { get; set; }
        [Key]
        
        public int Semester { get; set; }
        public int CH { get; set; }

        public Course Course{ get; set; }

        public Student Student{ get; set; }

        public ResultTypeRule ResultTypeRule{ get; set; }

        public Session Session{ get; set; }

        public Faculty Fachlty{ get; set; }

        public StudentCourse_Status StudentCourse_Status{ get; set; }
        public StudentCourse()
        {
            new Properties();
        }
        public StudentCourse(User user)
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

    public class StudentDegree : Properties
    {
        public int Id{ get; set; }

        public Student Student{ get; set; }
        public Degree Degree{ get; set; }

        public DayTiming DayTiming{ get; set; }

        public StudentDegreeStatus StudentDegreeStatus{ get; set; }
        public StudentDegree()
        {
            new Properties();
        }
        public StudentDegree(User user)
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

    public class StudentSession : Properties
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        [Key]
        public Student Student{ get; set; }

        [Key]
        public Session Session{ get; set; }
        public StudentSession()
        {
            new Properties();
        }
        public StudentSession(User user)
        {
            new Properties(user);
        }
    }

    public class Registration : Properties
    {
        public User User{ get; set; }

        public Student Student{ get; set; }

        [UniqueRegistrationNo]
        public string RegistrationNo { get; set; }

        public int id { get; set; }

        public bool Active{ get; set; }
        public Registration()
        {
            new Properties();
        }
        public Registration(User user)
        {
            new Properties(user);
        }
    }

        public class StudentAddCourse : Properties
    {
        public int id { get; set; }

        public StudentCourse StudentCourse{ get; set; }

        public int SessionPartValue{ get; set; }

        public SessionPart SessionPart{ get; set; }

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
    public class StudentResit : Properties
    {
        public StudentCourse StudentCourse{ get; set; }

        public int id { get; set; }

        public SessionPart SessionPart{ get; set; }

        public int SessionPartValue{ get; set; }

        public ResultType ResultType{ get; set; }
        public StudentResit()
        {
            new Properties();
        }
        public StudentResit(User user)
        {
            new Properties(user);
        }
    }


}
