using Microsoft.EntityFrameworkCore;
using Portal.Data;
using Portal.Interfaces;
using Portal.Models;

namespace Portal.Repository
{
  public class PostRepository(ApplicationDBContext context) : IPostRepository
  {
    private readonly ApplicationDBContext _context = context;
    public async Task<Post> CreateAsync(Post postModel)
    {
      await _context.Posts.AddAsync(postModel);
      await _context.SaveChangesAsync();
      return postModel;
    }

    public async Task<Post?> DeleteAsync(int id)
    {
      var postModel = await _context.Posts.FirstOrDefaultAsync(x => id == x.PostId);
      if (null == postModel) return null;
      _context.Posts.Remove(postModel);
      await _context.SaveChangesAsync();
      return postModel;
    }

    public async Task<List<Post>> GetAllAsync()
    {
      return await _context.Posts.ToListAsync();
    }

    public async Task<Post?> GetByIdAsync(int id)
    {
      return await _context.Posts.FindAsync(id);
    }

    public async Task<Post?> UpdateAsync(int id, Post postModel)
    {
      var existingPost = await _context.Posts.FindAsync(id);
      if (null == existingPost) return null;
      existingPost.Title = postModel.Title;
      existingPost.Content = postModel.Content;
      await _context.SaveChangesAsync();
      return existingPost;
    }
  }
}