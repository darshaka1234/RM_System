using RM_System.Core.Enum;

namespace RM_System.Core.Entity
{
    public class Company: BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}
