using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class JugadorFutbol
    {
        private string nombre;
        private string equipo;
        private string posicion;
        private int velocidad;
        private int disparo;
        private int estadofisico;
        private int trabar;
        private string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        private string Equipo
        {
            get { return equipo; }
            set { this.equipo = value; }
        }

        private string Posicion
        {
            get { return posicion; }
            set { this.posicion = value; }
        }

        private int Velocidad
        {
            get { return velocidad; }
            set { this.velocidad = value; }
        }

        private int Disparo
        {
            get { return disparo ; }
            set { this.disparo = value; }
        }

        private int EstadoFisico
        {
            get { return estadofisico; }
            set { this.estadofisico = value; }
        }

        private int Trabar
        {
            get { return trabar; }
            set { this.trabar = value; }
        }

        public JugadorFutbol()
        {
            this.nombre = Nombre;
            this.equipo = Equipo;
            this.posicion = Posicion;
            this.velocidad = Velocidad;
            string velocidad = "";
            this.disparo = Disparo;
            this.estadofisico = EstadoFisico;
            this.trabar = Trabar;
            bool flag = false;

            Console.WriteLine("Ingrese las caracteristicas del jugador que quiere crear " + System.Environment.NewLine);

            do
            {
                Console.WriteLine("Ingrese el nombre del jugador: ");
                Nombre = Console.ReadLine();
                flag = ValidarString(Nombre);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el nombre del equipo al que pertenece el jugador: ");
                Equipo = Console.ReadLine();
                flag = ValidarString(Equipo);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la posicion dentro del campo de juego del jugador: ");
                Posicion = Console.ReadLine();
                flag = ValidarString(Posicion);
            } while (flag == false);

            //falta validar que si escrigbo un string en el userinput de los int tire error pero no puedo
            do
            {
                Console.WriteLine("Ingrese la velocidad del jugador: ");
                Velocidad = Convert.ToInt32(Console.ReadLine());
                flag = ValidarEntero2(Velocidad);
            } while (flag == false);
            do
            {
                Console.WriteLine("Ingrese la fuerza de disparo al arco del jugador: ");
                Disparo = int.Parse(Console.ReadLine());
                flag = ValidarEntero2(Disparo);
            } while (flag == false);
            do
            {
                Console.WriteLine("Ingrese el estado fisico que tiene el jugador: ");
                EstadoFisico = Convert.ToInt32(Console.ReadLine());
                flag = ValidarEntero2(EstadoFisico);
            } while (flag == false);
            do
            {
                Console.WriteLine("Ingrese la fuerza a la hora de trabar la pelota que tiene el jugador: ");
                Trabar = Convert.ToInt32(Console.ReadLine());
                flag = ValidarEntero2(Trabar);
            } while (flag == false);


            bool ValidarString(string userinput)
            {
                bool validar = false;
                if (string.IsNullOrEmpty(userinput))
                {
                    Console.WriteLine("Error. No ingreso ningun dato.");
                }
                else
                {
                    validar = true;
                }
                return validar;   
            }
            //no funciona
            bool ValidarEntero(string userinput, int userinputsalida)
            {
                bool validar = false;
                if (int.TryParse(userinput, out userinputsalida))
                {
                    Console.WriteLine("Error. Debe ingresar un dato numerico del 1 al 10.");
                }
                else if (userinputsalida < 0 || userinputsalida > 10)
                {
                    Console.WriteLine("Error. Debe ingresar un dato numerico del 1 al 10.");
                }
                else
                {
                    flag = true;
                }
                return validar;
            }

            bool ValidarEntero2(int entero)
            {
                bool flagg = false;
                if(entero<0)
                {
                    Console.WriteLine("Debe ingresarse datos entre 1 y 10.");
                }
                else if(entero>10)
                {
                    Console.WriteLine("Debe ingresarse datos entre 1 y 10.");
                }
                else
                {
                    flagg = true;
                }
                
                return flagg;
            }

            
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} - Equipo: {1} - Posicion: {2} - Velocidad: {3} - Disparo: {4} - Estado fisico: {5} - Trabar: {6}",
                Nombre,
                Equipo,
                Posicion,
                Velocidad,
                Disparo,
                EstadoFisico,
                Trabar);
        }
        


        public void DispararAlArco()
        {
            Console.WriteLine("Calculando probabilidad de marcar gol....");
            if(Disparo >= 7 && Velocidad >= 5 && EstadoFisico >= 6)
            {
                Console.WriteLine("La probabilidad de marcar un Gol es media-alta.");
                if(Posicion == "delantero")
                    Console.WriteLine("Gol asegurado.");
            }
            else
            {
                Console.WriteLine("La probabilidad de marcar un Gol es baja.");
            }
        }

        public void Defender()
        {
            Console.WriteLine("Calculando probabilidad de defender....");
            if (Trabar >= 7 && EstadoFisico >= 5)
            {
                Console.WriteLine("La probabilidad de defender efectivamente y quitar la pelota es media-alta");
                    if(Posicion == "Defensor")
                    {
                        Console.WriteLine("Quite de pelota asegurado.");
                    }
            }
            else
            {
                Console.WriteLine("La probabilidad de defender efectivamente y quitar la pelota es baja");
            }
        }

        public void realizarEntrenamientoFisico()
        {
            EstadoFisico++;
        }


    }
}
