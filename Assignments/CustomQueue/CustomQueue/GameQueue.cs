using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomQueue
{
    class GameQueue : IQueue
    {
        //A list that will hold the strings we create
        private List<string> data = new List<string>();

        //A condition that will return true if the list is empty
        public bool IsEmpty => throw new NotImplementedException();

        //Equal to the number of entries in the List of strings
        public int Count => data.Count;

        //Returns the first item in the List and removes it
        public string Dequeue()
        {
            //Sets a string equal to the first item in the list
            string item = data[0];

            //Removes the first item and shift everything else to the side
            //data[1] would become data[0] after this and so on
            data.RemoveAt(0);

            //Returns the string that originally came from the beginning of the list
            return item;
        }

        //Saves item at the end of the list
        public void Enqueue(string str)
        {
            //Places the string item in the back of the list
            data.Add(str);
        }

        //Gets and returns the first entry in the list without removing it
        public string Peek()
        {
            return data[0];
        }
    }
}
