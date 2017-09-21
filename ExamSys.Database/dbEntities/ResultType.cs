using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class ResultType : Properties
    {
        [Index("Id", IsUnique = true)]
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        
        public ResultType(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class ResultTypeRule : Properties
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description  { get; set; }
        public double TotalMarks { get; set; }
        
        public ResultTypeRule(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }

    public class ResultTypeAndRule : Properties
    {
        public int Id { get; set; }
        public decimal TypeTotal { get; set; }
        public ResultType ResultType{ get; set; }

        public ResultTypeRule ResultTypeRule{ get; set; }
        
        public ResultTypeAndRule(USER user)
        {
            created_by = user;
            isDeleted = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
    }
}
