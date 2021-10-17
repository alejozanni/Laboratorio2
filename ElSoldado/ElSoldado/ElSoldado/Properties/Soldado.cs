using System;
using ElSoldado.Properties;

namespace ElSoldado
{
    public class Soldado
    {
        private Arma _arma;
        private int _tiene;

        public Soldado()
        {
            _tiene = 0;
        }


        public void RecogerArma(Arma arma)
        {
            if (_tiene == 0)
            {
                Console.Clear();
                Console.WriteLine("Agarro el arma!");
                Console.WriteLine(arma.GetNombre());
                _arma = arma;
                _tiene = 1;
                Console.ReadKey();
            } else
            {
               Console.Clear();
               Console.WriteLine("El soldado ya tiene un/a " + _arma.GetNombre());
               Console.WriteLine("Deje el arma para agarrar otra!");
               Console.ReadKey();
            }
        }

        public void DejarArma()
        {
            if (_tiene == 1)
            {
               Console.Clear();
               Console.WriteLine("Se solto el arma " + _arma.GetNombre());
               _tiene = 0;
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No hay nada para soltar ");
                Console.ReadKey();
            }
        }

        public void Gatillar()
        {
            if (_tiene == 0)
            {
                Console.WriteLine("No hay nada para disparar. Por favor, recoge un arma.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Se disparo el arma " + _arma.GetNombre());
                _arma.Disparar();
            }
        }

        public void IdentificarArma()
        {
            if (_tiene == 0)
            {
                Console.WriteLine("No tiene ninguna arma en la mano.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Arma en uso: ");
                Console.WriteLine(_arma.GetNombre());
                Console.ReadKey();
            }
        }
        
        
    }
}