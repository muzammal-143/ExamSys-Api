using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Semester_Details_Result : Properties
    {
        public int           id          { get; set; }
        public double        Total       { get; set; }
        public double        Obtain      { get; set; }
        
        public bool          Save        { get; set; }
        public bool          EditAble    { get; set; }
        public bool          Submited    { get; set; }

        public int Session               { get; set; }
        public int Semester              { get; set; }
        //Relations
        public User          Student     { get; set; }
        public Department    Department  { get; set; }
        public Course       Course      { get; set; }
        public Result_Type   Result_Type { get; set; }

        public User          created_by  { get; set; }
        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public Semester_Details_Result()
        {
            Save = true;
            EditAble = true;
            Submited = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

}
