using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comments;
using api.Models;

namespace api.interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllASync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentDto);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
    }
}