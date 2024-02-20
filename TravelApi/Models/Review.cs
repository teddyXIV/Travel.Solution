using System.ComponentModel.DataAnnotations;
namespace TravelApi.Models;

public class Review
{
    public int ReviewId { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
    public int Rating { get; set; }
    [Required]
    public string Description { get; set; }
    public ApplicationUser User { get; set; }
}