using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    class GameStack : IStack
    {
        //Underlying storage
        private List<string> stackData = new List<string>();

        //Number of items in Stack
        public int Count => stackData.Count;

        //Checks if the GameStack is empty or not
        public bool IsEmpty => throw new NotImplementedException();

        //Return top value without removing it from the stack
        public string Peek()
        {
            return stackData[stackData.Count - 1];    //The top of the stack
        }

        //Return top value and remove it from the stack
        public string Pop()
        {
            //Obtain the top of the stack
            string topValue = stackData[stackData.Count - 1];

            //Removes the top item from the stack
            stackData.RemoveAt(stackData.Count - 1);

            //Returns the value
            return topValue;
        }

        //Add to the top of the stack
        public void Push(string str)
        {
            stackData.Add(str);
        }
    }
}
