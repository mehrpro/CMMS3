using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    public class Group
    {
        public Group()
        {
            SubGroups = new HashSet<SubGroup>();
            IdentityCodes = new HashSet<IdentityCode>();
        }
        public int Id { get; set; }
        public int CompanyIdFk { get; set; }
        public Company Company { get; set; }
        public byte GroupIndex { get; set; }
        public string GroupTitle { get; set; }
        public string Description { get; set; }


        public virtual ICollection<SubGroup> SubGroups { get; set; }
        public virtual ICollection<IdentityCode> IdentityCodes { get; set; }
    }
}
