using api.Models;

namespace api.interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllASync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentDto);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        Task<Comment?> DeleteAsync(int id);
    }
}
