namespace Exercice_William_Nathan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? choix;

            Console.WriteLine("\t\tBienvenue à l'exercice de William & Nathan !");

            Console.WriteLine("Quelle option voulez vous tester? :");
            Console.WriteLine("Quizz [Q] | Monnaie [Mo] | Metric [Me]");
            Console.WriteLine("Ou tapez «EXIT» pour quitter le programme.");

            while (true)
            {
                choix = Console.ReadLine();

                if (choix == "Q" || choix == "q")
                {
                    new Quizz();
                    break;
                }
                else if (choix == "Mo" || choix == "mo")
                {
                    new Monnaie();
                    break;
                }
                else if (choix == "Me" || choix == "me")
                {
                    new Metric();
                    break;
                }
                else if (choix == "EXIT" || choix == "exit")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Veuillez choisir parmi une des option suivante :");
                    Console.WriteLine("Quizz [Q] | Monnaie [Mo] | Metric [Me]");
                }
            }
        }
    }
}