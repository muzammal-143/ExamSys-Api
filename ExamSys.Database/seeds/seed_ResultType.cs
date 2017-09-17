using ExamSys.Database.dbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.Seeds
{
    public class seed_Result_Types
    {
        public static void seed(ExamDB context)
        {


            IList<ResultType> ResultTypes = new List<ResultType>()
            {
                new ResultType()
                {
                    
                },
            };

            foreach (var item in ResultTypes)
                context.ResultType.Add(item);

            context.SaveChanges();

        }
    }
}
