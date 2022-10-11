using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Web.Models
{
    public class Customer
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime ? Brithday { get; set; }
        public IList<Adress> Adresses { get; set; }
        public Gender Gender { get; set; }
        [NotMapped]
        public CreditCard CreditCard { get; set; }
        public string FullName2()
        {
            return $"{Name}-{Email}-{Age}";
        }
    }
}
