using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public enum ResultType
    {
        FINAL,
        MID,
        QUIZ,
        ASSIGNMENT,
        ATTENDENCE,
        PRESENTATION
    }

    public class Sheet : Properties
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        
        //Relations
        public SessionCourse Session_Course { get; set; }
        public ResultType ResultType { get; set; }

        public bool Save { get; set; }
        public bool EditAble { get; set; }
        public bool Submited { get; set; }
        public bool approved { get; set; }

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
    public class SheetResult
    {
        public int id { get; set; }
        public double Obtain { get; set; }

        // Relations
        public User Student { get; set; }
        public Sheet Sheet { get; set; }

        public SheetResult()
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
