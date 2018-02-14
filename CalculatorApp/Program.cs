using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateCircleArea();
            CountTwoNumbers();
        }
        // void = tukšums, funkcija izpildoties neatgriež neko
        /** static void CalculateCircleArea()
        {
            // Izveidojam mainīgo, kur glabāt rādiusu
            int radius;
            // Izveidojam mainīgo, kur glabāt rezultātu
            double result;
            // Piešķiram rādiusa mainīgajam vērtību
            radius = GetNumberFromUser("Lūdzu, ievadi rādiusu");
            // Veicam aprēķināšanas operāciju
            result = radius * radius * 3.14;
            // Parādām rezultātu lietotājam
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
        } **/

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
                parsedNumber = GetNumberFromUser(msg); // Funkcija izsauc pati sevi
            }
            else
            {
                Console.WriteLine("Brīnišķīgi ievadīts skaitlis");
            }
            //Atgriež saparsēto skaitli uz ārpusi - funkcijai, kas to izsauc
            return parsedNumber;
        }

        static void CountTwoNumbers()
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
    }
}
