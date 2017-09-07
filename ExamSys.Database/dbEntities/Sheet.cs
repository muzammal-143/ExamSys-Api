using System;
using System.Collections.Generic;
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

        public int Session { get; set; }
        public int Semester { get; set; }
        //Relations
        public Department Department { get; set; }
        public Course Course { get; set; }
        public Result_Type Result_Type { get; set; }

        public bool Save { get; set; }
        public bool EditAble { get; set; }
        public bool Submited { get; set; }

        public Sheet()
        {
            Save = true;
            EditAble = true;
            Submited = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
