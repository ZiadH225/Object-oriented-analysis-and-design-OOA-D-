using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public abstract class Instrument
    {

        public String SerialNumber { set; get; }
        public double Price { set; get; }
        public InstrumentSpec Spec { get; }

        public Instrument(String serialNumber, double price, InstrumentSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
    }
}
