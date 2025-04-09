using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comments
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 character")]
        [MaxLength(300, ErrorMessage = "Titile can not be over 300 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(1, ErrorMessage = "Title must be 1 character")]
        [MaxLength(1000, ErrorMessage = "Titile can not be over 300 characters")]
        public string Content { get; set; } = string.Empty;
    }
}