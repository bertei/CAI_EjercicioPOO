using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<JugadorFutbol> ListaJugadores = new List<JugadorFutbol>();
            //JugadorFutbol A = new JugadorFutbol();
            //ListaJugadores.Add(A);
            //Console.WriteLine(A.ToString());
            //A.DispararAlArco();
            //A.Defender();

            ////////////////////////////////////////////////////////////////

            List<Restaurant> ListaRestaurantes = new List<Restaurant>();
            Validaciones V = new Validaciones();
            Restaurant R = new Restaurant();
            ListaRestaurantes.Add(R);
            Console.WriteLine(R.ToString());

        }

        
    }
}
