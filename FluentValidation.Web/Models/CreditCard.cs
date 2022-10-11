using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Web.Models
{
    [Keyless]
    public class CreditCard
    {
       
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
