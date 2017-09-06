using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Department
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


        public User created_by { get; set; }
        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public Department()
        {
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }



}

