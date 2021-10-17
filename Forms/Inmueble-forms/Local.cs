using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble_forms
{
    class Local :  Inmueble
    {
        private int precioBase;
        private int antiguedad;
        private int m2;
        private int ventanas;

        public Local(int precioBase, int antiguedad, int m2, int ventanas, String _direccion)
            :base(_direccion)
        {
            this.precioBase = precioBase;
            this.antiguedad = antiguedad;
            this.m2 = m2;
            this.ventanas = ventanas;
        }

        public int calcularPrecioFinalLocal()
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
            if (m2 >= 50)
            {
                precio = precio * 1.01;
            }
            if (ventanas <= 1)
            {
                precio = precio * 0.98;
            }
            if (ventanas > 4)
            {
                precio = precio * 1.02;
            }

            return (int)precio;
        }

        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
