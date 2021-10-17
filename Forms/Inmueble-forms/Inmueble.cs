using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble_forms
{
    abstract class Inmueble
    {
        protected String _direccion;
      

        protected Inmueble(String _direccion)
        {
            this._direccion = _direccion;
           
        }
    }
}
