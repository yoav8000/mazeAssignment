﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using TheClientDll;
using TheMazeGui.Model.TheSinglePlayerModel;

namespace TheClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            System.Threading.Thread.Sleep(1000);// make sure that the server will react to the connection request.

            int port = int.Parse(ConfigurationManager.AppSettings["portNumber"]);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);


            SinglePlayerModel p = new SinglePlayerModel(new SinglePlayerClient());

            ///debugging
            //IClient SPC = new SinglePlayerClient();
            p.Connect("127.0.0.1", port);
            p.SendMessageToServer("generate maze 10 10");
            string result = p.RecieveMessageFromServer();
            p.SendMessageToServer("solve maze 1");
            string result1 = p.RecieveMessageFromServer();
            p.Disconnect();


            Client client = new Client(ep, port);
            
            Task task = new Task(() =>//create a reading thread from the server.
            {
                while (true)
                {
                    while (client.Communicate)
                    {
                        client.ReadMessage();
                    }
                    System.Threading.Thread.Sleep(50);
                }
            });
            task.Start();
            Task task1 = new Task(() =>//create a writing thread to the server.
            {
                while (true)
                {
                    while (client.Communicate)
                    {
                        client.WriteMessage();
                    }
                    
                }
            });
            task1.Start();

            task.Wait();
            task1.Wait();
    
            client.CloseConnection();
           */
        }
    }
}
