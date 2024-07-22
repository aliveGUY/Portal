using Portal.Dtos.Post;
using Portal.Models;

namespace Portal.Mappers
{
  public static class PostMapper
  {
    public static Post ToPostFromCreate(this CreatePostDto postDto)
    {
      return new Post
      {
        Title = postDto.Title,
        Content = postDto.Content
      };
    }
  }
}