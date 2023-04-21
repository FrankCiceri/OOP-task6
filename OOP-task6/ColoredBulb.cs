using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{

    enum ColorType
    { 
    Red =1,
    Yellow= 2 ,
    Blue = 3,
    Green = 0,
    }
    public class ColoredBulb:SimpleBulb
    {
        private string _type;

        public ColoredBulb(int serial):base(serial) {

            _type = Enum.GetName(typeof(ColorType), serial%4);
            
        }

        public string Type
        {

            get { return _type; }

            set { _type = Enum.GetName(typeof(ColorType), value); }


        }
        
      
    }
}
