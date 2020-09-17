using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class ExcepcionFormatoInvalido : FormatException
    {
        public ExcepcionFormatoInvalido() : base("Debe ingresar dato numerico.")
        {
            
        }
    }
}
