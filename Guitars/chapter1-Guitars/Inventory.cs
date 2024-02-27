using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Guitars
{
    public class Inventory
    {
        private List<Guitar> _guitars;
        public Inventory()
        {
            _guitars = new List<Guitar>();
        }
        public void addGuitar(String serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            _guitars.Add(guitar);
        }
        public Guitar? getGuitar(String serialNumber) 
        { 
            for(int i=0; i< _guitars.Count; i++)
            {
                Guitar guitar = _guitars[i];
                if (guitar.getSerialNumber() == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchSpec) 
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i = 0; i < _guitars.Count; i++)
            {
                Guitar guitar = _guitars[i];
                if (guitar.getSpec().matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars;
        }


    }
}
