using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitars_V2
{
    public abstract class InstrumentSpec
    {

        public Builder Builder { get; }
        public String Model { get; }
        public Type Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public InstrumentSpec(Builder builder, String model, Type type,
                              Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public virtual bool matches(InstrumentSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if ((Model != null) && (!Model.Equals("")) &&
                (!Model.Equals(otherSpec.Model)))
                return false;
            if (Type != otherSpec.Type)
                return false;
            if (BackWood != otherSpec.BackWood)
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}
