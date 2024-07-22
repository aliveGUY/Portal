using Microsoft.AspNetCore.Mvc;
using Portal.Dtos.Post;
using Portal.Interfaces;
using Portal.Mappers;

namespace Portal.Controllers
{
  [Route("posts")]
  [ApiController]
  public class PostController(IPostRepository postRepository) : Controller
  {
    private readonly IPostRepository _postRepository = postRepository;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var posts = await _postRepository.GetAllAsync();
      return PartialView("~/Presentation/Components/PostsList.cshtml", posts);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
      var post = await _postRepository.GetByIdAsync(id);
      return PartialView("~/Presentation/Components/PostDetails.cshtml", post);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] CreatePostDto postDto)
    {
      var postModel = postDto.ToPostFromCreate();
      await _postRepository.CreateAsync(postModel);

      return Content("<span>Created</span>");
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
      var postModel = await _postRepository.DeleteAsync(id);

      if (null == postModel)
        return NotFound("Post does not exist");
      
      Response.Headers.Append("HX-Redirect", "/");
      return Ok();
    }
  }
}