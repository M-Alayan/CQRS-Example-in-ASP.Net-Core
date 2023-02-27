using CQRSExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
