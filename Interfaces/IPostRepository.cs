using Portal.Models;

namespace Portal.Interfaces
{
  public interface IPostRepository
  {
    Task<List<Post>> GetAllAsync();
    Task<Post?> GetByIdAsync(int id);
    Task<Post> CreateAsync(Post postModel);
    Task<Post?> UpdateAsync(int id, Post postModel);
    Task<Post?> DeleteAsync(int id);
  }
}