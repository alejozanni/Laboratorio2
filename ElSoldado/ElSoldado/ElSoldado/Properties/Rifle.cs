using System;
using ElSoldado.Properties;

namespace ElSoldado
{
    class Rifle : Arma
    {

        public Rifle()
        {
            _nombre = "Rifle";
        }
        public override void Disparar()
        {
            
            Console.WriteLine("Pum Pum Pum!...");
            Console.ReadKey();
        }
    }
}