using System;

namespace Uppgift3._3
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många hela timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());

            int svar = timmar * 80 + 950;

            Console.WriteLine("Det kommer att kosta " + svar + " kr");


            
        }
     


    }



}