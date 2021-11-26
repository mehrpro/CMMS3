using System.Collections.Generic;
namespace CMMS3.Models.Entities
{
    /// <summary>
    /// کدینگ ماشین آلات
    /// </summary>
    public class IdentityCode
    {
        public IdentityCode()
        {
            Machineries = new HashSet<Machinery>();
        }

        public long Id { get; set; }
        public int CompanyIdFk { get; set; }
        public Company Company { get; set; }
        public int GroupIdFk { get; set; }
        public Group Group { get; set; }
        public int SubGroupIdFk { get; set; }
        public SubGroup SubGroup { get; set; }
        public string UserIdFk { get; set; }
        public UserApplication UserApplication { get; set; }
        public short CodeIndex { get; set; }
        public int Code { get; set; }
        public string CodeTitle { get; set; }
        public string Description { get; set; }



        public virtual ICollection<Machinery> Machineries { get; set; }
    }
}
