using AutoMapper;
using MediatR;
using Student2WithCQRS.Domain.DTO;
using Student2WithCQRS.Domain.Entities;
using Student2WithCQRS.Domain.Interface;

namespace Student2WithCQRS.Application.Commands._Candidate.Create
{
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, CandidateDto>
    {
        private readonly IBaseRepository baseRepository;
        private readonly IMapper mapper;

        public CreateCandidateCommandHandler(IBaseRepository baseRepository, IMapper mapper)
        {
            this.baseRepository = baseRepository;
            this.mapper = mapper;
        }
        public async Task<CandidateDto> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
        {
            var createCandidate = new Candidate
            {
                CandidateName = request.CandidateName
            };

            var result = await baseRepository.CreateCandidate(createCandidate);

            return mapper.Map<CandidateDto>(result);
        }
    }
}
