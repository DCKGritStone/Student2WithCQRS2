using Microsoft.AspNetCore.Mvc;
using Student2WithCQRS.Application.Commands._AssessmentResult.Create;
using Student2WithCQRS.Application.Commands._AssessmentResult.Delete;
using Student2WithCQRS.Application.Commands._AssessmentResult.Update;
using Student2WithCQRS.Domain.Interface._AssessmentResult;

namespace Student2WithCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Result_Controller : ApiController
    {
        private readonly IResults _result;

        public Result_Controller(IResults result)
        {
            _result = result;
        }
        [HttpGet]

        public IActionResult GetAllResult()
        {
            var result = _result.GetAllResult();

            return Ok(result);
        }

        [HttpGet("Id")]

        public IActionResult GetResultsById(int id)
        {
            var result = _result.GetResultById(id);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateAssessmentCommand command)
        {
            var createResult = await Mediator.Send(command);

            return CreatedAtAction(nameof(GetResultsById), new { id = createResult.AssessmentId }, createResult);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, UpdateAssessmentCommand command)
        {
            if (id == command.AssessmentId) { return BadRequest(); }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteAssessmentCommand { AssessmentId = id });
            return NoContent();
        }
    }
}
