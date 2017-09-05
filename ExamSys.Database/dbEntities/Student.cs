using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Student
    {
        
        [Key]
        public int          id { get; set; }
        [Index(IsUnique = true)]
        public string       Roll_No         { get; set; }
        [Index(IsUnique = true)]
        public string RegistrationNo { get; set; }
        public string       Session         { get; set; }
        public int          Semester        { get; set; }

        //Relations
        public User          User            { get; set; }
        public Department    Department      { get; set; }


        public User created_by { get; set; }
        // Timestamp
        [Display(Name = "Created at")]
        [Required(ErrorMessage="Created at DateTime is required.")]
        public DateTime created_at{ get; set; }

        [Display(Name = "Edited at")]
        [Required(ErrorMessage = "Edited at DateTime is required.")]
        public DateTime edited_at { get; set; }

        public Student()
        {
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }


    }
}
