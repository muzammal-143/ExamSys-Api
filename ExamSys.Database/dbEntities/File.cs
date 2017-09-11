using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public enum FileType 
    {
        USER,
    }
    public class File : Properties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FileType FileType { get; set; }
        public int TargetId { get; set; }
        public File()
        {
            new Properties();
        }
        public File(User user)
        {
            new Properties(user);
        }
    }
}
