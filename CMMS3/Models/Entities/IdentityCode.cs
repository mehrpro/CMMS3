﻿using System.Collections.Generic;
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

        public long ID { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }
        public int GroupID_FK { get; set; }
        public Group Group { get; set; }
        public int SubGroupID_FK { get; set; }
        public SubGroup SubGroup { get; set; }
        public string UserID_FK { get; set; }
        public UserApplication UserApplication { get; set; }
        public short CodeIndex { get; set; }
        public int Code { get; set; }
        public string CodeTitle { get; set; }
        public string Description { get; set; }



        public virtual ICollection<Machinery> Machineries { get; set; }
    }
}
