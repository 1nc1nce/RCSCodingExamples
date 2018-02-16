using System;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList list = new TodoList(); //Izveido jaunu instanci
            while(true)
            {
                //Pievienot jaunu darāmo lietu
                Console.WriteLine("Ievadi darāmo lietu!");
                string todoTask = Console.ReadLine();
                list.AddNewTodo(todoTask);
                //Dzēst visas darāmās lietas
                //Izvadīt visas darāmās lietas uz ekrāna
                list.ShowAllTodos();
            }
        }
    }
}
