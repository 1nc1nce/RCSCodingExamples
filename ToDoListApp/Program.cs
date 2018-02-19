using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList list = new TodoList(); //Izveido jaunu instanci
            list.LoadFromFile();
            while(true)
            {
                Console.WriteLine("Lūdzu, izvēlies TodoList darbību!");
                Console.WriteLine("a - Pievienot!");
                Console.WriteLine("b - Parādīt visu!");
                Console.WriteLine("c - Dzēst Todo ierakstu!");
                Console.WriteLine("d - Dzēst visus ierakstus!");
                Console.WriteLine("f - Saglabāt Todo sarakstu failā!");
                Console.WriteLine("g - Ielādēt Todo sarakstu no faila!");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "a":
                        //Pievienot jaunu darāmo lietu
                        Console.WriteLine("Ievadi darāmo lietu!");
                        string todoTask = Console.ReadLine();
                        list.AddNewTodo(todoTask);
                        break;
                    case "b":
                        //Izvadīt visas darāmās lietas uz ekrāna
                        list.ShowAllTodos();
                        break;
                    case "c":
                        //Dzēst konkrētu darāmo lietu
                        Console.WriteLine("Ievadi lietu, ko izdzēst!");
                        list.ShowAllTodos();
                        int indexOfTodo = int.Parse(Console.ReadLine());
                        list.DeleteTodoItem(indexOfTodo);
                        break;
                    case "d":
                        //Dzēst visas darāmās lietas
                        list.DeleteAllTodos();
                        break;
                        //Lai orientētos kodā un atrastu konkrētu funkciju, uzkliko uz funkcijas + F12
                    case "f":
                        //Saglabāt Todo sarakstu failā
                        list.SaveToFile();
                        break;
                    case "g":
                        //Ielādēt no faila
                        list.LoadFromFile();
                        break;
                }
            }
        }
    }
}
