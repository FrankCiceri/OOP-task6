using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{

    enum ColorType
    { 
    Red,
    Yellow,
    Blue,
    Green
    }
    public class ColoredBulb
    {
        private string _type;
        private Boolean _state;

        public ColoredBulb() {
            _type = Enum.GetName(typeof(ColorType), 1);
            _state = false;
        }

        public string Type
        {

            get { return _type; }

            set { _type = Enum.GetName(typeof(ColorType), value); }


        }

        public bool State
        {

            set { _state = value; }

        }

    }
}
