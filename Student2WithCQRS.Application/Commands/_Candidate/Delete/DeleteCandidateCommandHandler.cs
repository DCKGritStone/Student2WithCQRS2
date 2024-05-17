using AutoMapper;
using MediatR;
using Student2WithCQRS.Domain.Interface;

namespace Student2WithCQRS.Application.Commands._Candidate.Delete
{
    public class DeleteCandidateCommandHandler : IRequestHandler<DeleteCandidateCommand, int>
    {
        private readonly IBaseRepository baseRepository;

        public DeleteCandidateCommandHandler(IBaseRepository baseRepository, IMapper mapper)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<int> Handle(DeleteCandidateCommand request, CancellationToken cancellationToken)
        {
            return await baseRepository.DeleteCandidate(request.CandidateId);
        }
    }
}
