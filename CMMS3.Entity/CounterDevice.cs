using System.Collections.Generic;

namespace PME.Models.Entities
{/// <summary>
 ///  مرکزداده
 /// </summary>
    public class CounterDevice
    {
        public CounterDevice()
        {
            SubCounterDevices = new HashSet<SubCounterDevice>();
        }

        public int ID { get; set; }
        public string CounterTitle { get; set; }

        public int ApplicatinID_FK { get; set; }
        public Applicant Applicant { get; set; }

        public string Description { get; set; }


        public bool IsActive { get; set; }


        public virtual ICollection<SubCounterDevice> SubCounterDevices { get; set; }


    }
}
