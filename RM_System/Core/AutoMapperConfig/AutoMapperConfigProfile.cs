using AutoMapper;
using RM_System.Core.Dtos.Candidate;
using RM_System.Core.Entity;

namespace RM_System.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile() {
            CreateMap<CompanyCreateDto, Company>();
        }
    }
}
