using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Grades : Properties
    {
        public int      id          { get; set; }
        public double   Lower_Range { get; set; }
        public double   Upper_Range { get; set; }
        public double   Points      { get; set; }
        public string   Grade       { get; set; }

        // Relation
        public GradeRule GradeRule { get; set; }
        public Grades()
        {
        }
    }
}
