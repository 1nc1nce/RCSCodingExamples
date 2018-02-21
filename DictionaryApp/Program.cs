using System;
using System.IO;
using System.Linq;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Izveidojam aplikāciju, kas pieprasa lietotājam ievadīt kādu vārdu, un vārdnīcā sameklē visus vārdus, 
            // ko iespējams saveidot no ievadītā vārda burtiem. (vārdnīcas fails pieejams https://github.com/dwyl/english-words un arī citās vietās)

            // palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
            // ielādējam visus vārdus no vārdnīcas faila
            // izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
            // izveidojam mainīgo, kurā piefiksēsim to, vai vārdā ir kādi nevajadzīgi burti 
            // izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
            // pārbaudam, vai burts atrodas vārdnīcas vārdā
            // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
            // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
            // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
            // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
            // kad vārdu apstrāde pa burtiem beigusies,
            // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
            // ja nav, tad izvadām vārdu uz ekrāna

            // palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
            Console.WriteLine("Ievadi burtus, no kuriem izveidot vārdus!");
            string usersInput = Console.ReadLine();
            // ielādējam visus vārdus no vārdnīcas faila
            string pathToDictionaryFile = @"/Users/admin/Documents/DictionaryApp/words.txt";
            string[] allLinesFromFile = File.ReadAllLines(pathToDictionaryFile);
            // izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
            foreach (var dictionaryEntry in allLinesFromFile)
            {
                // izveidojam mainīgo, kurā piefiksēsim to, vai vārdā no vārdnīcas ir atrasti kādi nevajadzīgi burti 
                bool hasInvalidLetterBeenFound = false;
                // izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
                for (int i = 0; i < usersInput.Length; i++) // foreach (char currentSymbol in usersInput)
                {
                    char currentSymbol = usersInput[i];
                    // pārbaudam, vai burts atrodas vārdnīcas vārdā
                    if (!dictionaryEntry.Contains(currentSymbol))
                    {
                        // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts, t.i. vārdnīcas vārdā nav lietotāja norādītie burti
                        hasInvalidLetterBeenFound = true;
                    }
                }
                // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
                foreach (char symbol in dictionaryEntry)
                {
                    // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
                    if (!usersInput.Contains(symbol))
                    // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                    {
                        hasInvalidLetterBeenFound = true;
                    }
                }
                // kad vārdu apstrāde pa burtiem beigusies,
                // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
                if (hasInvalidLetterBeenFound == false)
                {
                    // ja nav, tad izvadām vārdu uz ekrāna
                    Console.WriteLine(dictionaryEntry);
                }
            }
        }
    }
}
