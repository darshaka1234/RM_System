namespace RM_System.Core.Entity
{
    public class Candidate : BaseEntity
    {
        public string Fristname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }

        public long JobId { get; set; }
        public Job Job { get; set; }
    }
}
