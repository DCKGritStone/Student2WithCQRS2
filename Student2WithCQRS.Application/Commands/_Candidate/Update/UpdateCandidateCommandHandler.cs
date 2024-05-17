using AutoMapper;
using MediatR;
using Student2WithCQRS.Domain.Entities;
using Student2WithCQRS.Domain.Interface;

namespace Student2WithCQRS.Application.Commands._Candidate.Update
{
    public class UpdateCandidateCommandHandler : IRequestHandler<UpdateCandidateCommand, int>
    {
        private readonly IBaseRepository baseRepository;

        public UpdateCandidateCommandHandler(IBaseRepository baseRepository, IMapper mapper)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<int> Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
        {
            var updateCandidate = new Candidate
            {
                CandidateId = request.CandidateId,
                CandidateName = request.CandidateName
            };

            return await baseRepository.UpdateCandidate(request.CandidateId, updateCandidate);
        }
    }
}
