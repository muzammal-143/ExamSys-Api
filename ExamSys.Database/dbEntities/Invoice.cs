using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{

    public class InvoiceType : Properties
    {
        public int Id { get; set; }
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public InvoiceType() 
        {
        }
    }

    public class Invoice : Properties
    {
        public int Id { get; set; }
        public double Rs { get; set; }
        public InvoiceType Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Expired { get; set; }
        public Invoice() 
        {
            Expired = false;
            created_at = DateTime.Now;
            edited_at = DateTime.Now;
        }
        
    }


}
