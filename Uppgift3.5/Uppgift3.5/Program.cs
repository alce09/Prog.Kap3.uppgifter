using System;

namespace Uppgift3._5
{
    class Program
    {
        static void Main (string[]args)
        {
          
            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("addition");
            Console.WriteLine("subtraktion");
            Console.WriteLine("multiplikation");
            Console.WriteLine("division");

            string kategori = Console.ReadLine().ToLower();
            int rättsvar = 0;

            Console.WriteLine("Skriv in ett tal!");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ett till tal!");
            int tal2 = int.Parse(Console.ReadLine());


            switch (kategori)
            {
                case "addition":
                    Console.WriteLine(tal1+ " + " +tal2);
                    rättsvar = (tal1 + tal2);
                    break;

                case "subtraktion":
                    Console.WriteLine(tal1+ " - " +tal2);
                    rättsvar = (tal1 - tal2);
                    break;

                case "multiplikation":
                    Console.WriteLine(tal1+ " * " +tal2);
                    rättsvar = (tal1 * tal2);
                    break;

                case "division":
                    Console.WriteLine(tal1+ "/" +tal2);
                    rättsvar = (tal1 / tal2);
                    break;



            }

            int svar = int.Parse(Console.ReadLine());

            {
                if (svar == rättsvar)
                    Console.WriteLine("Du svarade rätt!");

                else
                    Console.WriteLine("Du svarade fel :(");
            }


        }



    }



}