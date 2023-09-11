using RM_System.Core.Enum;

namespace RM_System.Core.Dtos.Company
{
    public class CompanyGetDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

    }
}
