using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioPOO
{
    class Cliente
    {
        private string _nombre;
        private string _direccion;
        private int _dinerodisponible;
        private Pedido _pedido;

        private string Nombre
        {
            get { return _nombre; }
            set { this._nombre = value; }
        }

        private string Direccion
        {
            get { return _direccion; }
            set { this._direccion = value; }
        }

        private int DineroDisponible
        {
            get { return _dinerodisponible; }
            set { this._dinerodisponible = value; }
        }

        private Pedido Pedidoo
        {
            get { return _pedido; }
            set { this._pedido = Pedidoo; }
        }

        public Cliente() 
        {
            Validaciones V = new Validaciones();

            V.ValidarTextoVacio("el nombre del cliente: ");
            V.ValidarTextoVacio("la direccion del cliente: ");
            V.ValidarNumero("el dinero disponible del cliente: ");


        }

        public override string ToString()
        {
            return string.Format("Nombre del cliente: {0} - Direccion del cliente: {1} - Dinero disponible del cliente: {2}: ", Nombre, Direccion, DineroDisponible);
        }

        public void hacerPedido()
        {
            Pedidoo.pedidoComun();
        }


    }
}
