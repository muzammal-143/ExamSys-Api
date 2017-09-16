using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ExamSys.Database
{
    public class Activity : Properties
    {
        public string Description { get; set; }

        public int Id { get; set; }

        [Key]
        public string Title { get; set; }
    }
}
