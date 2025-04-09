using api.Dtos.Comments;
using api.interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepo;
        private readonly IStockRepository _stockRepo;

        public CommentController(ICommentRepository commentRepo, IStockRepository stockRepo)
        {
            _commentRepo = commentRepo;
            _stockRepo = stockRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentRepo.GetAllASync();
            var commentDto = comments.Select(s => s.ToCommentDto());
            return Ok(comments);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var comment = await _commentRepo.GetByIdAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment.ToCommentDto());
        }

        [HttpPost("{stockId:int}")]
        public async Task<IActionResult> Create(
            [FromRoute] int stockId,
            CreateCommentRquestDto commentDto
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!await _stockRepo.StockExists(stockId))
            {
                return BadRequest("Stock does not exist");
            }

            var commentModel = commentDto.ToCommentFromCreate(stockId);
            await _commentRepo.CreateAsync(commentModel);

            return CreatedAtAction(
                nameof(GetById),
                new { id = commentModel.Id },
                commentModel.ToCommentDto()
            );
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(
            [FromBody] UpdateCommentRequestDto commentDto,
            int id
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comment = await _commentRepo.UpdateAsync(id, commentDto.ToCommentFromUpdate());

            if (comment == null)
            {
                return NotFound("comment not found");
            }

            return Ok(comment.ToCommentDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _commentRepo.DeleteAsync(id);

            if (result == null)
            {
                return NotFound("comment not found with this id");
            }

            return Ok(result);
        }
    }
}
