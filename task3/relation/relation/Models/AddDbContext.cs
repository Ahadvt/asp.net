using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace relation.Models
{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options)
        {


        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> students { get; set; }

    }
}
