using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class Validaciones
    {
        public int ValidarNumero(string numero, int salidanumero)
        {
        
            if(!int.TryParse(numero, out salidanumero))
            {
                Console.WriteLine("Debe ingresar un dato numerico.");
            }
            else if (salidanumero<0 || salidanumero > 10)
            {
                Console.WriteLine("Debe ingresar un dato numerico entre 1 y 10.");
            }

            return salidanumero;
        }
    }
}
