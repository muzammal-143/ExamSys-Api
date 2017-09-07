using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Course : Properties
    {
        public int      id          { get; set; }

        //[Index(IsUnique = true)]
        public string   Code        { get; set; }
        public int      CH          { get; set; }
        public string   Name        { get; set; }

        

        public Course()
        {
        }
    }
}
