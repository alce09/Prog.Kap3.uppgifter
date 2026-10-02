using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            Console.WriteLine("Svara j för ja & n för nej");
            string gymnasie = Console.ReadLine();


            Console.WriteLine("Hur gammal är du");
            int ålder = int.Parse(Console.ReadLine());

            {
                if (ålder <= 22 && gymnasie == "j")
                    Console.WriteLine("Vi vill gärna anställa dig:)");

                else
                    Console.WriteLine("Vi letar tyvärr efter annan personal just nu:(");







            }
                



        }


    }


}
