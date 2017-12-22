using System;
using System.Collections.Generic;
using System.IO;


   

namespace newBuyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TodoListManager> managers = new List<TodoListManager>();


            while (true)
            {
                Console.WriteLine("Please choose option:");
                Console.WriteLine("1 - add new todo list");
                Console.WriteLine("2 - remove todo list");
                Console.WriteLine("3 - manipulate todo list");
                Console.WriteLine("0 - quit");
                int input = int.Parse(Console.ReadLine());


                switch (input)
                {
                    case 1:
                        Console.WriteLine("What will be the name?");
                        string nameInput = Console.ReadLine();
                        TodoListManager manager;
                        manager = new TodoListManager();

                        manager.NameOfToDoList = nameInput;

                        managers.Add(manager);
                        break;
                    case 2:
                        break;
                    case 3:
                        for (int i = 0; i < managers.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + managers[i].NameOfToDoList);
                        }
                        int choiceInput = int.Parse(Console.ReadLine());
                        TodoListManager selectedManager = managers[choiceInput - 1];
                        ShowUserOptions(selectedManager);
                        break;
                    case 0:
                        return;
                }

            }

            Console.ReadKey();
        }

        public static void ShowUserOptions(TodoListManager manager)
        {
            while (true)
            {
                Console.WriteLine("please choose action");
                Console.WriteLine("1 - add a task");
                Console.WriteLine("2 - show added tasks");
                Console.WriteLine("3 - delete a task");
                Console.WriteLine("4 - save to file");
                Console.WriteLine("q - quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("please enter task");
                        string inputTask = Console.ReadLine();
                        manager.AddNewTask(inputTask);
                        break;
                    case "2":
                        manager.ShowTodos();
                        break;
                    case "3":
                        manager.DeleteTodo();
                        break;
                    case "q":
                        Console.WriteLine("you chose to exit");
                        return;
                        break;
                    case "4":
                        manager.SaveToFile();
                        break;
                }
               

            }

        }
    }
}
