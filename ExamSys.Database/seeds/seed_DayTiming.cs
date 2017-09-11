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
    public class seed_DayTiming
    {
        public static void seed(ExamDB db)
        {
            
            IList<DayTiming> DayTiming = new List<DayTiming>()
            {
                new DayTiming()
                {
                    id = 1,
                    Title = "Morning",
                    Description = "Morning",
                },
                new DayTiming()
                {
                    id = 2,
                    Title = "Evening",
                    Description = "Evening",
                },
            };
            foreach (var item in DayTiming)
                db.DayTiming.AddOrUpdate(item);

            db.SaveChanges();

        }
    }
}
