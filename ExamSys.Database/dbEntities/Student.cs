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
        [Key]
        public User          User            { get; set; }
        public Department    Department      { get; set; }
        public Status Status { get; set; }

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
    public class StudentCourse 
    {
        public int Id { get; set; }
        [Key]
        public User User { get; set; }
        [Key]
        public Course Course { get; set; }
        public int Semester { get; set; }
        public int CH { get; set; }
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
    

}
