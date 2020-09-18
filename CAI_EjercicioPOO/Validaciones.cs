using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{

    public class Validaciones
    {
        public string ValidarTextoVacio(string variable)
        {
            string salidavariable;

            do
            {
                Console.WriteLine("Ingrese {0}: ", variable);
                salidavariable = Console.ReadLine();

                if (string.IsNullOrEmpty(salidavariable))
                {
                    Console.WriteLine("Error. Debe ingresar al menos un caracter.");
                }
            } while (string.IsNullOrEmpty(salidavariable));

            return salidavariable;
        }

        public int ValidarNumero(string variable)
        {
            int salidauserinput;
            string userinput;
            bool flag = false;
            do
            {
                Console.WriteLine("Ingrese {0}.", variable);
                userinput = Console.ReadLine();
                if (!int.TryParse(userinput, out salidauserinput))
                {
                    Console.WriteLine("Error. Debe ingresar un dato numerico.");
                }
                else if (salidauserinput < 0)
                {
                    Console.WriteLine("Error. Debe ingresar un dato numerico positivo.");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);

            return salidauserinput; 
        }
        


        //By maru
        //public static int Numero(string mensaje)
        //{
        //    int retorno;
        //    do
        //    {
        //        Console.WriteLine("Ingrese " + mensaje + ": ");
        //        if (!int.TryParse(Console.ReadLine(), out retorno))
        //        {
        //            Console.WriteLine("Error. Ingrese un valor numerico. Reintente...");
        //        }

        //    } while ();
        //    return retorno;
        //}

        //By maru
        //public static string IngresoTexto(string mensaje = "Ingrese el texto")
        //{
        //    string texto;
        //    //-Nombre(Distinto a vacío)
        //    do
        //    {
        //        // solicitar nombre
        //        Console.WriteLine(mensaje);
        //        texto = Console.ReadLine();
        //        // validar que es Distinto a vacío
        //    } while (texto == "");

        //    return texto;
        //}


        //No funciona porque devuelve el booleano pero no lo toma luego
        //public static bool ValidarString(string userinput)
        //{
        //    bool flag = true;

        //    if(string.IsNullOrEmpty(userinput))
        //    {
        //        Console.WriteLine("Error. Debe ingresar minimo un caracter.");
        //        flag = false;
        //    }
        //    return flag;
        //}

        //NO FUNCIONA
        //public string ValidarNumero(string userinput)
        //{
        //      string Msg = "";
        //      if (!int.TryParse(userinput, out int salidainput))
        //      {
        //          Msg = "Debe ingresar un dato numerico positivo.";
        //      }
        //      else if (salidainput < 0)
        //      {
        //          Msg = "Debe ingresar un dato numerico positivo.";
        //      }
        //      return Msg;
        //}
        //NOFUNCIONA
        //public string ValidarNumero(string userinput)
        //{
        //    if(!int.TryParse(userinput, out int salidauserinput))
        //    {
        //        Console.WriteLine("Error. Ingresar dato numerico.");
        //    }
        //    else if (salidauserinput < 0)
        //    {
        //        Console.WriteLine("Error. Ingresar dato numerico positivo.");
        //    }
        //    return salidauserinput;
        //}

    }
}
