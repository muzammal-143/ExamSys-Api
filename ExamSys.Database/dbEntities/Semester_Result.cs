using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Semester_Result : Properties
    {
        public int          id          { get; set; }

        [Display(Name = "Total Marks")]
        public double       TM          { get; set; }
        [Display(Name = "Obtain Marks")]
        public double       OM          { get; set; }
        
        public string Session { get; set; }
        public int Semester { get; set; }

        //Relations
        [Display(Name = "Student")]
        public User      Student     { get; set; }
        [Display(Name = "Department")]
        public Department    Department  { get; set; }
        [Display(Name = "Course")]
        public Course       Course      { get; set; }
        [Display(Name = "Result Type")]
        public Result_Type  Result_Type { get; set; }
        
        //public int Status { get; set; }


        public Semester_Result()
        {
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
        
    }
}
