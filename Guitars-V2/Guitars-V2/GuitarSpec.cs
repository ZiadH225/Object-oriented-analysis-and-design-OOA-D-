using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public class GuitarSpec : InstrumentSpec
    {
        public int numStrings { get; }
        public GuitarSpec(Builder builder, String model, Type type
                         , int numStrings, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            this.numStrings = numStrings;
        }
        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            if (!(otherSpec is GuitarSpec))
                return false;
            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (numStrings != spec.numStrings)
                return false;
            return true;
        }
    }
}
