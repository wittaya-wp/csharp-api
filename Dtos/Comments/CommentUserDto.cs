using api.Dtos.Account;

namespace api.Dtos.Comments
{
    public class CommentUserDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public UserInfoDto User { get; set; }
    }
}
