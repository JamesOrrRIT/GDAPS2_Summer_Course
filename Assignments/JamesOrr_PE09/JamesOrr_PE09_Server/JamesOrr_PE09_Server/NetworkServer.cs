using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace JamesOrr_PE09_Server
{
    class NetworkServer
    {
        //Define the port
        const int port = 2112;

        static void Main(string[] args)
        {
            string ipAddress = "127.0.0.1";

            //Create a NetworkServer
            NetworkServer ns = new NetworkServer();
            ns.Run(ipAddress);
        }

        //Define run method
        private void Run(string ipAddress)
        {
            //Create an IPAddress object
            IPAddress address = IPAddress.Parse(ipAddress);

            //Create a listener to listen for the client
            TcpListener listener = new TcpListener(address, port);
            listener.Start();

            //Infinite loop
            while(true)
            {
                try
                {
                    Console.WriteLine("Waiting for connections");

                    //Block until a client connects
                    Socket socket = listener.AcceptSocket();
                    Console.WriteLine("Connected to client");

                    //Streamreader to read in the message
                    StreamReader sr = new StreamReader(new NetworkStream(socket));

                    //Read a line of input
                    string fromClient = sr.ReadLine();
                    Console.WriteLine("Recieved: " + fromClient);

                    int rolls = int.Parse(fromClient.Split(' ')[1]);    //Gets the number of rolls from the string
                    int sides = int.Parse(fromClient.Split(' ')[4]);    //Gets the number of sides from the string
                    Random rng = new Random();    //Creates a random that uses the number of sides as the max
                    string rollResults = string.Empty;    //Creates empty string to store results

                    for (int i = 0; i < rolls; i++)
                    {
                        rollResults += rng.Next(1, sides + 1) + ", ";    //Chooses between 1 and the side count, then add it to the string
                        //The "+ 1" ups the side count, as normally it would be one less than the given number
                    }
                    
                    //Write the roll results on it's own console
                    StreamWriter sw = new StreamWriter(new NetworkStream(socket));
                    Console.WriteLine("Roll Results: " + rollResults);
                    Console.WriteLine();

                    //Sends the results back to the client
                    sw.WriteLine(rollResults);
                    sw.Flush();

                    //Close the socket
                    socket.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception in Run: " + e.Message);
                }
            }
        }
    }
}
