using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNetworkAdministrator.Classes
{
     class Warning
    {
        public Device Device { get; set; }

        public DateTime Createdin { get; private set; }

        public WarningType Warningtype { get; set; }

    }
}
