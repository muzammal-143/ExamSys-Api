using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class GradeRule : Properties
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Grades Grades { get; set; }
    
        public GradeRule()
        {
            new Properties();
        }
        public GradeRule(User user)
        {
            new Properties(user);
        }
    }
    public class Grades : Properties
    {
        public int      id          { get; set; }
        public double   Lower_Range { get; set; }
        public double   Upper_Range { get; set; }
        public double   Points      { get; set; }
        public string Grade { get; set; }

        // Relation
    
        public Grades()
        {
            new Properties();
        }
        public Grades(User user)
        {
            new Properties(user);
        }
    }
}
