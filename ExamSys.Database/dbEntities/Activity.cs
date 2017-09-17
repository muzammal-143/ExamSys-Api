using ExamSys.Database.dbEntities;
using ExamSys.Database.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ExamSys.Database
{
    public class Activity : Properties
    {
        
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        public Activity()
        {
            new Properties();
        }
        public Activity(User user)
        {
            new Properties(user);
        }

    }
}
