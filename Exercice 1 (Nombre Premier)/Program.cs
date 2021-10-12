using System;

namespace Exercice1
{

    class NbrPremier
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez entrer un nombre:  ");
            int nbr = Convert.ToInt32(Console.ReadLine());

            while (nbr != 0)
            {
                int a = 2;
                while ((nbr % a != 0) && (a < Math.Sqrt(nbr)))
                {
                    a++;
                }
                if (nbr % a == 0)
                    Console.WriteLine(nbr + " n'est pas  un nombre premeier");
                else
                    Console.WriteLine(nbr + " est  un nombre premeier");

                Console.Write("Veuillez entrer un nombre:   ");
                nbr = Convert.ToInt32(Console.ReadLine());

            }
            if (nbr == 0)
            {
                Console.WriteLine("Veuillez entrer un nombre different de 0: ");

            }

            Console.ReadKey();
        }
    }
}
