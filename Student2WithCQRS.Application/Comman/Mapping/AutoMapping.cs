using AutoMapper;
using Student2WithCQRS.Domain.DTO;
using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.Application.Comman.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AssessmentCategory, AssessmentCategoryDto>().ReverseMap();
            CreateMap<AssessmentResult, AssessmentResultDto>().ReverseMap();
            CreateMap<Candidate, CandidateDto>().ReverseMap();
            CreateMap<Candidate, CandidateForPassFailDto>().ReverseMap();
            CreateMap<AssessmentResult, AssessmentResultForPassFailDto>().ReverseMap();
        }
    }
}
