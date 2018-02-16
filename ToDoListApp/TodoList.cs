using System;
using System.Collections.Generic; //Sistēmas klasei jābūt definētai, lai varēto lietot List
            
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
            //Ja VS nevar atrast klasi, tad jāuzspiež uz klases nosaukuma un piespiež ctrl+.
            Console.WriteLine("Uzdevums pievienots: " + task);
            todoEntries.Add(task);
        }
        public void ShowAllTodos()
        {
            //skaitītājs = skaitītājs + 1 == skaitītājs += 1 == skaitītājs++
            for (int i = 0; i < todoEntries.Count; i++) //i == index == skaitītājs 
            {
                //Izvelkam pirmo lietu no saraksta, izmantojot indeksatoru
                //Programmēšanā skaitīšana sākas no nulles
                Console.WriteLine("Your todo list entry: " + todoEntries[counter]); // [] - indeksators
            }

        }
    }
}
