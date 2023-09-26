using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_William_Nathan
{
    internal class Metric
    {
        public Metric()
        {
            String? uniteMesureType;
            int uniteMesureNumb;
            double convert;

            Console.WriteLine("\t\tBienvenue sur l'option Metric !");
            Console.WriteLine("Quelle unité de mesure voulez vous transformé? :");
            Console.WriteLine("Mètre [M] | Gram [G] | Litre [L]");

            while (true)
            {
                uniteMesureType = Console.ReadLine();

                if (uniteMesureType == "M" || uniteMesureType == "m" || uniteMesureType == "G" || uniteMesureType == "g" || uniteMesureType == "L" || uniteMesureType == "l")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Veuillez choisir parmi une des option suivante :");
                    Console.WriteLine("Mètre [M] | Gram [G] | Litre [L]");
                }
            }

            Console.Write("Quelle quantité/distance? :");
            uniteMesureNumb = Convert.ToInt32(Console.ReadLine());

            if (uniteMesureType == "M" || uniteMesureType == "m")
            {
                convert = Math.Round(uniteMesureNumb * 3.281, 3);
                Console.WriteLine($"{uniteMesureNumb} mètre(s) est égale à {convert} pied(s).");
            }
            else if (uniteMesureType == "G" || uniteMesureType == "g")
            {
                convert = Math.Round(uniteMesureNumb / 453.6, 3);
                Console.WriteLine($"{uniteMesureNumb} gram(s) est égale à {convert} livre(s).");
            }
            else if (uniteMesureType == "L" || uniteMesureType == "l")
            {
                convert = Math.Round(uniteMesureNumb / 3.785, 3);
                Console.WriteLine($"{uniteMesureNumb} litre(s) est égale à {convert} gallon(s).");
            }
        }
    }
}
