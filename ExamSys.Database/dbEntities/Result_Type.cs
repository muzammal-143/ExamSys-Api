﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Result_Type : Properties
    {
        public int id { get; set; }
        public string Type { get; set; }

        
        public Result_Type()
        {
        }
    }
}
