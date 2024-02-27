using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Guitars
{
    public class GuitarSpec
    {
        private Builder _builder;
        private Type _type;
        private Wood _backWood, _topWood;
        private string _model;

        public GuitarSpec(Builder builder, String model, Type type,
                Wood backWood, Wood topWood)
        {
            this._builder = builder;
            this._model = model;
            this._type = type;
            this._backWood = backWood;
            this._topWood = topWood;
        }



        public Builder getBuilder()
        {
            return _builder;
        }
        public String getModel()
        {
            return _model;
        }
        public Type getType()
        {
            return _type;
        }
        public Wood getBackWood()
        {
            return _backWood;
        }
        public Wood getTopWood()
        {
            return _topWood;
        }
        public bool matches(GuitarSpec otherSpec)
        {
            if(_model != null && _model != "" && _model.ToLower() != otherSpec.getModel().ToLower())
            { 
                return false;
            }
            if (_builder != otherSpec._builder)
            { 
            return false;
            }
            if (_type != otherSpec._type)
            {
                return false;
            }
            if (_backWood != otherSpec._backWood)
            {
                return false;
            }
            if (_topWood != otherSpec._topWood)
            {
                return false;
            }
            return true;
        }
    }
}
