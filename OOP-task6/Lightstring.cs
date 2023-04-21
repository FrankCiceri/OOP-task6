namespace OOP_task6
{
    public abstract class Lightstring
    {
        protected SimpleBulb[] bulbs;

        public abstract string showState();


        public Lightstring(int numBulbs)
        {

           bulbs = new SimpleBulb[numBulbs];
        }


    }
}