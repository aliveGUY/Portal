using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Advertisments")]
  public class Advertisment
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}