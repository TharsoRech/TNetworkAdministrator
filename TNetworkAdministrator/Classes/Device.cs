﻿using System;
using System.Collections.Generic;
using System.Drawing;


namespace TNetworkAdministrator.Classes
{
    class Device
    {

        public int Id { get; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string Manufacturer {get; set; }

        public string Ip { get;  set; }

        public Status Status { get; set; }

        public string Image { get; set; }

       public Priority Priority { get; set; }

        public Group Group { get; set; }

        public Type type { get; set; }
    public DateTime AddIn { get; private set; }

        public DateTime TimeOn { get;  set; }
        public DateTime TimeOF { get; set; }

       public List<DayOfWeek> DaystoCheck { get; set; }

        public TimeSpan CheckEvery { get; set; }

        public List<string> Log { get; set; }

        public List<Classes.WarningType> WarningTypes { get;set ;}

        public Location location{ get; set; }
    } 
}
