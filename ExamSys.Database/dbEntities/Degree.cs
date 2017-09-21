using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{

    public class Degree : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Years { get; set; }
        public int TotalSemesters { get; set; }

        //Relations
        public DegreeLevel DegreeLevel { get; set; }

        public Degree(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }


    public class DegreeLevel : Properties
    {
        [Index("Id", IsUnique = true)]
        public int id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        
        public DegreeLevel(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
    
    
}
