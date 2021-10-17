using System;
using ElSoldado.Properties;

namespace ElSoldado{
    class Escopeta : Arma
        {

            public Escopeta()
            {
                _nombre = "Escopeta";
            }
            public override void Disparar()
            {
                
                Console.WriteLine("Paaa!!...");
                Console.ReadKey();
            }
        }
    
}