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
            
            IList<DayTime> DayTiming = new List<DayTime>()
            {
                new DayTime()
                {
                    id = 1,
                    Title = "Morning",
                    Description = "Morning",
                },
                new DayTime()
                {
                    id = 2,
                    Title = "Evening",
                    Description = "Evening",
                },
            };
            foreach (var item in DayTiming)
                db.DayTime.AddOrUpdate(item);

            db.SaveChanges();

        }
    }
}
