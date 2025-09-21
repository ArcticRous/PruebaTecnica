using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using System.Collections.Generic;

namespace PruebaTecnica.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UsersModel> Users { get; set; }
    }
}