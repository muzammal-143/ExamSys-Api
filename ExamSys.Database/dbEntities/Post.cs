﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Post : Properties
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description  { get; set; }
        public Post()
        {
            new Properties();
        }
        public Post(User user)
        {
            new Properties(user);
        }
    }
}
