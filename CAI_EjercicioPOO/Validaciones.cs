using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{

    class Validaciones
    {


        public string ValidarString(string userinput)
        {
            bool flag = false;
            if(string.IsNullOrEmpty(userinput))
            {
                Console.WriteLine("Debe ingresar algun caracter.");
            }
            else
            {
                flag = true;
            }
            return userinput;
        }

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

        

        
       

    }
}
