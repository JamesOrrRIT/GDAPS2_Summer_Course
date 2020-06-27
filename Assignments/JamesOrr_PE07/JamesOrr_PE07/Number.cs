using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesOrr_PE07
{
    class Number
    {
        //Keeps track of the Number object's value
        private int num;

        //Parametized constructor that gets an int and saves it as the int num
        public Number(int numValue)
        {
            this.num = numValue;
        }

        public void Print()
        {
            //Prints the value 10 times on one line
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
