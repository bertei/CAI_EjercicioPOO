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
        private int totalPersonal;
        private int totalMesas;
        private int totalCapacidadPersonas;
        private bool estado;
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

        private int TotalPersonal
        {
            get { return totalPersonal; }
            set { this.totalPersonal = value; }
        }

        private int TotalMesas
        {
            get { return totalMesas; }
            set { this.totalMesas = value; }
        }

        private int TotalCapacidad
        {
            get { return totalCapacidadPersonas; }
            set { this.totalCapacidadPersonas = value; }
        }

        private bool Estado
        {
            get { return estado; }
            set { this.estado = value; }
        }

        public Restaurant() { }

        public Restaurant(string Restaurante, string Direccion, string Tipo, int TotalMesas, int TotalCapacidad, int TotalPersonal, bool Estado)
        {
            this.nombreRestaurant = Restaurante;
            this.direccion = Direccion;
            this.tipoDeRestaurant = Tipo;
            this.totalMesas = TotalMesas;
            this.totalCapacidadPersonas = TotalCapacidad;
            this.totalPersonal = TotalPersonal;
            this.estado = Estado;
        }
                                                                                                                                                                                          
        public override string ToString()
        {
            return string.Format("Nombre: {0} - Direccion: {1} - Tipo: {2} - Total Mesas: {3} - TotalCapacidad: {4} - TotalPersonal: {5} - Estado: {6}.",
                Restaurante,
                Direccion,
                Tipo,
                TotalMesas,
                TotalCapacidad,
                TotalPersonal,
                Estado
                );
        }
                                                                                                                    
        public string HorarioAperturayCierre()
        {

            int nowHour = DateTime.Now.Hour;
            string msg = "";

            if (nowHour > 09 && nowHour < 21)
            {
                msg = "El horario actual es: " + nowHour.ToString() + "hs. Cumple con el horario de apertura (09:00 a 21:00).";
                Estado = true;
            }
            else
            {
                msg = "Cerrado";
                Estado = false;
            }

            return msg;
            
        }

        public void MedidasCovid()
        {
            int stockAlcoholGel, stockGuantes;

            Console.WriteLine("Restaurante: {0}.", Restaurante);
            Console.WriteLine(
                "Las medidas que se tienen que cumplir para poder abrir en tiempos de cuarentena son: " + Environment.NewLine +
                "Contar con stock mayor a 20 de Alcohol en gel y Guantes de latex" + Environment.NewLine +
                "Como maximo: 50 clientes, 15 mesas afuera y 15 empleados."
                );
            Console.WriteLine("Ingrese la cantidad de alcohol en gel en stock: ");
            stockAlcoholGel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de guantes latex en stock: ");
            stockGuantes = Convert.ToInt32(Console.ReadLine());


            if (TotalCapacidad <= 50 && TotalMesas <= 15 && TotalPersonal <= 15)
            {
                if(stockAlcoholGel >= 20 && stockGuantes >= 20)
                {
                    Estado = true;
                    Console.WriteLine("Se cumple con el protocolo del Covid. Se puede abrir.");
                }
                
            }
            else
            {
                Estado = false;
                Console.WriteLine("No se cumple con el protocolo del Covid. No se puede abrir.");
            }
        }


    }
}
