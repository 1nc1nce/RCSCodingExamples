using System;

namespace NumbersGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random diceNumberGenerator = new Random(); //Mainīgais, kurā tiek glabāta skaitļu ģeneratora instance
            int diceValue = diceNumberGenerator.Next(1, 7); //Uzģenerēs skaitļus no 1 līdz 6
            Console.WriteLine("Tavs kauliņa metiens: " + diceValue); 
            int secondDiceValue = diceNumberGenerator.Next(0, 101);
            Console.WriteLine("Tavs otrais kauliņa metiens: " + secondDiceValue);
            Console.ReadLine();
            */

            // paprasīt lietotājam, cik lielu skaitli viņš grib minēt
            Console.WriteLine("Ievadi max skaitli:");
            int maxNumber = int.Parse(Console.ReadLine());
            // uzģenerēt gadījuma skaitli līdz šai robežai
            Random numberGenerator = new Random();
            int numberToGuess = numberGenerator.Next(1, maxNumber);
            //Console.WriteLine("Skaitlis, kas jāatmin = " + numberToGuess);
            // paprasīt lietotājam lai viņš min kāds skaitlis ir izveidots (iegūt ievadi)
            Console.WriteLine("Atmini skaitli robežās no 1 līdz " + maxNumber);
            // cikls: kamēr lietotājs neuzmin:
            // salīdzināt, vai lietotājs ir uzminējis
            // ja ir, tad izbeigt spēli
            // ja nav uzminējis, tad pateikt lietotājam, vai viņa minējums ir lielāks vai mazāks par minamo skaitli 
            while(true)
            {
                int userInput = int.Parse(Console.ReadLine());      
                if(userInput < numberToGuess)
                {
                    Console.WriteLine("Tev jāatmin lielāks skaitlis! Mini vēlreiz!");
                    Console.WriteLine("Skaitlim jābūt robežās no " + userInput + " līdz " + maxNumber + "!");
                }
                else if (userInput > numberToGuess)
                {
                    Console.WriteLine("Tev jāatmin mazāks skaitlis! Mini vēlreiz!");
                    Console.WriteLine("Skaitlim jābūt robežās no 1 līdz " + userInput);
                }
                else
                {
                    break; 
                }
            }
            Console.WriteLine("Apsveicu! Tu atminēji skaitli!");
        }
    }
}
