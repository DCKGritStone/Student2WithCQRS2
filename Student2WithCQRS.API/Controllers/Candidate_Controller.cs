using Microsoft.AspNetCore.Mvc;
using Student2WithCQRS.Application.Commands._Candidate.Create;
using Student2WithCQRS.Application.Commands._Candidate.Delete;
using Student2WithCQRS.Application.Commands._Candidate.Update;
using Student2WithCQRS.Domain.Interface._Candidate;

namespace Student2WithCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Candidate_Controller : ApiController
    {
        private readonly ICandidate _candidate;

        public Candidate_Controller(ICandidate candidate)
        {
            _candidate = candidate ?? throw new ArgumentNullException(nameof(candidate));
        }

        [HttpGet]

        public IActionResult GetAllCandidates()
        {
            var candidate = _candidate.GetAllCandidate();

            return Ok(candidate);
        }

        [HttpGet("Id")]

        public IActionResult GetCandidatesById(int id)
        {
            var category = _candidate.GetCandidateById(id);

            if (category == null)
            {
                return BadRequest();
            }

            return Ok(category);
        }

        [HttpGet("PassOrFailDetailsOfCandidate")]

        public IActionResult GetPassOrFail()
        {
            var candidate = _candidate.GetPassFailResult();

            return Ok(candidate);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCandidateCommand command)
        {
            var createCandidate = await Mediator.Send(command);

            return CreatedAtAction(nameof(GetCandidatesById), new { id = createCandidate.CandidateId }, createCandidate);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, UpdateCandidateCommand command)
        {
            if (id == command.CandidateId) { return BadRequest(); }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteCandidateCommand { CandidateId = id });
            return NoContent();
        }
    }
}
