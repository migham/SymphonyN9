using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServerListener
{
    class Client
    {
        public Socket sock;
        public String ip;

        public Client()
        {
            // se comprueba que exista conexion con GameServer

            // se envia PacketServerOffline en caso de que no exista conexion y se cierra el cliente

            // se inicia los procesos de lectura y escritura
        }

        public void Start()
        {
        }
    }
}
