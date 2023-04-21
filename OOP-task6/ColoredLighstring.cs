using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{
    public class ColoredLighstring : Lightstring

    {
        
        public ColoredLighstring(int numBulbs): base(numBulbs) {

            Console.WriteLine("Enter the serials for the bulbs");
            for (int i = 0;i<numBulbs; i++) {

                int serial = Convert.ToInt32(Console.ReadLine());
                bulbs[i] = new ColoredBulb(serial); //I did not understand the part about the multiplicity thing with the serial for the color,
                                                      //I would appreciate feedback on this, what I did is use module to get a value between 0 and 3 ,
            }                                       //and use that value on an enum to get the color




        }


        public override string showState()
        {
            bool evenMin = DateTime.Now.Minute%2 == 0;
            Console.WriteLine(evenMin);
            StringBuilder sb = new StringBuilder();
            ColoredBulb currentBulb;

            for ( int i = 0; i < bulbs.Length; i++) {
                currentBulb = (ColoredBulb)bulbs[i];

                if ((evenMin && currentBulb.Serial % 2 == 0) || (evenMin==false  && currentBulb.Serial % 2 != 0))
                {
                    currentBulb.State = true;

                }
                else {
                    currentBulb.State = false;

                }

                sb.Append(currentBulb.Type +" Bulb is " + (currentBulb.State ?"On - " : "Off - ") );

            }

           return sb.ToString();    

        }


       
    }
}
