using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{
    public class SimpleBulb
    {

        private Boolean _state;
        private readonly int _serial;

        public SimpleBulb(int serial)
        {
            _serial = serial;
            _state = false;
        }


        public Boolean State {
            get { return _state; }

            set { _state = value; }
        }

        public int Serial {
            get {return _serial; }
        }

       
    }
}
