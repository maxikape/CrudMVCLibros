using CRUD_MVC_max.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC_max.Data
{
    public class ApplicationDbContext : DbContext
    {
 
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }

            public DbSet<Libro> Libro { get; set; }
       
    }
}
