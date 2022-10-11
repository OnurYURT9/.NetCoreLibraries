using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext>options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set;}
    }
}
