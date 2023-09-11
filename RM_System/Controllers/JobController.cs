using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RM_System.Core.Context;
using RM_System.Core.Dtos.Job;
using RM_System.Core.Entity;

namespace RM_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        public IMapper _mapper { get; set; }
        public JobController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDto dto)
        {
            Job newJob = _mapper.Map<Job>(dto);
            await _context.Jobs.AddAsync(newJob);
            await _context.SaveChangesAsync();

            return Ok("New Job Added Successfully ");

        }

        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<JobGetDto>>> GetJobs()
        {
            var jobs = await _context.Jobs.Include(job => job.Company).ToListAsync();
            var convertedJobs = _mapper.Map<IEnumerable<JobGetDto>>(jobs);

            return Ok(convertedJobs);
        }
    }
}
