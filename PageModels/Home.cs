using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Interfaces;
using Portal.Models;

namespace Portal.Pages
{
  public class Home(IPostRepository postRepository) : PageModel
  {
    private readonly IPostRepository _postRepository = postRepository;

    public List<Post> Posts { get; set; } = [];
    public async Task<IActionResult> OnGetAsync()
    {
      Posts = await _postRepository.GetAllAsync();
      return Page();
    }
  }
}