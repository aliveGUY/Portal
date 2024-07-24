using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Products")]
  public class Product
  {
    public int UserId { get; set; }
    public int AdvertismentId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Photos { get; set; } = [];
    public float Price { get; set; }
    public string PayPeriod { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}