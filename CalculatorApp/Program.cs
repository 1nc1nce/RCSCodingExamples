using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "0";
            while(true)
            {
                Console.WriteLine("Please choose action:");
                Console.WriteLine("a - Calculate circle area");
                Console.WriteLine("b - Count two numbers together");
                Console.WriteLine("c - Does the number divide?");
                Console.WriteLine("x - Quit App?");
                userInput = Console.ReadLine();
                if (userInput == "a")
                {
                    CalculateCircleArea();
                }
                else if (userInput == "b") //Var būt vairāk kā viens 'else if'
                {
                    CountTwoNumbers();
                }
                else if (userInput == "c")
                {
                    DivideNumber();
                }
                else if (userInput == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, did not understand!");
                }   
            }
            Console.ReadLine();
        }
        // void = tukšums, funkcija izpildoties neatgriež neko
        static void CalculateCircleArea()
        {
            // Izveidojam mainīgo, kur glabāt rādiusu
            double radius;
            // Izveidojam mainīgo, kur glabāt rezultātu
            double result;
            // Piešķiram rādiusa mainīgajam vērtību
            radius = GetNumberFromUser("Lūdzu, ievadi rādiusu");
            // Veicam aprēķināšanas operāciju
            result = radius * radius * 3.14;
            // Parādām rezultātu lietotājam
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
        }

        //Funkcija tiek izsaukta ar teksta mainīgo. "string msg" = arguments
        // static int = funkcija atgriež apaļu skaitli
        static double GetNumberFromUser(string msg)
        {
            //Izvadām funkcijai iedoto paziņojumu
            Console.WriteLine(msg);
            // Nolasām lietotāja ievadi no ekrāna un ierkastam teksta mainīgajā
            string textInput = Console.ReadLine();
            // Izveidojam manīgo, kur glabāt apaļu skaitli
            double parsedNumber;
            // Pārveidojam tekstu par skaitli un ierakstām mainīgajā
            //parsedNumber = double.Parse(textInput);
            // TryParse: ja izdodas saparsēt, atgriež True, ja neizdodas - False; out - atgriež rezultātu, var atgriezt vairāk vērtību
            bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
            //if izpildīsies, ja parseWasSuccess=True
            if (parseWasSuccess == false)
            {
                // "\" eskeipo nākamo simbolu
                Console.WriteLine("Slikti ievadīts skaitlis \"" + textInput + "\"");
                Console.WriteLine("Ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg); // Funkcija izsauc pati sevi==atgriežas uz funkcijas sākumu
            }
            else
            {
                Console.WriteLine("Brīnišķīgi ievadīts skaitlis");
            }
            //Atgriež saparsēto skaitli uz ārpusi - funkcijai, kas to izsauc. Jāizmanto pie jebkuras funkcijas, kas nav void.
            return parsedNumber;
        }

        static void CountTwoNumbers() // Funkcija neprasa argumentus, jo ()
        {
            //Definē mainīgos, kur glabāt lietotāja ievadītos skaitļus un rezultātu
            double number1;
            number1 = GetNumberFromUser("Lūdzu, ievadi pirmo skaitli!");
            double number2;
            number2 = GetNumberFromUser("Lūdzu, ievadi otro skaitli!");
            double result;
            result = number1 + number2;
            Console.WriteLine("Summa: " + result);
            Console.ReadLine();
        }

        static void DivideNumber()
        {
            double number1 = GetNumberFromUser("Lūdzu, ievadi dalāmo!");
            double number2 = GetNumberFromUser("Lūdzu, ievadi dalītāju!");
            double modulis = number1 % number2; //% atgriež atlikumu no divu skaitļu dalīšanas; šo f-ju izmanto, lai noteiktu, vai skaitlis ir pāra vai nepāra
            if(modulis == 0)
            {
                Console.WriteLine("Šie skaitļi dalās!");
            }
            else
            {
                Console.WriteLine("Šie skaitļi nedalās!");
            }
            Console.ReadLine();
        }
    }
}
