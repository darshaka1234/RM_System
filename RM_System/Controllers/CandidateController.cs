using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RM_System.Core.Context;
using RM_System.Core.Dtos.Candidate;
using RM_System.Core.Entity;

namespace RM_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private ApplicationDbContext _context {  get;  }
        public IMapper _mapper { get;  }
        public CandidateController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<Candidate>> Createcandidate([FromForm]CandidateCreateDto dto, IFormFile pdfFile)
        {

            if(pdfFile.Length > 10*1024*1024 || pdfFile.ContentType != "application/pdf") {

                return BadRequest("File is not supported");
            }
            var resumeUrl = Guid.NewGuid().ToString()+".pdf";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Documents", resumeUrl);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await pdfFile.CopyToAsync(stream);
            }

            var newCandidate = _mapper.Map<Candidate>(dto);
            newCandidate.ResumeUrl = resumeUrl;
            await _context.Candidates.AddAsync(newCandidate);
            await _context.SaveChangesAsync();

            return Ok("Candidate Added Succsessfully");
        }

        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CandidateGetDto>>> GetCandidates()
        {
            var candidates = await _context.Candidates.Include(c => c.Job).ToListAsync();
            var convetedCandidates = _mapper.Map<IEnumerable<CandidateGetDto>>(candidates);

            return Ok(convetedCandidates);
        }
    }
}
