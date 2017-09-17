using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Designations
    {
        public static void seed(ExamDB context)
        {

            IList<Faculty> Faculties = new List<Faculty>()
            {
                new Faculty()
                {
                },
            };
            foreach (var item in Faculties)
                context.Faculty.Add(item);

            context.SaveChanges();

        }
    }
}
