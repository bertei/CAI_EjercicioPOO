using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class ListaPlatos
    {
        public List<Plato> ListPlatos = new List<Plato>();

        public void AgregarPlatos()
        {
            Plato p1 = new Plato("Milanesa suprema con papas", "Plato principal", "Agua", 300, 2);
            Plato p2 = new Plato("Ravioles con salsa", "Plato principal", "Coca cola", 350, 1);
            Plato p3 = new Plato("Papas fritas", "Acompaniamiento", "nada", 120, 1);

            //foreach(Plato platos in ListPlatos)
            //{
            //    ListPlatos.Add(platos);
            //}

            ListPlatos.Add(p1);
            ListPlatos.Add(p2);
            ListPlatos.Add(p3);
        }

        public void MostrarPlatos()
        {
            string acumulador = "";
            foreach(Plato listaplatos in ListPlatos)
            {
                acumulador += listaplatos.ToString() + Environment.NewLine;
            }

            Console.WriteLine("Lista de platos: ");
            Console.WriteLine(acumulador);
        }

    }
}
