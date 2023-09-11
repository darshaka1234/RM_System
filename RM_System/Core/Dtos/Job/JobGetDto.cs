using RM_System.Core.Enum;

namespace RM_System.Core.Dtos.Job
{
    public class JobGetDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
