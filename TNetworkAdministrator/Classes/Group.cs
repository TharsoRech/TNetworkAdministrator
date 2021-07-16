using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNetworkAdministrator.Classes
{
    class Group
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public bool UseDefaultPriority { get; set; }

        public Priority Priority { get; set; }

        public List<Device>  Devices { get; set; }

        public DateTime TimeOn { get; set; }
        public DateTime TimeOF { get; set; }

        public List<DayOfWeek> DaystoCheck { get; set; }

        public TimeSpan CheckEvery { get; set; }

        public List<Classes.WarningType> WarningTypes { get; set; }

    }
}
