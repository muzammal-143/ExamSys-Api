﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Result
    {
        public int           id          { get; set; }
        public double        Obtain      { get; set; }

        // Relations
        public User Student { get; set; }
        public Sheet Sheet { get; set; }

        public Result()
        {
        }
    }

}