using RM_System.Core.Enum;

namespace RM_System.Core.Entity
{
    public class Job: BaseEntity
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Candidate> Candidates { get; set; }

    }
}
