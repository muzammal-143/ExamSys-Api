using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Session : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public Session(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class SessionDegree : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        // Relatins
        [Key]
        public Session Session { get; set; }
        [Key]
        public DayTime DayTiming{ get; set; }
        [Key]
        public Degree Degree{ get; set; }

        public bool Active { get; set; }
        public SessionDegree(USER user)
        {
            Active = true;
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class SessionDegreeCourse : Properties
    {

        public int id { get; set; }
        public int CH { get; set; }
        public int Semester { get; set; }

        //Relations
        [Key]
        public DayTime DayTiming { get; set; }
        public Course Course{ get; set; }
        public Faculty Fachlty{ get; set; }

        public SessionDegree SessionDegree{ get; set; }

        public ResultTypeRule ResultTypeRule{ get; set; }

        
        public SessionDegreeCourse(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }

    }
    
    public class SessionDepartment : Properties
    {
        public int Id { get; set; }
        [Key]
        public Session Session{ get; set; }
        public Department Department{ get; set; }
    
        
        public SessionDepartment(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class SessionDepartmentDegree : Properties
    {
        public int Id { get; set; }
        [Key]
        public SessionDepartment SessionDepartment { get; set; }
        [Key]
        public Degree Degree{ get; set; }
        
        public DayTime DayTiming{ get; set; }
        
        public SessionDepartmentDegree(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
        
    }

    public enum SessionPart
    {
        SEMESTER,
        SUMMER
    }


}
