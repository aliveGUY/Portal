using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Posts")]
  public class Post
  {
    public int PostId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string IsInsightType { get; set; } = string.Empty; // Insight | Question
    public string Topic { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}