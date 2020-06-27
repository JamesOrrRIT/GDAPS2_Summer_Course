using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JamesOrr_PE08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new array that holds three threads
            Thread[] threadArray = new Thread[3];

            //Create 3 new child objects
            Child jacob = new Child("Jacob", "Who took my pail?");
            Child emma = new Child("Emma", "Don't call me that!");
            Child miles = new Child("Miles", "Give me your pudding!");

            //Create threads using the child objects and adds them to the array
            threadArray[0] = new Thread(jacob.Whine);
            threadArray[1] = new Thread(emma.Whine);
            threadArray[2] = new Thread(miles.Whine);

            //Loops for each thread in the array
            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i].Start();    //Gets each thread to read the child's saying, all jumbled together when each is set to start
                // Thread.Sleep(2000);    //Lets the initial thread finish, wait two seconds, then move on to the next
                threadArray[i].Join();    //Allows the current thread to finish before the next one starts without stopping
            }

            Console.WriteLine("KNOCK IT OFF!");

            //[5] The parent comment appeared in a random position early on in the commotion, then the whining continued afterwards

            //[6] Once Thread.Sleep was put in, Jacob's lines read first, then Emma, then Miles,
            // then the "KNOCK IT OFF" line, each written 2 full seconds after the last

            //[7]  By calling the Join Method for the current thread, the CPU lets the current thread finish it's commands,
            // then the loop will continue and move on to the next array, with the "KNOCK IT OFF" line appearing once all three are done
        }
    }
}
