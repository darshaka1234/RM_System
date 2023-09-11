namespace RM_System.Core.Dtos.Candidate
{
    public class CandidateCreateDto
    {
        public string Fristname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public long JobId { get; set; }
    }
}
