using api.Dtos.Comments;
using api.Models;

namespace api.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId,
                CreatedBy = commentModel.AppUser?.UserName ?? "Unknown",
            };
        }

        public static CommentUserDto ToCommentUserDto(this Comment commentModel)
        {
            return new CommentUserDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                User = AppUserMappers.ToAppUserDto(commentModel.AppUser),
            };
        }

        public static Comment ToCommentFromCreate(
            this CreateCommentRquestDto commentDto,
            int stockId
        )
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId,
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comment { Title = commentDto.Title, Content = commentDto.Content };
        }
    }
}
