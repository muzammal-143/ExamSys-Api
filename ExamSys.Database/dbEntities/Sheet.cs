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
        
        //Relations
        public Session_Course Session_Course { get; set; }
        public Result_Type Result_Type { get; set; }

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
        }
    }

    public class SheetApprove : Properties
    {
        public int id { get; set; }
        [Key]
        public Sheet Sheet { get; set; }
        [Key]
        public User User { get; set; }
        public SheetApprove()
        {
        }
    }

}
