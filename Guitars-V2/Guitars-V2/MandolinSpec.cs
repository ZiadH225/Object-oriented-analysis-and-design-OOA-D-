using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public class MandolinSpec : InstrumentSpec
    {
        public Style Style { get; }

        public MandolinSpec(Builder builder, String model, Type type,
                            Style style, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            Style = style;
        }

        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            if (!(otherSpec is MandolinSpec))
                return false;
            MandolinSpec spec = (MandolinSpec)otherSpec;
            if (!Style.Equals(spec.Style))
                return false;
            return true;
        }

    }
}
