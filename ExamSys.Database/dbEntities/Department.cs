using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Department : Properties
    {
        public int id { get; set; }

        //[Index("Short Name", Order = 1, IsUnique = true)]
        public string   ShortName       { get; set; }
        public string   FullName        { get; set; }
        public int      TotalSemesters  { get; set; }
        public string   Color           { get; set; }
        
        //Relation
        public Degree Degree { get; set; }
        public DayTiming DayTiming { get; set; }




        public Department()
        {
        }
    }



}

