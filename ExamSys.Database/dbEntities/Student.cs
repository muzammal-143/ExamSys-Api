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


    public enum Student_Status
    {
        ACTIVE,
        COMPLETED,
        FREEZE,
    }
    public enum StudentDegree_Status
    {
        ACTIVE,
        PASS,
        DROP,
    }
    public enum StudentSession_Status
    {
        ACTIVE,
        COMPLETED,
        FREEZE,
    }
    public enum StudentCourse_Status
    {
        ACTIVE,
        PASS,
        DROP,
    }


    public class Student : Properties
    {
        public int          id { get; set; }
        [Key]
        public string RollNo { get; set; }

        //Relations
        public DayTime DayTime { get; set; }
        public Degree Degree{ get; set; }
        public Student_Status Status{ get; set; }

        public Student()
        {
            new Properties();
        }
        public Student(User user)
        {
            new Properties(user);
        }


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
    public class StudentDegree : Properties
    {
        public int Id{ get; set; }

        public Student Student{ get; set; }
        public Degree Degree{ get; set; }

        public DayTime DayTiming{ get; set; }

        public StudentDegree_Status Status{ get; set; }
        public StudentDegree()
        {
            new Properties();
        }
        public StudentDegree(User user)
        {
            new Properties(user);
        }
    }
    public class StudentSession : Properties
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        // Relations
        [Key]
        public Student Student{ get; set; }
        [Key]
        public Session Session{ get; set; }
        public StudentSession_Status Status { get; set; }

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
        public int id { get; set; }
        [Key]
        public string RegistrationNo { get; set; }
        public User User{ get; set; }
        public Student Student{ get; set; }
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
        //Relations
        public StudentCourse StudentCourse{ get; set; }
        public SessionPart SessionPart { get; set; }
        public int SessionPartValue { get; set; }

        
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
        public int id { get; set; }

        //Relations
        public StudentCourse StudentCourse { get; set; }
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
