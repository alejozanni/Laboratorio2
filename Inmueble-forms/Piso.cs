using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble_forms
{
    class Piso : Inmueble
    {
        private int precioBase;
        private int antiguedad;
        private int piso;

        public Piso(int precioBase, int antiguedad, int piso, String _direccion)
            : base(_direccion)
        {
            this.precioBase = precioBase;
            this.antiguedad = antiguedad;
            this.piso = piso;
        }

        public int calcularPrecioFinalPiso()
        {
            double precio;
            precio = precioBase;

            if (antiguedad < 15)
            {
                precio = precio * 0.99;
            }
            else
            {
                precio = precio * 0.98;
            }
            if (piso >= 3)
            {
                precio = precio * 1.03;
            }

            return (int)precio;
        }

        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
