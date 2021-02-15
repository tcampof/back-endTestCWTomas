using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_endTestCWTomas.Models
{
    public class TestDbContext: DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options): base(options)
        {

        }

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
    }
}
