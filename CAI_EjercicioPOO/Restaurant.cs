using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class Restaurant
    {
        private string nombreRestaurant;
        private string direccion;
        private string tipoDeRestaurant;
        private string totalPersonal;
        private string totalMesas;
        private string totalCapacidadPersonas;

        private string Restaurante
        {
            get { return nombreRestaurant; }
            set { this.nombreRestaurant = value; }
        }

        private string Direccion
        {
            get { return direccion; }
            set { this.direccion = value; }
        }

        private string Tipo
        {
            get { return tipoDeRestaurant; }
            set { this.tipoDeRestaurant = value; }
        }

        private string TotalPersonal
        {
            get { return totalPersonal; }
            set { this.totalPersonal = value; }
        }

        private string TotalMesas
        {
            get { return totalMesas; }
            set { this.totalMesas = value; }
        }

        private string TotalCapacidad
        {
            get { return totalCapacidadPersonas; }
            set { this.totalCapacidadPersonas = value; }
        }

        public Restaurant()
        {
            this.nombreRestaurant = Restaurante;
            this.direccion = Direccion;
            this.tipoDeRestaurant = Tipo;
            this.totalMesas = TotalMesas;
            int totalm = 0;
            this.totalCapacidadPersonas = TotalCapacidad;
            this.totalPersonal = TotalPersonal;
            bool flag = false;
            Validaciones V = new Validaciones();

            Console.WriteLine("Ingrese el total de mesas que tiene el restaurante: ");
            totalMesas = Console.ReadLine();
            V.ValidarNumero(TotalMesas, totalm);






        }

        public override string ToString()
        {
            return string.Format("{0}", TotalMesas);
        }
    }
}
