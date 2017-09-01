using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServerListener
{
    /**
     * Esto representa a un nodo de conexiones del servidor.
     * Solo acepta conexiones entrantes y guarda las conexiones
     * en una lista, el cual lee y escribe en el socket del cliente.
     * Todos los packets recibidos son almacenados en una lista el
     * cual será enviado al proceso ServerGame.exe y lo que devuelva
     * será enviado al cliente, segun el paquete esté identificado.
     * 
     * TODO: tomar parametro port para usar en el TcpListener
     */
    class Program
    {
        static public Clients clients;
        static public ClientsListener listener;
        static public ServerConnector connector;

        static public bool running = true; // para indicar que se debe finalizar el programa
        static public bool connected = true; // solo para conocer el estado de ServerConnector

        static void Main(string[] args)
        {
            // lista de clientes
            clients = new Clients();

            // conexion al servidor
            connector = new ServerConnector();
            connector.Start();

            // conexion de los clientes
            listener = new ClientsListener();
            listener.Loop(); // loop infinito
        }
    }
}