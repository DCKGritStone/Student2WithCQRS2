using AutoMapper;
using MediatR;
using Student2WithCQRS.Domain.Interface;
using Student2WithCQRS.Domain.DTO;
using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.Application.Commands._AssessmentResult.Create
{
    public class CreateAssessmentCommandHandler : IRequestHandler<CreateAssessmentCommand, AssessmentResultDto>
    {
        private readonly IBaseRepository baseRepository;
        private readonly IMapper mapper;

        public CreateAssessmentCommandHandler(IBaseRepository baseRepository, IMapper mapper)
        {
            this.baseRepository = baseRepository;
            this.mapper = mapper;
        }
        public async Task<AssessmentResultDto> Handle(CreateAssessmentCommand request, CancellationToken cancellationToken)
        {
            var createAssessment = new AssessmentResult
            { 
                CandidateId = request.CandidateId,
                CategoryId = request.CategoryId,
                Score = request.Score
            };

            var result = await baseRepository.CreateAssessment(createAssessment);

            return mapper.Map<AssessmentResultDto>(result);
        }
    }
}
