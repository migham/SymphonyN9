using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // prevenir que corra más de una instancia del juego para evitar corrupcion al cargar o guardar
            if (AlreadyRunning()) return;
            // se carga el juego
            Game game = new Game();

            game.load();

            // se inicia el puerto de escucha para ServerListener o ServerNodeListener o como sea que se llame jaja ServerPapasFritasListener :v
            ConnectionsListener listen = new ConnectionsListener();
            listen.start();

            // game loop - parte logica y loop infinito
            game.loop();
        }
    }
}
