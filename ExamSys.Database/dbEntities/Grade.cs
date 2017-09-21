using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class GradeRule : Properties
    {
        [Index("Id", IsUnique = true)]   
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

    
        
        public GradeRule(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    public class Grade : Properties
    {
        [Key]
        public int      Id          { get; set; }
        public double   Lower_Range { get; set; }
        public double   Upper_Range { get; set; }
        public double   Points      { get; set; }
        public string grade { get; set; }

        // Relation
        public GradeRule GradeRule { get; set; }

        
        public Grade(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }

    }


}
