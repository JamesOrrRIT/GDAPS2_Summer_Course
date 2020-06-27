using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;    //Most be here for threading to work

namespace JamesOrr_PE07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new array of threads
            Thread[] testArray = new Thread[100];

            //Loop that runs a number of times equal to the array length
            for (int i = 0; i < testArray.Length; i++)
            {
                Number newNumber = new Number(i);    //Create new Number object, with the loop control variable being the Number's value
                Thread newThread = new Thread(newNumber.Print);    //Create new thread using the new Number object's Print method

                testArray[i] = newThread;    //Add the new thread to the array
                newThread.Start();    //Runs the thread before looping again

                //[When trying to run with 5 Threads] The numbers ranging from 0 to 4 were listed in a random order
                //Each number is displayed in a random pattern because Threads stop wherever they like in the code, allowing another thread to start, then the first one would continue later
                
                //[When letting the number print 100 times] The numbers still printed in random intervals from 0 to 4

                //[When creating 100 threads] The output is no differet, it still prints in random intervals of increasing numbers, sometimes skipping numbers, then going back to those later
                //It is actually more jumbled because the space between similar numbers is larger
                //I think that it's because there are more threads that are trying to run at once and they interupt each other more frequently
            }
        }
    }
}
