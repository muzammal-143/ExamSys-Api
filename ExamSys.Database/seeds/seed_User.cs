using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.seeds
{
    public class seed_USER
    {
        public static void seed(ExamDB context)
        {
            
            context.SaveChanges();

        }
    }
}
