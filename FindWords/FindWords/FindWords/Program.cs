using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWords
{
    using System.Collections.ObjectModel;
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet vārdu");
            Console.ReadLine();
        }
         private void BuyItemsList(object sender, RoutedEventArgs e)
        {
            var TodosFromFiles = File.ReadAllLines(@"C:\Users\dzene\source\repos\Riga-coding-school\FindWords\FindWords\words.txt");
            for (int i = 0; i < TodosFromFiles.Length; i++)
            {
                var currentTodo = TodosFromFiles[i];
                
            }
        }
    }
}
