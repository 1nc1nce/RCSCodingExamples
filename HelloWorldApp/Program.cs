using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izsaucam sevis izveidoto funkciju
            SayHello();
            //Izsaucam savu otro izveidoto funkciju
            SayHelloToUser();
            AskAge();
        }

        static void SayHelloToUser()
        {
            //Palūdzam lietotājam ievadīt savu vārdu
            Console.WriteLine("Please enter your name:");
            //Izveidojam mainīgo, kur glabāt lietotāja ievadīto vērtību
            //usersName ir mainīgais. Ar mazo burtu, lai atšķirtu no funkcijām.
            string usersName;
            //Prasam konsolei ievadīt tekstu un saglabājam tekstu mainīgajā
            usersName = Console.ReadLine();
            Console.WriteLine("Hello, " + usersName + "!");
            Console.ReadLine();
        }

        static void AskAge()
        {
            Console.WriteLine("Please enter your age:");
            string usersAge;
            usersAge = Console.ReadLine();
            usersAge = usersAge + 100;
            //Rezultāts ir teksta string
            Console.WriteLine("Your age is " + usersAge);
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
