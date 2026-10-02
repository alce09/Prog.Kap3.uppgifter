using System;

namespace Program
{
    class Program
    {
        static void Main (string[]args)
        {

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            {
                if (ålder >= 16 && ålder <= 19)
                    Console.WriteLine("Du får delta i tävlingen!");

                else
                    Console.WriteLine("Du får tyvärr inte delta i tävlingen");



            }


        }


    }


}