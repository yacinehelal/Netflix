using System;

namespace MG
{
    class Program
    {
        static void Main(string[] args)
        {
            string ultraHD;
            string HD;
            int nombreEcrans;
            double prix = 17.99;


            Console.WriteLine("Netflix calculator" +"\n");
            Console.WriteLine("Voulez vous des ecran Ultra HD ? (OUI/NON) ");
            ultraHD = Console.ReadLine(); 
            
            if (ultraHD != "OUI")
            {
                Console.WriteLine("Voulez vous des ecran HD ?");
                HD = Console.ReadLine();
                if (HD != "OUI")
                {
                    Console.WriteLine("C ombien voulez vous d'ecran ?");
                    nombreEcrans = int.Parse(Console.ReadLine());

                    if (nombreEcrans == 1)
                    {
                        prix = 8.99;
                    }
                    else
                    {
                        if (nombreEcrans == 2)
                        {
                            prix = 11.99;
                                }
                            }
                        
                }
                else
                {
                    prix = 11.99;
                }

            }

            Console.WriteLine("Vous devez payer " + prix + " EURO");
            Console.ReadKey();
        }
    }
}
