﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNetworkAdministrator.Classes
{
    class Service
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Device Computer { get; set; }

        public string Port { get; set; }
    }
}
