using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            // Demonstrates the use of the Dictionary class
            Dictionary<int, string> inv = new Dictionary<int, string>();  // create object

            // populate the dictionary
            inv.Add(2, "Hex bolt");
            inv.Add(3, "Flange");
            inv.Add(4, "Cotter pin");
            inv.Add(5, "Bearing");
            inv.Add(7, "Widget");
            inv.Add(9, "Connector");

            // loop to locate objects in the dictionary
            while(true)
            {
                // get user input
                Console.Write("Enter item number: (0 or less to exit): ");
                string itemStr = Console.ReadLine();

                // convert string to an int
                int key = 0;
                Boolean parsed = int.TryParse(itemStr, out key);

                // handle bad input
                if(parsed == false)
                {
                    // bad value - error message
                    Console.WriteLine("Bad value entered - try again.");
                    continue;
                }

                // exit the loop?
                if(key <= 0)
                {
                    break; // leave the loop
                }

                // see if the key exists
                if(inv.ContainsKey(key) == true) // key is present
                {
                    Console.WriteLine("Key: " + key + " Value: " + inv[key]);
                }
                else // no match for the key
                {
                    Console.WriteLine("A key of " + key + " does not exist");
                }
            }

            // add a new value
            inv.Add(6, "Frame");
            // inv.Add(7, "bad entry"); // this will cause an exception because 7 is already present

            // remove an entry
            inv.Remove(3);

            // list the entire dictionary
            foreach(int myKey in inv.Keys)
            {
                Console.WriteLine("Key: " + myKey + " Value: " + inv[myKey]);
            }
        }
    }
}
