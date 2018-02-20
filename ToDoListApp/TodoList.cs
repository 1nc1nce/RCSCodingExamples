using System;
using System.Collections.Generic; //Sistēmas klasei jābūt definētai, lai varēto lietot List
using System.IO;

namespace ToDoListApp
{
    public class TodoList
    {
        public TodoList() //Konstruktors = kods, ko katru reizi izsauks, kad tiek izveidots objekts. Konstruktors nekas neko neatgriež un vienmēr saucas tāpat kā klase.
        {
            todoEntries = new List<TodoListEntry>(); //Ja šis būtu iekš public void funkcijas, katru reizi palaižot funkciju, pārrakstītos iepriekšējais ieraksts
        }
        List<TodoListEntry> todoEntries; // TodoListEntry <-- klase, objekts
        string pathToTodoListFile = @"/Users/admin/Documents/TodoAppSettings/todos.txt";

        public void AddNewTodo(string task)
        {
            //Ja VS nevar atrast klasi, tad jāuzspiež uz klases nosaukuma un piespiež ctrl + .
            Console.WriteLine("Uzdevums pievienots: " + task);
            Console.WriteLine();
            TodoListEntry usersTodo = new TodoListEntry();
            usersTodo.Name = task;
            todoEntries.Add(usersTodo);
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
                    Console.Write((i + 1) + ". " + todoEntries[i].Name); // [] - indeksators
                    if (todoEntries[i].IsCompleted)
                    {
                        Console.Write(" - Done"); // Console.Write izvada tekstu bez pāriešanas uz jaunu rindu == bez enter
                    }
                    Console.WriteLine();
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
            File.Delete(pathToTodoListFile);
            for (int i = 0; i < todoEntries.Count; i++)
            {
                // Raksta File --> 'ctrl + . --> automātiski pievieno usingiem System.IO
                string nameOfTodo = todoEntries[i].Name;
                File.AppendAllText(pathToTodoListFile,nameOfTodo + "\r\n"); // \n == enter (linuxam)  \t == tab
                bool statusOfTodo = todoEntries[i].IsCompleted;
                File.AppendAllText(pathToTodoListFile, statusOfTodo + "\r\n"); // \n == enter (linuxam)  \t == tab
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
            if (!File.Exists(pathToTodoListFile)) //Pārbaude atgriezīs true, ja fails eksistēs
            {
                return;
            }
            string[] allLinesFromFile = File.ReadAllLines(pathToTodoListFile); //string[] <-- masīvs
            /*
            foreach (string listEntry in allLinesFromFile)
            {
                //1.variantā: listEntry mainīgajā ir ierakstīta viena teksta rinda no faila
                //todoEntries.Add(listEntry);

                //Izveidojam jaunu uzdevumu
                TodoListEntry fileTodo = new TodoListEntry();
                //Uzdevumam uzdodam par nosaukumu teksta rindu, kas nolasīta no faila
                fileTodo.Name = listEntry;
                //Jaunizveidoto uzdevumu pievienojam kopējo uzdevumu sarakstam
                todoEntries.Add(fileTodo);
            }
            */
            for (var index = 0; index < allLinesFromFile.Length; index +=2)
            {
                string listEntry = allLinesFromFile[index];
                TodoListEntry fileTodo = new TodoListEntry();
                fileTodo.Name = listEntry;
                fileTodo.IsCompleted = bool.Parse(allLinesFromFile[index + 1]);
                todoEntries.Add(fileTodo);
            }
        }

        //4) Pievienojam izdarīšanas atzīmi(TaskHasBeenDone) -- līdzīga dzēšanas funckijai
        public void MarkTodoCompleted(int doneTodoIndex)
        {
            if (doneTodoIndex > todoEntries.Count)
            {
                Console.WriteLine("Tāds ieraksts neeksistē!");
                Console.WriteLine();
                return;
            }
            //Variants 1:
            todoEntries[doneTodoIndex].IsCompleted = true;

            /* Variants 2:
            TodoListEntry doneTodo = todoEntries[doneTodoIndex];
            doneTodo.IsCompleted = true;
            */


            //usersTodo.IsCompleted[doneTodoIndex - 1] = true; <-- mans mēģinājums
            Console.WriteLine("Uzdevums izpildīts!");
            Console.WriteLine();
        }

        //5) Izveidojam loģiku, kas parāda tikai neizdarītos uzdevumus
    }
}
