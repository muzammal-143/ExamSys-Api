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
        public string       RollNo         { get; set; }
        [UniqueRegistrationNo]
        public string RegistrationNo { get; set; }

        //Relations
        public Department    Department      { get; set; }
        public Status Status { get; set; }

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

        public Student()
        {
            new Properties();
        }
        public Student(User user)
        {
            new Properties(user);
        }


    }


    public class Status : Properties
    {
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public Status()
        {
            new Properties();
        }
        public Status(User user)
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
    public class StudentDegreeCourse 
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

        public StudentDegree StudentDegree
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
    }
    

}
