using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    public class PublicType
    {

        public PublicType()
        {
            RequestRepairs = new HashSet<RequestRepair>();
        }

        public int ID { get; set; }
        public int Group { get; set; }
        public string Title { get; set; }



        public virtual ICollection<RequestRepair> RequestRepairs { get; set; }
    }
}
