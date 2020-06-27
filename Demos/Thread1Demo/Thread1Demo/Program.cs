using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // needed for threading

namespace Thread1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 2 NumberCounters
            NumberCounter nc1 = new NumberCounter(1);
            NumberCounter nc2 = new NumberCounter(2);

            // create the threads
            Thread t1 = new Thread(nc1.Print);
            Thread t2 = new Thread(nc2.Print);

            // start the threads
            t1.Start();
            t2.Start();
        }
    }
}
