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
        private int _stock;
        private string _bebidas;

        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Bebidas
        {
            get { return _bebidas; }
            set { _bebidas = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        //public Plato() { }

        public Plato(string Nombre, string Tipo, string Bebidas, int Precio, int Stock)
        {
            this._nombre = Nombre;
            this._tipo = Tipo;
            this._bebidas = Bebidas;
            this._precio = Precio;
            this._stock = Stock;
        }

       

        public Plato()
        {
            Validaciones V = new Validaciones();
            this._nombre = Nombre;
            this._precio = Precio;
            this._tipo = Tipo;
            this._bebidas = Bebidas;

            Nombre = V.ValidarTextoVacio("nombre del plato");
            Precio = V.ValidarNumero("precio del plato");
            Tipo = V.ValidarTextoVacio("tipo de plato");
            Bebidas = V.ValidarTextoVacio("si lleva bebidas");

        }

        public override string ToString()
        {
            return string.Format("Nombre del plato: {0} - Precio del plato: {1} - Tipo de plato: {2} - Bebidas: {3} - Stock: {4}.", Nombre, Precio, Tipo, Bebidas, Stock);
        }




    }
}
