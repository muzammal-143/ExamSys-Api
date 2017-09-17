using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class ResultType : Properties
    {
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public ResultType()
        {
            new Properties();
        }
        public ResultType(User user)
        {
            new Properties(user);
        }
    }

    public class ResultTypeRule : Properties
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description  { get; set; }
        public double TotalMarks { get; set; }
        public ResultTypeRule()
        {
            new Properties();
        }
        public ResultTypeRule(User user)
        {
            new Properties(user);
        }
    }

    public class ResultTypeAndRule : Properties
    {
        public int Id { get; set; }
        public decimal TypeTotal { get; set; }
        public ResultType ResultType{ get; set; }

        public ResultTypeRule ResultTypeRule{ get; set; }
        public ResultTypeAndRule()
        {
            new Properties();
        }
        public ResultTypeAndRule(User user)
        {
            new Properties(user);
        }
    }
}
