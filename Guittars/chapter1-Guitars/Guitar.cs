using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Guitars
{
    public class Guitar
    {
        private string _serialNumber;
        private double _price;
        GuitarSpec spec;

        public Guitar(String serialNumber, double price, GuitarSpec spec)
        {
            this._serialNumber = serialNumber;
            this._price = price;
            this.spec = spec;
        }
        public String getSerialNumber()
        {
            return _serialNumber;
        }

        public double getPrice()
        {
            return _price;
        }
        public void setPrice(double newPrice)
        {
            this._price = newPrice;
        }
        public GuitarSpec getSpec()
        {
            return spec;
        }

    }
}
