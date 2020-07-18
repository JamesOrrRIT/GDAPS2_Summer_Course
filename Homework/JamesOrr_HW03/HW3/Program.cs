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
            bool check1 = int.TryParse(Console.ReadLine(), out rows);    //Checks the user's input

            while(!check1 || rows < 1 || rows > 500)    //While the input is not an int or out of the range....
            {
                //The user will have to enter a different value
                Console.WriteLine("Invalid value entered. Use an integer in the range of 1 to 500.");
                Console.WriteLine();
                Console.Write("Enter the number of rows (1 - 500) : ");
                check1 = int.TryParse(Console.ReadLine(), out rows);
            }

            Console.Write("Enter the number of columns (1 - 500) : ");
            bool check2 = int.TryParse(Console.ReadLine(), out cols);    //Checks the user's input

            while (!check2 || cols < 1 || cols > 500)    //Does the same stalling action until a valid input is entered
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

            for (int i = 0; i < rows; i++)    //Inside every row....
            {
                for (int j = 0; j < cols; j++)    //And inside every column....
                {
                    numbers[i, j] = rng.Next(1, 11);    //We generate a number between 1 and 10
                }
            }

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
            Counter[] counterArray = new Counter[rows];    //The length of the array is equal to the number of rows

            // Populate the array
            for (int i = 0; i < rows; i++)
            {
                //Gives each Counter object a specific row of the array with the column information,
                //a number for the Thead ID, and the numbers array of data
                counterArray[i] = new Counter(i, cols, i, numbers);
            }

            // Create an array of Thread objects that use the CountRow method of
            // the Counter class
            Thread[] threadArray = new Thread[rows];    //An array equal to the number of rows
            for (int i = 0; i < rows; i++)
            {
                //Each thread in the array uses the CountRow method of each Counter in the counter array
                threadArray[i] = new Thread(counterArray[i].CountRow);
            }

            // Start all of the threads
            for (int i = 0; i < threadArray.Length; i++)
            {
                threadArray[i].Start();    //Starts the thread
                threadArray[i].Join();    //Waits for the thread to finish before starting the next one
            }

            // Wait for each thread to complete
            
            Console.WriteLine("All threads are done.");

            // Get the counts from each thread and sum them up
            int[] occurences = new int[10];    //An int array that will keep track of the number of occurences

            //For each counter in the array....
            for (int i = 0; i < counterArray.Length; i++)
            {
                //For each section of that Counter's counts array....
                for (int j = 0; j < 10; j++)
                {
                    //If the counts array equals the index of a certain number
                    if (counterArray[i].Counts[j] == j + 1)
                    {
                        //The value of that occurence will increment by 1
                        occurences[j] += 1;
                    }
                }
            }

            // List the results
            Console.WriteLine("\nFinal Results:");
            for (int i = 1; i < 11; i++)
            {
                //The number of times a number between 1 and 10 occur prints here
                Console.WriteLine("Value : " + i + "   Occurences: " + occurences[i - 1]);
            }
        }
    }
}
