using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{

    public class Permission : Properties
    {
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        //Relations
        public Activity Activity { get; set; }

        public Permission()
        {
            new Properties();
        }
        public Permission(User user)
        {
            new Properties(user);
        }
    }
}
