using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW3
{
    class Counter
    {
        //Attributes
        int[] counts = new int[10];    //Int array to hold occurence count for values from 1 to 10
        int rowNumber;    //Number of the row being proccessed
        int columnsInRow;    //Number of the columns in the row being proccessed
        int threadID;    //The ID number of this counter object's thread
        int[,] data;    //A 2D array which holds the data from the initial creation in Program

        //Properties
        public int[] Counts    //Returns an int array of occurence counts
        {
            get { return counts; }
            set { counts = value; }
        }

        //Constructor
        public Counter(int rows, int columns, int IDNumber, int[,] values)
        {
            this.rowNumber = rows;    //Interface takes in the number of rows being proccessed
            this.columnsInRow = columns;    //Interface takes in the number of columns in the row
            this.threadID = IDNumber;    //The ID for the thread to keep track of which ones are complete
            this.data = values;    //Fills the data array with the values we use
        }

        //Methods
        public void CountRow()
        {
            //Go through the designated row piece by piece
            for (int i = 0; i < columnsInRow; i++)
            {
                //The number will go from 1 to 10
                for (int j = 0; j < 10; j++)
                {
                    //If the current column's number is equivalent to a certain number
                    if(data[rowNumber, i] == j + 1)
                    {
                        //That section of the counts array will be incremented by 1
                        counts[j] += 1;
                    }
                }
            }

            //Prints that the thread is done
            Console.WriteLine("Thread " + threadID + " done.");
        }
    }
}
