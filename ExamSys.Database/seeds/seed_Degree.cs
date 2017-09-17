using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Degrees
    {
        public static void seed(ExamDB db)
        {
            
            IList<Degree> Degrees = new List<Degree>()
            {
                new Degree()
                {
                    id = 1,
                    Title = "Under graduate",
                    Description = "Under graduate"
                },
                new Degree()
                {
                    id = 2,
                    Title = "Graduate",
                    Description = "Graduate"
                },
                new Degree()
                {
                    id = 3,
                    Title = "Post graduate",
                    Description = "Post graduate"
                },
            };
            foreach (var item in Degrees)
                db.Degrees.Add(item);

            db.SaveChanges();

        }
    }
}
