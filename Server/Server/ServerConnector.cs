using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//es necesario agregar el namespace system.threads
using System.Threads;

namespace ServerListener
{
    class ServerConnector
    {
        public ServerConnector()
        {
        }

        public void Start()
        {
            // Thread thread = new Thread(new ThreadStart(Run));
            // thread.Start();
        }

        public void Run()
        {
            // iniciamos la conexion al servidor
            // TCPClient conn = TCPClient("127.0.0.1", 6000)
            // 
        }
    }
}
