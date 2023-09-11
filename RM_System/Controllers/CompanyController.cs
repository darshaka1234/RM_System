using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RM_System.Core.Context;
using RM_System.Core.Dtos.Candidate;
using RM_System.Core.Entity;

namespace RM_System.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext _context;

        public IMapper _mapper { get; set; }

        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            Company newCompany = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();

            return Ok("New Company Added Successfully ");
        }
    }
}
