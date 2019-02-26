using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TransferService.Models
{
    public class Transfer : IValidatableObject
    {
        public string FromAccount { get; set; }
        public string BeneName { get; set; }

        //[Required]
        public string Amount { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
        public List<string> Address { get; set; }
        public string strJSON { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(string.IsNullOrEmpty(Amount))
            {
                yield return new ValidationResult("Amount can not be empty");
            }
        }
    }
}