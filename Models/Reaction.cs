using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Reactions")]
  public class Reaction
  {
    public int UserId { get; set; }
    public int PostId { get; set; }
    public int Like { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}