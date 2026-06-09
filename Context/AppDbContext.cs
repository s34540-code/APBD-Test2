using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.Context;


public class AppDbContext:DbContext
{

    public DbSet<Reviews> Reviews => Set<Reviews>();
    public DbSet<Authors> Authors => Set<Authors>();
    public DbSet<Books> Books => Set<Books>();
    public DbSet<Members> Members => Set<Members>();
    public DbSet<Borrowings> Borrowings => Set<Borrowings>();
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

}