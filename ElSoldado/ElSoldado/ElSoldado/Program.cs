using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElSoldado.Properties;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado miSoldado = new Soldado();
            Revolver miRevolver = new Revolver();
            Rifle miRifle = new Rifle();
            Escopeta miEscopeta = new Escopeta();
            int opcion = 0;



            do
            {
                Console.Clear();
                Console.WriteLine("\n-==Bienvenido al campo de entrenamiento, Soldado ==-");
                Console.WriteLine("\n\nQue desea hacer?");
                Console.WriteLine("\nPresione el numero correspondiente a la opcion del menu");
                Console.WriteLine("\n\n1. Recoger Arma.");
                Console.WriteLine("\n2. Dejar arma.");
                Console.WriteLine("\n3. Disparar.");
                Console.WriteLine("\n4. Ver arma en uso.");
                Console.WriteLine("\n5. Salir.");

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    

                    switch (opcion)
                    {
                        case 1:
                            int opcion1;
                            Console.WriteLine("\nPor favor, escoja el arma que desea utilizar:");
                            Console.WriteLine("\n\n1. Revolver");
                            Console.WriteLine("\n2. Rifle");
                            Console.WriteLine("\n3. Escopeta");
                            Console.WriteLine("\n4. Volver atras");

                            try
                            {
                                opcion1 = int.Parse(Console.ReadLine());
                                
                                switch (opcion1)
                                {
                                    case 1:
                                        miSoldado.RecogerArma(miRevolver);
                                        break;
                                    case 2:
                                        miSoldado.RecogerArma(miRifle);
                                        break;
                                    case 3:
                                        miSoldado.RecogerArma(miEscopeta);
                                        break;
                                    case 4:
                                        break;

                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("ERROR: No se reconoce ");
                            }

                            break;

                        case 2:
                            miSoldado.DejarArma();
                            break;

                        case 3:
                            miSoldado.Gatillar();
                            break;

                        case 4:
                            miSoldado.IdentificarArma();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR: No se reconoce.");
                }
                if (opcion != 5) continue;
                Console.WriteLine("Finalizando programa");
                Environment.Exit(0);
            } while (opcion != 5);
            
            
        }
    }
}
