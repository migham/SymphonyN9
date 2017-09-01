using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace ServerListener
{
    class Clients
    {
        //TODO: propiedad de lista de elementos, donde se almacenan los objetos Client
        //private array de Clients lista;

        public Clients()
        {
        }

        public void Add(Socket sock)
        {
            //TODO 
            Client nuevocliente = new Client();

            //TODO
            //lista.add(nuevocliente);

            nuevocliente.Start();
        }
    }
}
