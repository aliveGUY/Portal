using System.ComponentModel.DataAnnotations.Schema;

namespace Portal.Models
{
  [Table("Users")]
  public class User
  {
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Nickname { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int UserId { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
  }
}