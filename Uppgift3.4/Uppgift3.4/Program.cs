using System;

namespace Uppgift3._4
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur lång är din låt? Svara med två heltal t.ex om låten är 3 minuter och 50 sekunder så ska du svara 350");
            int heltal = int.Parse(Console.ReadLine());

            {
                if (heltal >= 245 && heltal <= 420)
                    Console.WriteLine("Din låt är inom tidsgränsen :)");

                else if (heltal < 245)
                    Console.WriteLine("Din låt är för kort :(");

                else if (heltal > 420)
                    Console.WriteLine("Din låt är för lång :(");


            }

        }


    }


}