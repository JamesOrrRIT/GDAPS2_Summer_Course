using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ThreadedServerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // parse an IP address assuming both programs are on this machine
            IPAddress address = IPAddress.Parse("127.0.0.1");

            // create the TcpListener
            TcpListener listener = null;

            try
            {
                listener = new TcpListener(address, 2112);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error setting up listener: " + ex.Message);
                return;
            }

            // start listening
            listener.Start();

            // server loop
            while(true)
            {
                try
                {
                    // wait for a client
                    Console.WriteLine("Waiting for a client");
                    Socket sock = listener.AcceptSocket();

                    // create a Worker object
                    Worker work = new Worker(sock);

                    // create a new thread
                    Thread thr = new Thread(work.Run);

                    // start the thread
                    thr.Start();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Connection error: " + ex.Message);
                }
            }
        }
    }
}
