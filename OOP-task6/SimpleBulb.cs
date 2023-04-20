using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{
    internal class SimpleBulb
    {

        private Boolean _state;

        public SimpleBulb()
        {
            _state = false;
        }

       public bool State {

            set { _state = value; }
        
        }
    }
}
