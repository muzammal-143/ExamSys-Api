using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Faculty : Properties
    {
        [Key]
        public int Id { get; set; }
        public USER User { get; set; }
        public bool Active { get; set; }

        
        public Faculty(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class FacultyCourse : Properties
    {
        public int Id { get; set; }
        public int Semester { get; set; }

        //Relation
        public Faculty Faculty { get; set; }
        public Session Session { get; set; }
        public SessionDegree SessionDegree { get; set; }
        public DayTime DayTime { get; set; }
        public Department Department { get; set; }
        public SessionPart SessionPart { get; set; }
        public int SessionPartValue { get; set; }
        public bool Resit { get; set; }
        public Course Course { get; set; }
        
        
        public FacultyCourse(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

}
