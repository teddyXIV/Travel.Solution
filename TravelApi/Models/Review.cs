namespace TravelApi.Models;

public class Review
{
    public int ReviewId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
}