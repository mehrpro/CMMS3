using System.Collections.Generic;

namespace PME.Models.Entities
{
    public class MenuItem
    {

        public MenuItem()
        {
            Cleams = new HashSet<Cleam>();
        }


        public int ItemID { get; set; }
        public int GroupID_FK { get; set; }
        public MenuGroup MenuGroup { get; set; }
        public string ItemTitel { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Cleam> Cleams { get; set; }

    }
}
