using System.Collections.Generic;

namespace PME.Models.Entities
{
    /// <summary>
    /// ترمینال های ورودی مرکز داده
    /// </summary>
    public class SubCounterDevice
    {
        public SubCounterDevice()
        {
            MachineryCounterDevices = new HashSet<MachineryCounterDevice>();
        }

        public int ID { get; set; }

        public string TerminalNumber { get; set; }

        public int UnitID_FK { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CounterDeviceID_FK { get; set; }
        public CounterDevice CounterDevice { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }


        public virtual ICollection<MachineryCounterDevice> MachineryCounterDevices { get; set; }

    }
}
