using System;
using ElSoldado.Properties;

namespace ElSoldado
{
    class Revolver : Arma
    {
        public Revolver()
        {
            _nombre = "Revolver";
        }   

        public override void Disparar()
        {
           
            Console.WriteLine("Pum...");
            Console.ReadKey();
        }
    }
}