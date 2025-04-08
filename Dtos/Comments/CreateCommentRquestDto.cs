using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comments
{
    public class CreateCommentRquestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 character")]
        [MaxLength(300, ErrorMessage = "Titile can not be over 300 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(0, ErrorMessage = "Content must be 0 character")]
        [MaxLength(1000, ErrorMessage = "Content can not be over 1000 characters")]
        public string Content { get; set; } = string.Empty;
    }
}