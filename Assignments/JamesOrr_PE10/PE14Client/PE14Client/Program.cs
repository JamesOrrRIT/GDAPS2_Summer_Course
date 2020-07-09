using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace ClientDemo
{
    class NetworkClient
    {
        // port numbers
        const int port = 3333; // server port better match this

        static void Main(string[] args)
        {
            // get IP address for the server
            // this next line works if the client and server are on the same machine
            string ipAddr = "127.0.0.1"; // localhost

            // create a networkClient object
            NetworkClient nc = new NetworkClient();

            // connect to the server
            nc.Connect(ipAddr);

        }

        // handles the connection to the server
        private void Connect(string ipAddr)
        {
            // set up a Socket
            TcpClient socket;
            StreamWriter sw = null;

            // try to create a new client
            try
            {
                socket = new TcpClient(ipAddr, port);
            }
            catch (Exception ex)
            {
                // list the error and exit
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Connected to the server");

            // try to send some code
            try
            {
                // streamwriter to send data to the internet
                sw = new StreamWriter(socket.GetStream());

                // get user input - enter string to send over
                Console.Write("Enter a string: ");
                string toSend = Console.ReadLine();
                sw.WriteLine(toSend);
                sw.Flush();

                // stream reader to get the response
                StreamReader sr = new StreamReader(socket.GetStream());
                string fromServer = sr.ReadLine();
                Console.WriteLine("From server: " + fromServer);

                // close the connection
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending message: " + ex.Message);
            }


        }
    }
}