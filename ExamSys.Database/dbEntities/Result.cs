using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Result
    {
        public int           id          { get; set; }
        public double        Obtain      { get; set; }

        public Student Student{ get; set; }

        public DayTiming DayTiming{ get; set; }

        public Degree Degree{ get; set; }

        public Session Session{ get; set; }

        public ResultType ResultType{ get; set; }

        public StudentCourse StudentCourse{ get; set; }

        public int SessionPartValue{ get; set; }

        public SessionPart SessionPart{ get; set; }

        // Relations

        public Result()
        {
            new Properties();
        }
        public Result(User user)
        {
            new Properties(user);
        }
    }

}
