using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models;

public class TravelApiContext : DbContext
{
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options) { }

}