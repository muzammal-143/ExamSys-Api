using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.seeds
{
    public class seed_Activity
    {
        public static void seed(ExamDB db)
        {


            User user = db.User.Find(1);
            IList<Activity> Activities = new List<Activity>()
            {
                // new Activity{Id=, Title = "", Description = ""},
                new Activity{Id=1, Title = "Create User", Description = "For creating new user"},
                
                
            
            };

            foreach (var item in Activities)
                db.Activity.Add(item);

            db.SaveChanges();
        }
    }
}
