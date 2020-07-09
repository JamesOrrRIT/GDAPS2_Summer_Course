using System;
using System.Net.Sockets;
using System.IO;

namespace JamesOrr_PE10_MultithreadServer
{
    //Connection occurs in this class
    class Worker
    {
        private Socket sock;    //Used to connect

        //Constructor
        public Worker(Socket sock)
        {
            this.sock = sock;
        }

        //Connection and processing for client
        public void Run()
        {
            //Set up two way communication
            StreamReader sr = new StreamReader(new NetworkStream(sock));
            StreamWriter sw = new StreamWriter(new NetworkStream(sock));

            //Get request from client and print it out
            string request = sr.ReadLine();
            Console.WriteLine("From Client : " + request);

            /*    //Original idea of counting the characters in the request
            //Takes the message, then counts the length of it
            int messageCount = request.Length;

            //Return a string displaying the length of the message
            string response = "Your message was " + messageCount + " characters long, including spaces.";
            */

            //Ints to keep track of the uppercase and lowercase letters and anything else
            int capital = 0;
            int lowercase = 0;
            int remaining = 0;

            for(int i = 0; i < request.Length; i++)
            {
                if (char.IsUpper(request[i]))    //If the current character is uppercase....
                {
                    capital += 1;    //We add to the capital letter count
                }

                else if (char.IsLower(request[i]))    //If the current character is lowercase....
                {
                    lowercase += 1;    //We add to the lowercase letter count
                }

                else    //If the current character is a space, period, comma, or anything other than a upper or lowercase letter....
                {
                    remaining += 1;    //We add to the remaining character counter
                }
            }

            //Creates a string that describes the items inside the recieved string
            string response = "Your message had " + capital + " captial letters, " + lowercase + " lowercase letters, and " + remaining + " spaces and/or other characters.";

            sw.WriteLine(response);    //Returns the response to the client

            sw.Flush();    //Flushes the streamwriter before the program can end

            //Close the conncetion once request is complete
            sock.Close();
        }
    }
}