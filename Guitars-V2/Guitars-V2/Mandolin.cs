using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public class Mandolin : Instrument
    {
        public Mandolin(String serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
        {
        }

    }
}
