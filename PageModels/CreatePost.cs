using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Interfaces;
using Portal.Mappers;
using Portal.Dtos.Post;
using System.ComponentModel.DataAnnotations;

namespace Portal.Pages
{
  public class CreatePost(IPostRepository postRepository) : PageModel
  {
    private readonly IPostRepository _postRepository = postRepository;


    [BindProperty, Required]
    public required CreatePostDto Post { get; init; }

    public async Task<IActionResult> OnPostAsync()
    {
      if (!ModelState.IsValid)
      {
        return Partial("_Form", this);
      }

      var postModel = Post.ToPostFromCreate();
      await _postRepository.CreateAsync(postModel);

      Response.Headers.Append("HX-Redirect", "/");
      return Page();
    }
  }
}