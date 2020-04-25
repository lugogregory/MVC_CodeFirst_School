using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_School.Models;

namespace MVC_CodeFirst_School.Data
{
    public class MVC_CodeFirst_SchoolContext : DbContext
    {
        public MVC_CodeFirst_SchoolContext (DbContextOptions<MVC_CodeFirst_SchoolContext> options)
            : base(options)
        {
        }
        public DbSet<MVC_School.Models.Person> Person { get; set; }
        public DbSet<MVC_School.Models.Student> Student { get; set; }

    }
}
