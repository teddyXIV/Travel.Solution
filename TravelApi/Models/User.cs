namespace TravelApi.Models;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public List<Review> Reviews { get; set; }
}