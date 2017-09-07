using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Status : Properties
    {
        public int      id      { get; set; }

        //[Index(IsUnique = true)]
        public string   Title   { get; set; }


        public Status()
        {
        }
    }
}
