using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Session_Course : Properties
    {   

        public int         id            { get; set; }
        public int         Semester      { get; set; }

        //Relations
        [Key]
        public Session Session { get; set; }
        public Department    Department  { get; set; }
        [Key]
        public Course       Course      { get; set; }


        
        public Session_Course()
        {
        }

    }
}
