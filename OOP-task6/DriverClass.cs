using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task6
{
    internal class DriverClass
    {

        public static void Main(string[] args) { 
        ColoredLighstring cS = new ColoredLighstring(5);

         SimpleLightstring sS = new SimpleLightstring(5);


            while (true)
            {
                Console.WriteLine(cS.showState()+"\n");
               
                Console.WriteLine(sS.showState());

                Console.ReadKey(true); //press a key to continue looping, that way you can check the state when the time changes
            }


        }
    }
}
