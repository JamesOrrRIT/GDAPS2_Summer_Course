using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;    //Allows threading to work

namespace JamesOrr_PE10_MultithreadServer
{
    class NetworkServer
    {
        static void Main(string[] args)
        {
            //A parsed IP Address to address multiple users
            IPAddress address = IPAddress.Parse("127.0.0.1");

            //Create the listener
            TcpListener listener = null;

            try
            {
                //Try setting up the listener using the address and hard coded port equal to 3333
                listener = new TcpListener(address, 3333);
            }
            catch(Exception ex)
            {
                //Catches a potential error and display message
                Console.WriteLine("Error setting up listener : " + ex.Message);
                return;
            }

            //Start the listener object
            listener.Start();

            //Loop
            while(true)
            {
                try    //Attempts to run the program normally
                {
                    //Begins once a conncetion occurs
                    Console.WriteLine("Waiting for client");
                    Socket sock = listener.AcceptSocket();

                    //Create a worker object
                    Worker work = new Worker(sock);

                    //Create a new thread
                    Thread thr = new Thread(work.Run);

                    //Start the thread
                    thr.Start();
                    Console.WriteLine();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Connection error : " + ex.Message);
                }
            }
        }
    }
}
