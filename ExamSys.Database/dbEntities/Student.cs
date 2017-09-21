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
        ACTIVE=1,
        COMPLETED=2,
        FREEZE=3,
    }
    public enum StudentDegree_Status
    {
        ACTIVE=1,
        PASS=2,
        DROP=3,
    }
    public enum StudentSession_Status
    {
        ACTIVE=1,
        COMPLETED=2,
        FREEZE=3,
    }
    public enum StudentCourse_Status
    {
        ACTIVE=1,
        PASS=2,
        DROP=3,
    }


    public class Student : Properties
    {
        [Index("Id", IsUnique = true)]
        public int          id { get; set; }
        [Key]
        public string RollNo { get; set; }

        //Relations
        public DayTime DayTime { get; set; }
        public Degree Degree{ get; set; }
        public Student_Status Status{ get; set; }

        
        public Student(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }


    }
    public class StudentCourse  : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        public int CH { get; set; }
        public int Semester { get; set; }
        [Key]
        public Student Student { get; set; }
        [Key]
        public Course Course{ get; set; }
        
        public ResultTypeRule ResultTypeRule{ get; set; }

        public Session Session{ get; set; }

        public Faculty Fachlty{ get; set; }

        public StudentCourse_Status StudentCourse_Status{ get; set; }
        
        public StudentCourse(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class StudentDegree : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id{ get; set; }

        public Student Student{ get; set; }
        public Degree Degree{ get; set; }

        public DayTime DayTiming{ get; set; }

        public StudentDegree_Status Status{ get; set; }
        
        public StudentDegree(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class StudentSession : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        public int Semester { get; set; }

        // Relations
        [Key]
        public Student Student{ get; set; }
        [Key]
        public Session Session{ get; set; }
        public StudentSession_Status Status { get; set; }

        
        public StudentSession(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class Registration : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        [Key]
        public string RegistrationNo { get; set; }
        public USER User{ get; set; }
        public Student Student{ get; set; }
        public bool Active{ get; set; }
        
        public Registration(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class StudentAddCourse : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        //Relations
        public StudentCourse StudentCourse{ get; set; }
        public SessionPart SessionPart { get; set; }
        public int SessionPartValue { get; set; }

        
        
        public StudentAddCourse(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }

    }
    public class StudentResit : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }

        //Relations
        public StudentCourse StudentCourse { get; set; }
        public SessionPart SessionPart{ get; set; }
        public int SessionPartValue{ get; set; }
        public ResultType ResultType{ get; set; }

        
        public StudentResit(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    


}
