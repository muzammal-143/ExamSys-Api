using ExamSys.Database.dbEntities;
using ExamSys.Database.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ExamSys.Database
{
    public class Activity : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }

        public Activity(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }

    }


    
}
