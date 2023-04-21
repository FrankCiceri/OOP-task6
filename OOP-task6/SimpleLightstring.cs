using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{
    internal class SimpleLightstring : Lightstring
    {
        public SimpleLightstring(int numBulbs) : base(numBulbs)
        {
            Console.WriteLine("Enter the serials for the Simple bulbs");
            for (int i = 0; i < numBulbs; i++)
            {

                int serial = Convert.ToInt32(Console.ReadLine());
                bulbs[i] = new SimpleBulb(serial);  
            
            }
        }

        public override string showState()
        {
            bool evenMin = DateTime.Now.Minute % 2 == 0;
            StringBuilder sb = new StringBuilder();
            SimpleBulb currentBulb;

            for (int i = 0; i < bulbs.Length; i++)
            {
                 currentBulb = bulbs[i];
                if ((evenMin && currentBulb.Serial % 2 == 0) || (evenMin==false && currentBulb.Serial % 2 != 0))
                {
                    
                    currentBulb.State = true;

                }
                else
                {
                    currentBulb.State = false;

                }

                sb.Append("Bulb is " + (currentBulb.State ? "On - " : "Off - "));

            }

            return sb.ToString();
        }
    }
}
