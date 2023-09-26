using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_William_Nathan
{
    internal class Quizz
    {
        public Quizz()
        {
            //-1- declaration
            int score;
            string? reponse;

            score = 0;

            //Start 
            Console.WriteLine("\t \t \t Bienvenue au Quizz des Pays du Monde \n");

            Console.WriteLine("etes-vous pret? : ");

            reponse = Console.ReadLine();
            if (reponse == "Oui" || reponse == "oui" || reponse == "yes" || reponse == "y" || reponse == "Y" || reponse == "Yes")
            {
                Console.WriteLine("\nParfait on peut commencer \n");

                //premiere question
                Console.WriteLine("Premiere question: Quelle est le pays avec la plus grande superficie au monde?");

                reponse = Console.ReadLine();
                if (reponse == "Russie" || reponse == "russie")
                {
                    Console.WriteLine("\nBonne Reponse + 1 point \n");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise Reponse");
                }

                //deuxieme question
                Console.WriteLine("Deuxieme question: Quelle est le pays avec la plus grande population au monde?");

                reponse = Console.ReadLine();
                if (reponse == "Chine" || reponse == "chine")
                {
                    Console.WriteLine("\nBonne Reponse + 1point \n");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise Reponse");
                }

                //Troisieme question
                Console.WriteLine("Troisieme question: Quelles est le pays le visite au monde?");

                reponse = Console.ReadLine();
                if (reponse == "France" || reponse == "france")
                {
                    Console.WriteLine("\nBonne Reponse + 1point \n");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise Reponse");
                }
                //4ieme question
                Console.WriteLine("Quatrieme question: Quelle est la capital de Tuvalu?");

                reponse = Console.ReadLine();
                if (reponse == "Funafuti" || reponse == "funafuti")
                {
                    Console.WriteLine("\nBonne Reponse + 1point \n");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise Reponse");
                }
                //5ieme question
                Console.WriteLine("Derniere question: Quelle est le pays avec l'indice de Criminalite le plus elever aus monde?");

                reponse = Console.ReadLine();
                if (reponse == "Venezuela" || reponse == "venuzuela")
                {
                    Console.WriteLine("\nBonne Reponse + 1point \n");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise Reponse");
                }

                //pointage
                Console.WriteLine("Votre score est de " + score + " point!");

                if (score == 0)
                {
                    Console.WriteLine("Va refaire tes cours de geographie\n");
                }
                else if (score == 1)
                {
                    Console.WriteLine("Peut-etre regarder une carte du monde serai une bonne idee\n");
                }
                else if (score == 2)
                {
                    Console.WriteLine("Tu connais la base mais pas incroyable\n");
                }
                else if (score == 3)
                {
                    Console.WriteLine("Tu as une bonne base, bien jouer!\n");
                }
                else if (score == 4)
                {
                    Console.WriteLine("WoW Incroyable Score\n");
                }
                else if (score == 5)
                {
                    Console.WriteLine("Score Parfait Felicitation!\n");
                }
                Console.WriteLine("Press any key to exit the application...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Si vous n'etes pas pret revenez plus tard");
            }
        }
    }
}

