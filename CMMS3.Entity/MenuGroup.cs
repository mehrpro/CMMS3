using System.Collections.Generic;

namespace PME.Models.Entities
{
    public class MenuGroup
    {
        public MenuGroup()
        {
            MenuItems = new HashSet<MenuItem>();
            Cleams = new HashSet<Cleam>();
        }


        public int GroupID { get; set; }
        public string MenuGroupTitle { get; set; }
        public string Description { get; set; }



        public virtual ICollection<MenuItem> MenuItems { get; set; }
        public virtual ICollection<Cleam> Cleams { get; set; }
    }
}
