using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace JamesOrr_PE09_Client
{
    class NetworkClient
    {
        //Port Numbers
        const int port = 2112;

        static void Main(string[] args)
        {
            //Get IP Address for the server
            string ipAddress = "127.0.0.1";    //Local host

            //Create a networkClient object
            NetworkClient nc = new NetworkClient();

            //Connect to server
            nc.Connect(ipAddress);
        }
        //Handles connection to the server
        private void Connect(string ipAddress)
        {
            //Set up a Socket
            TcpClient socket;
            StreamWriter sw = null;

            //Try to create a new client
            try
            {
                socket = new TcpClient(ipAddress, port);
            }
            catch(Exception e)
            {
                //List the error and exit
                Console.WriteLine(e.Message);
                return;
            }

            //Try to send some code
            try
            {
                //Streamwriter to send data to the internet
                sw = new StreamWriter(socket.GetStream());

                //Asks the user how many die rolls they want
                Console.Write("How many die rolls? ");
                int rolls = int.Parse(Console.ReadLine());

                //Asks the user how many sides each die should have
                Console.Write("How many sides on the die? ");
                int sides = int.Parse(Console.ReadLine());

                //Send the number of rolls and sides to the server
                sw.WriteLine("Roll " + rolls + " di(c)e with " + sides + " sides on a die");
                sw.Flush();

                //Recieves the roll results from the server
                StreamReader sr = new StreamReader(socket.GetStream());
                string fromServer = sr.ReadLine();
                Console.WriteLine("From server: " + fromServer);

                //Close the connection
                socket.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error sending message: " + e.Message);
            }
        }
    }
}
