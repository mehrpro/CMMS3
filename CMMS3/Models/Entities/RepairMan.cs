using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    public class RepairMan
    {

        public RepairMan()
        {
            RepairManListeds = new HashSet<RepairManListed>();
        }

        public int Id { get; set; }
        public string RepairmanFullName { get; set; }
        public string RepairManStatus { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RepairManListed> RepairManListeds { get; set; }

    }
}
