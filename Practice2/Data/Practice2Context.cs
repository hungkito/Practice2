using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice2.Models;

namespace Practice2.Data
{
    public class Practice2Context : DbContext
    {
        public Practice2Context (DbContextOptions<Practice2Context> options)
            : base(options)
        {
        }

        public DbSet<Practice2.Models.Employee> Employee { get; set; }
    }
}
