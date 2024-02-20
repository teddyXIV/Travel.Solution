using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace TravelApi.Models;

public class TravelApiContext : IdentityDbContext<ApplicationUser>
{
  public DbSet<Review> Reviews { get; set; }
  // public DbSet<User> Users { get; set; }

  public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options) { }
  // protected override void OnModelCreating(ModelBuilder builder)
  // {
  //   builder.Entity<Review>()
  //     .HasData(
  //       new Review { ReviewId = 1, Country = "USA", City = "Portland", Rating = 7, Description = "testing" },
  //       new Review { ReviewId = 2, Country = "Canada", City = "Vancouver", Rating = 10, Description = "testing" },
  //       new Review { ReviewId = 3, Country = "Mexico", City = "Tiujana", Rating = 2, Description = "testing" },
  //       new Review { ReviewId = 4, Country = "Spain", City = "Madrid", Rating = 4, Description = "testing" },
  //       new Review { ReviewId = 5, Country = "China", City = "Beijing", Rating = 9, Description = "testing" }
  //     );
  // }

}
