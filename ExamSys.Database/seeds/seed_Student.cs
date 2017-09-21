using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Students
    {
        public static void seed(ExamDB context)
        {
            
            
            context.Student.AddOrUpdate(
                
            );

            context.SaveChanges();

        }
    }
}
