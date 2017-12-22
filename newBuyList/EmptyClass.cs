using System;
using System.Collections.Generic;
using System.IO;
namespace newBuyList
{
    public class TodoListManager
    {
        public TodoListManager()
        {

        }

        public TodoListManager(string path)
        {
            LoadList(path);
        }

        public string NameOfToDoList;

        private List<string> todoTasks = new List<string>();
        public void AddNewTask(string task)
        {
            todoTasks.Add(task);
        }

        public void DeleteTodo()
        {
            ShowTodos();
            Console.WriteLine("enter number of todo to delte:");
            int input = int.Parse(Console.ReadLine());
            int indexInList = input - 1;
            if (todoTasks.Count > indexInList)
            {
                todoTasks.RemoveAt(indexInList);
            }
        }

        public void ShowTodos()
        {
            Console.WriteLine(NameOfToDoList + " has this to do: ");

            for (int i = 0; i < todoTasks.Count; i++)
            {
                if (todoTasks[i] == "")
                {
                    Console.WriteLine("--[NO ENTRY HERE]--");
                    continue;
                }
                Console.WriteLine((i + 1) + ". " + todoTasks[i]);
            }

        }

        public void SaveToFile()
        {
            File.WriteAllLines("/Users/oscar/Desktop/riga coding school/so.txt ", this.todoTasks);
         
        }

        public void LoadList()
        {

        }

        public void LoadList(string path)
        {

        }
    }
}
