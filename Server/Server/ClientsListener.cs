using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerListener
{
    class ClientsListener
    {
        public void Loop()
        {
            // iniciamos las conexiones de escucha TODO: el primer parametro de TcpListener es obsoleto?
            /* TcpListener listener = new TcpListener(8001);

             listener.Start();

             while (Program.running)
             {
                 Socket sock = listener.AcceptSocket();

                 if (sock)
                 {
                     // agregamos el socket como cliente
                     Clients.add(sock);
                 }
             }

             */
        }
    }
}
