using Microsoft.EntityFrameworkCore;
using Portal.Models;


namespace Portal.Data
{
  public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
  {
    public DbSet<Post> Posts { get; set; }
  }
}