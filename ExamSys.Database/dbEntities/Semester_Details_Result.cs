using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Semester_Details_Result
    {
        public int           id          { get; set; }
        public double        Total       { get; set; }
        public double        Obtain      { get; set; }

        // Relations
        public User Student { get; set; }
        public Sheet Sheet { get; set; }

        public Semester_Details_Result()
        {
        }
    }

}
