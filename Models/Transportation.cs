using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Transportations")]
  public class Transportation
  {
    public int UserId { get; set; }
    public int AdvertismentId { get; set; }
    public DateTime Departure { get; set; }
    public DateTime EstimatedArrival { get; set; }
    public string StartingLocation { get; set; } = string.Empty;
    public string FinishLocation { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}