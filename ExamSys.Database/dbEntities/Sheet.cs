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
        public Session Session { get; set; }
        public Degree Degree { get; set; }
        public DayTime DayTiming { get; set; }
        public StudentCourse StudentCourse { get; set; }
        public ResultType ResultType { get; set; }
        public Faculty Fachlty { get; set; }
        public SessionPart SessionPart { get; set; }
        public int SessionPartValue { get; set; }
        public bool Resit { get; set; }

        public bool Save { get; set; }
        public bool EditAble { get; set; }
        public bool Submited { get; set; }
        public bool approved { get; set; }

       

        
        public Sheet(USER user)
        {
            Save = true;
            EditAble = true;
            Submited = false;
            approved = false;
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class SheetMarks : Properties
    {
        public int id { get; set; }
        public double Obtain { get; set; }
        // Relations
        public Student Student { get; set; }
        public Sheet Sheet { get; set; }
        
        public SheetMarks(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class SheetApprove : Properties
    {
        public int id { get; set; }
        [Key]
        public USER User { get; set; }
        [Key]
        public Sheet Sheet { get; set; }
    
        
        public SheetApprove(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

}
