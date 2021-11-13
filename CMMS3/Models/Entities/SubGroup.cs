﻿using System.Collections.Generic;

namespace CMMS3.Models.Entities
{
    public class SubGroup
    {
        public SubGroup()
        {

            this.Codings = new HashSet<IdentityCode>();
        }
        public int ID { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }
        public int GroupID_FK { get; set; }
        public Group Group { get; set; }
        public byte SubGroupIndex { get; set; }
        public string SubGroupTitle { get; set; }
        public string Description { get; set; }


        public virtual ICollection<IdentityCode> Codings { get; set; }
    }
}
