using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public class Inventory
    {
        private List<Instrument> inventory;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument? instrument = null;
            if (spec is GuitarSpec)
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            }
            else if (spec is MandolinSpec)
            {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }
            inventory.Add(instrument);
        }
        public Instrument? get(String serialNumber)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Instrument instrument = inventory[i];
                if (instrument.SerialNumber == serialNumber)
                {
                    return instrument;
                }
            }
            return null;
        }
        public List<T> Search<T>(InstrumentSpec searchSpec) where T : Instrument
        {
            List<T> matchingInstruments = new List<T>();
            for (int i = 0; i < inventory.Count; i++)
            {
                T? instrument = inventory[i] as T;
                if (instrument != null && instrument.Spec.matches(searchSpec))
                {
                    matchingInstruments.Add(instrument);
                }
            }
            return matchingInstruments;
        }



    }
}
