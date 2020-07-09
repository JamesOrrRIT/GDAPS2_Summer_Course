using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

/* 
 * Some of the code in the Main method is already provided.
 * Those sections are not to be changed. Other sections have comments
 * indicating that you need to complete them.
 *        Prof. Bierre
 */
namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 0;   // number of rows
            int cols = 0;   // number of columns
            // Get the number of rows and columns from the user and validiate
            // the input. Valid values for both the rows and columns range from 
            // 1 to 500.
            Console.Write("Enter the number of rows (1 - 500) : ");
            bool check1 = int.TryParse(Console.ReadLine(), out rows);

            while(!check1 || rows < 1 || rows > 500)
            {
                Console.WriteLine("Invalid value entered. Use an integer in the range of 1 to 500.");
                Console.WriteLine();
                Console.Write("Enter the number of rows (1 - 500) : ");
                check1 = int.TryParse(Console.ReadLine(), out rows);
            }

            Console.Write("Enter the number of columns (1 - 500) : ");
            bool check2 = int.TryParse(Console.ReadLine(), out cols);

            while (!check2 || cols < 1 || cols > 500)
            {
                Console.WriteLine("Invalid value entered. Use an integer in the range of 1 to 500.");
                Console.WriteLine();
                Console.Write("Enter the number of columns (1 - 500) : ");
                check2 = int.TryParse(Console.ReadLine(), out cols);
            }

            // create the array to hold the random numbers, based on the
            // number of rows and columns the user requested
            int[,] numbers = new int[rows, cols];

            // populate the array with randomly selected integers
            // in the range of 1 to 10.
            Random rng = new Random();

            // Dump out the array to a text file named lastrun.txt. 
            // This file will be used to verify your program is working
            // correctly. DO NOT ALTER THIS CODE.
            try
            {
                StreamWriter output = new StreamWriter("lastrun.txt");

                // write out a comma delimited lines of text
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j < cols - 1)  // comma separated on same line
                        {
                            output.Write(numbers[i, j] + ",");
                        }
                        else // no comma after number, start a new line
                        {
                            output.WriteLine(numbers[i, j]);
                        }
                    }
                }
                // done - so close the file
                output.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception detected: " + ex.Message);
                Console.WriteLine("Exiting program");
                return;
            }

            // Create an array of Counter class objects
            

            // populate the array
           

            // create an array of Thread objects that use the CountRow method of
            // the Counter class
            

            // start all of the threads
            

            // wait for each thread to complete
            
            Console.WriteLine("All threads are done.");

            // get the counts from each thread and sum them up
            

            // list the results
            Console.WriteLine("\nFinal Results:");
        }
    }
}
