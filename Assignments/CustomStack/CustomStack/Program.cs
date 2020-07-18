using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create new GameStack object
			GameStack myStack = new GameStack();

			//Populate the Stack with 12 different strings
			myStack.Push("This line was added first.");                                          //1
			myStack.Push("There will be twelve of these lines.");                                //2
			myStack.Push("Even though this line is the third one,");                             //3
			myStack.Push("It will be the third to last line printed out.");                      //4
			myStack.Push("What you are reading right now is the lines");                         //5
			myStack.Push("Being add in order and printed out the other way.");                   //6
			myStack.Push("This will probably be hard to read once it prints out,");              //7
			myStack.Push("But that's the fundametals of how a stack works,");                    //8
			myStack.Push("Start at the top, and work your way down.");                           //9
			myStack.Push("We're reaching the final line right about now.");                      //10
			myStack.Push("Here's the penultimate line.");                                        //11
			myStack.Push("Now this line was added last, but it's the first to be printed.");     //12

			//Prints out the current number of items in the stack
			Console.WriteLine("MyStack Current Count : " + myStack.Count);
			Console.WriteLine();

			//Prints out each object in the stack until the stack is empty
			//Because of how stacks read from the top to bottom, the lines above will be presented in reverse order
			while(myStack.Count != 0)
			{
				//Once we write out the line, we remove the line from the stack and move to the next one
				Console.WriteLine(myStack.Pop());
			}
			Console.WriteLine();

			//Prints out the number of objects in the stack one more time
			Console.WriteLine("MyStack Current Count : " + myStack.Count);
		}
	}
}
