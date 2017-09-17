using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ExamSys.Database
{
    public class Notification : Properties
    {
        [Key]
        public int Id { get; set; }

        public string Table { get; set; }

        public int TableId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public bool Active { get; set; }
        public Notification()
        {
            new Properties();
        }
        public Notification(User user)
        {
            new Properties(user);
        }
    }
}
