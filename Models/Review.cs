using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Reviews")]
  public class Review
  {
    public int UserId { get; set; }
    public int AdvertismentId { get; set; }
    public float StartRating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}