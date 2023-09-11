using AutoMapper;
using RM_System.Core.Dtos.Candidate;
using RM_System.Core.Dtos.Company;
using RM_System.Core.Dtos.Job;
using RM_System.Core.Entity;

namespace RM_System.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile() {

            CreateMap<CompanyCreateDto, Company>();
            CreateMap<Company, CompanyGetDto>();

            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobGetDto>().ForMember(dest => dest.CompanyName, opt=> opt.MapFrom(src => src.Company.Name));

            CreateMap<CandidateCreateDto, Candidate>();
            CreateMap<Candidate, CandidateGetDto>().ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));
        }

    }
}
