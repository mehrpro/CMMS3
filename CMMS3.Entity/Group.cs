using System.Collections.Generic;

namespace PME.Models.Entities
{
    public class Group
    {
        public Group()
        {

            SubGroups = new HashSet<SubGroup>();
            Codings = new HashSet<Coding>();
        }
        public int ID { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }
        public byte GroupIndex { get; set; }
        public string GroupTitle { get; set; }
        public string Description { get; set; }


        public virtual ICollection<SubGroup> SubGroups { get; set; }
        public virtual ICollection<Coding> Codings { get; set; }
    }
}
