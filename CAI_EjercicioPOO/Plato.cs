using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class Plato
    {
        private string _nombre;
        private string _tipo; //entrada, plato fuerte, postre
        private int _precio;
        private string _acompanamiento;

        private string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private string Acompanamiento
        {
            get { return _acompanamiento; }
            set { _acompanamiento = value; }
        }

        //public Plato() { }

        public Plato(string Nombre, string Tipo, string Acompanamiento, int Precio)
        {
            this._nombre = Nombre;
            this._tipo = Tipo;
            this._acompanamiento = Acompanamiento;
            this._precio = Precio;
        }

       

        public Plato()
        {
            Validaciones V = new Validaciones();

            do
            {

                bool flag = false;
                Console.WriteLine("Ingrese el nombre del plato: ");
                this._nombre = Console.ReadLine();
                V.ValidarString(this._nombre);

            } while (flag == false);
            

            try
            {
                Console.WriteLine("Ingrese el precio del plato: ");
                this._precio = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e1)
            {
                Console.WriteLine(e1.Message);
            }


            
            
            
        }

        public override string ToString()
        {
            return string.Format("Nombre del plato: {0} - Precio del plato: {1}.", Nombre, Precio);

        }




    }
}
