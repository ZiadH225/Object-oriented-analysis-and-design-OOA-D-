using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public class Guitar : Instrument
    {
        public Guitar(String serialNumber, double price, GuitarSpec spec) : base(serialNumber, price, spec)
        {
        }

    }
}
