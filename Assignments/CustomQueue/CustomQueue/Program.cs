using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomQueue
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create a GameQueue object
			GameQueue newQueue = new GameQueue();

			//Populate the Queue object with 12 new strings of players,
			//using the Enqueue method to add each item to the end of the list

			//Fun Fact: These are actually me and my friends gamer tags
			newQueue.Enqueue("gamerjames");         //1
			newQueue.Enqueue("JcTheToaster");       //2
			newQueue.Enqueue("NightmareEra");       //3
			newQueue.Enqueue("Omega0322");          //4
			newQueue.Enqueue("Beta Hoofed");        //5
			newQueue.Enqueue("gregsauce236");       //6
			newQueue.Enqueue("iiTroglodyte");       //7
			newQueue.Enqueue("LegacyxMFrog");       //8
			newQueue.Enqueue("PhantomEra");         //9
			newQueue.Enqueue("TheQueenWolf");       //10
			newQueue.Enqueue("RAZORTOOTH0208");     //11
			newQueue.Enqueue("Twilight Purity");    //12

			//State the current amount of strings in the GameQueue object
			Console.WriteLine("Current players in queue : " + newQueue.Count);

			//Uses the Peek method to see the first item without removing it
			Console.WriteLine("Queue Peek : " + newQueue.Peek() + "\n");

			//Activate a Dequeue method for each object in the newQueue object until it's empty
			while(newQueue.Count != 0)
			{
				//Unlike a stack that prints and removes the latest item added to it,
				//A queue will print and remove the first item added, 
				//esentially working opposite to how a stack would
				Console.WriteLine("Player '" + newQueue.Dequeue() + "' has joined the server : " 
					+ newQueue.Count + " player(s) left in queue");
			}

			//Confirm no players left in the queue
			Console.WriteLine("\nCurrent players in queue : " + newQueue.Count + "\n");
			Console.WriteLine("Beginning Team Deathmatch...");
		}
	}
}
