using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Lietotne skaita no 1 līdz 100
                Ja skaitlis dalās ar 3, lietotne izvada uz ekrāna "Fizz"
                Ja skaitlis dalās ar 5, lietotne izvada uz ekrāna "Buzz"
                Ja skaitlis dalās ar gan ar 3, gan ar 5, lietotne izvada uz ekrāna "FizzBuzz"
                Ja skaitlis nedalās ne ar 3, ne ar 5, lieotne izvada uz ekrāna pašu skaitli
             Bonuspunkti:
                1. Bonuspunkts: 
                Lietotne ļauj lietotājam ievadīt augšējo robežu (līdz cik skaitļiem jāizvada )
                2. Bonuspunkts:
                Lietotne nenocrasho, ja lietotājs pieprasa izvadīt FizzBuzz līdz vienam kvadriljonam (1 000 000 000 000 000)
            */

            Console.WriteLine("Ievadi skaitli!");
            ulong usersInput = ulong.Parse(Console.ReadLine());
            for (ulong number = 1; number <= usersInput; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
