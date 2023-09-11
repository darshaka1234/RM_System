using RM_System.Core.Enum;

namespace RM_System.Core.Dtos.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }
}
