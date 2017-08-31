using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    /**
     * Esto representa a un nodo de conexiones del servidor.
     * Solo acepta conexiones entrantes y guarda las conexiones
     * en una lista, el cual lee y escribe en el socket del cliente.
     * Todos los packets recividos son almacenados en una lista el
     * cual será enviado al proceso ServerGame.exe y lo que devuelva
     * será enviado al cliente, segun el paquete esté identificado.
     * 
     * TODO: tomar parametro port para usar en el TcpListener
     */
    class Program
    {
        static public bool running = false;

        static void Main(string[] args)
        {
            // iniciamos las conexiones de escucha TODO: el primer parametro de TcpListener es obsoleto?
            TcpListener listener = new TcpListener(8001);

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
        }
    }
}