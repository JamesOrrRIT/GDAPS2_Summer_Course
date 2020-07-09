using System;
using System.Net.Sockets;
using System.IO;

namespace ThreadedServerDemo
{
    // Actual connection work is done here in separate threads
     class Worker
    {
        private Socket sock; // used for connectivity

        // constructor saves the socket
        public Worker(Socket sock)
        {
            this.sock = sock;
        }

        // connection and processing for the client
        public void Run()
        {
            // set up two way communication
            StreamReader sr = new StreamReader(new NetworkStream(sock));
            StreamWriter sw = new StreamWriter(new NetworkStream(sock));

            // get the request
            string request = sr.ReadLine();
            Console.WriteLine("From client: " + request);

            string response = "You sent: " + request + " at " + DateTime.Now.ToString();
            sw.WriteLine(response);
            sw.Flush();

            // close the connection
            sock.Close();
        }
    }
}