using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class Pedido
    { 
        private Plato _plato;
        private Cliente _cliente;
        private ListaPlatos _listaplatos;
        public Pedido() { }

        public ListaPlatos listaPlatos
        {
            get { return _listaplatos; }
            set { _listaplatos = value; }
        }

        //VER
        public void pedidoTakeAway()
        {
            string platoElegido;
            ListaPlatos P1 = new ListaPlatos();
           
            Console.WriteLine("A continuacion se mostraran los platos disponibles para elegir: ");
            P1.AgregarPlatos();
            P1.MostrarPlatos();
           
            Console.WriteLine("Escriba el nombre del plato que quiere elegir: ");

        }

        public void pedidoComun()
        {
            int stockPedidos = 10;
            stockPedidos--;
            Console.WriteLine(stockPedidos);
        }


        
    }
}
