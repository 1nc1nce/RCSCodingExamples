using System;
using System.Collections.Generic; //Sistēmas klasei jābūt definētai, lai varēto lietot List
using System.IO;

namespace ToDoListApp
{
    public class TodoList
    {
        public TodoList() //Konstruktors = kods, ko katru reizi izsauks, kad tiek izveidots objekts. Konstruktors nekas neko neatgriež un vienmēr saucas tāpat kā klase.
        {
            todoEntries = new List<string>(); //Ja šis būtu iekš public void funkcijas, katru reizi palaižot funkciju, pārrakstītos iepriekšējais ieraksts
        }
        List<string> todoEntries;

        public void AddNewTodo(string task)
        {
            //Ja VS nevar atrast klasi, tad jāuzspiež uz klases nosaukuma un piespiež ctrl + .
            Console.WriteLine("Uzdevums pievienots: " + task);
            Console.WriteLine();
            todoEntries.Add(task);
        }
        public void ShowAllTodos()
        {
            //Parādīt paziņojumu, ja nav neviena ieraksta
            if (todoEntries.Count == 0)
            {
                Console.WriteLine("Tavā Todo sarakstā nav neviena ieraksta!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(todoEntries.Count + " ieraksti Todo sarakstā:");

                //skaitītājs = skaitītājs + 1 == skaitītājs += 1 == skaitītājs++
                for (int i = 0; i < todoEntries.Count; i++) //i == index == skaitītājs 
                {
                    //Izvelkam pirmo lietu no saraksta, izmantojot indeksatoru
                    //Programmēšanā skaitīšana sākas no nulles!!! Ja sarakstā ir 11 elementi, tad lai izvilktu pēdējo, janorāda index == 10
                    Console.WriteLine((i + 1) + ". " + todoEntries[i]); // [] - indeksators
                }
                Console.WriteLine();
            }
        }
        public void DeleteTodoItem(int indexOfTodo)
        {
            //Neļaut lietotājam izvilkt ierakstu, kura kārtas nr neeksitē.
            if (indexOfTodo > todoEntries.Count)
            {
                Console.WriteLine("Tāds ieraksts neeksistē!");
                Console.WriteLine();
                return;
            }
            todoEntries.RemoveAt(indexOfTodo - 1);
            Console.WriteLine("Todo ieraksts dzēsts!");
            Console.WriteLine();
        }
        public void SaveToFile()
        {
            for (int i = 0; i < todoEntries.Count; i++)
            {
                // Raksta File --> 'ctrl + . --> automātiski pievieno usingiem System.IO
                File.AppendAllText(@"/Users/admin/Documents/TodoAppSettings/todos.txt",todoEntries[i]+ "\r\n"); // \n == enter (linuxam)  \t == tab
            }
            Console.WriteLine("Todo saraksts saglabāts /Users/admin/Documents/TodoAppSettings/todos.txt");
            Console.WriteLine();
        }
        public void DeleteAllTodos()
        {
            todoEntries.Clear();
            Console.WriteLine("Todo saraksts izdzēsts!");
            Console.WriteLine();
        }
        public void LoadFromFile()
        {
            string[] allLinesFromFile = File.ReadAllLines(@"/Users/admin/Documents/TodoAppSettings/todos.txt");
            foreach (string listEntry in allLinesFromFile)
            {
                todoEntries.Add(listEntry);
            }
        }
        //ielādēt faila saturu - how to read file.readalllines ielādēt 
    }
}
