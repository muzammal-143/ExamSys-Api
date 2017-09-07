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
    public class Student : Properties
    {
        
        [Key]
        public int          id { get; set; }
        
        public string       Roll_No         { get; set; }
        //[Index(IsUnique = true)]
        public string RegistrationNo { get; set; }
        public string       Session         { get; set; }
        public int          Semester        { get; set; }

        //Relations
        public User          User            { get; set; }
        public Department    Department      { get; set; }


        public Student()
        {
        }


    }
}
