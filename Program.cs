using System;
using System.Collections.Generic;

namespace Unity_sem
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Title = "To-Do Manager";
          List<string> toDoList = new List<string>();   // List of tasks

          bool keep = true;
          while (keep)
          {  
            Console.Clear();
            Menu();

            char decision = Console.ReadKey().KeyChar;

             switch(decision)
             {
                case '1':               // View tasks
                  Console.Clear();

                  if (toDoList.Count == 0)
                  {
                   Console.WriteLine("Žádné úkoly k zobrazení");
                   Console.ReadKey();
                   break;
                  }

                  for (int i = 0; i < toDoList.Count; i++)      // Write every task from list and number them
                  {
                     Console.Write("Úkol číslo {0}: ", i + 1);
                     Console.WriteLine(toDoList[i]);
                  }
          
                  Console.ReadKey();
                  Console.Clear();
                  break;

               case '2':                       // Add tasks
                  Console.Clear();
                  Console.Write("Přidat úkol: ");
                  toDoList.Add(Console.ReadLine());
                  Console.Clear();
                  break;   

               case '3':                      // Delete tasks
                  Console.Clear(); 

                  if (toDoList.Count == 0)
                  {
                    Console.WriteLine("Žádné úkoly ke smazání");
                    Console.ReadKey();
                    break;
                  }

                  for (int i = 0; i < toDoList.Count; i++)    // Show tasks that can be deleted
                  {
                     Console.Write("Úkol číslo {0}: ", i + 1);
                     Console.WriteLine(toDoList[i]);
                  }
                  Console.WriteLine("========================");

                  Console.WriteLine("Kolikátý úkol chcete odstranit? (0 pro odstranění všech úkolů)");

                  bool exKeep = true;      // User choice in task deleting
                  while(exKeep)
                  {
                     try
                     {
                       int removal = int.Parse(Console.ReadLine());
                       if (removal == 0)
                       {
                         toDoList.Clear();
                         break;
                       }
                       removal -= 1;
                       toDoList.RemoveAt(removal);
                       exKeep = false;
                    }
                     catch (Exception ex)
                     {
                       Console.WriteLine("Neplatné pořadí");
                     }
                  }      

                Console.Clear();
                break;

                default:
                   Console.Clear();
                   break;
            
             }
           }
        Console.ReadKey();
        }
        static void Menu()                         // UI
        {
          Console.WriteLine("TODO");
          Console.WriteLine("\nVyber:");
          Console.WriteLine("\n1) Vypsat úkoly");
          Console.WriteLine("2) Přidat úkol");
          Console.WriteLine("3) Odebrat úkol");
        }
    }
}
