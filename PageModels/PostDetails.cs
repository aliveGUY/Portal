using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Interfaces;
using Portal.Models;

namespace Portal.Pages
{
  public class PostDetails(IPostRepository postRepository) : PageModel
  {
    private readonly IPostRepository _postRepository = postRepository;

    public Post? Post { get; set; }
    public async Task<IActionResult> OnGetAsync(int id)
    {
      Post = await _postRepository.GetByIdAsync(id);

      if (Post == null)
      {
        return NotFound();
      }

      return Page();
    }

    public async Task<IActionResult> OnDeleteAsync(int id)
    {
      var postModel = await _postRepository.DeleteAsync(id);

      if (null == postModel)
        return NotFound("Post does not exist");

      Response.Headers.Append("HX-Redirect", "/");
      return Page();
    }
  }
}
