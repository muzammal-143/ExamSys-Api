using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Status : Properties
    {
        public int      id      { get; set; }

        [Key]
        public string   Title   { get; set; }
        public string Description { get; set; }

        public Status()
        {
        }
    }

    private class UniqueTitle : ValidationAttribute
    {
        ExamDB db = new ExamDB();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                Status status = db.Status.Where(m => m.Title == value).FirstOrDefault();
                if (status != null)
                {
                    return new ValidationResult("Error | Already exists");
                }
                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                return new ValidationResult(ex.Message);
            }
        }
    }

}
