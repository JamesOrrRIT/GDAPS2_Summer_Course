using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread1Demo
{
    // used by threads to list numbers
    class NumberCounter
    {
        // attribute
        private int id; // thread number
        private static int counter; // shared variable

        // constructor
        public NumberCounter(int idNum)
        {
            id = idNum;
            counter = 0;
        }

        // method the thread executes
        public void Print()
        {
            // loop to list numbers
            for(int i = 0; i < 50; i++)
            {
                counter++;
                Console.WriteLine("Id: " + id + " Counter: " + counter);
            }
        }
    }
}
