using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuyList
{
    using System.Collections.ObjectModel;
    using System.IO;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
        public event StartupEventHandler Startup;
        



        public MainWindow()
        {
            InitializeComponent();
            // izveidojam mainigo
            var allItemsFromFile = System.IO.File.ReadAllLines(@"D:/mans_fails.txt");
                
          
            this.BuyItemsList.Add("āboli");
            this.BuyItemsList.Add("Bumbieri");
       
           //pasakām BuyItemListControl ka jaizmanto m'usu saraksts
            // kā rādamo lietu avots (jāskatās no saraksta, ko rādīt) 
            this.BuyItmesListControl.ItemsSource = this.BuyItemsList;
            foreach 
            {BuyItemsList.Add(someItemsFromFile);}
            
        
           
        }

        private void AddListItemButton_Click(object sender, RoutedEventArgs e)
        {
            //izvelkam vertibu no teksta lauka 
            string input = this.BuyListItemName.Text;
            //nodzesam vertibu teksta lauka
            this.BuyListItemName.Text = "";

            //ierakstam ieguto vertibu teksta blo-ka
            this.BuyItemsList.Add(input);
        }
        // izveidoj'am pogu , kas ielādē saglabātos datos no mapes
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(@"D:/mans_fails.txt", BuyItemsList);
        }   
        //funkcijas kas nolasa datus
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var TodosFromFiles = File.ReadAllLines(@"D:/mans_fails.txt");
            for (int i = 0; i < TodosFromFiles.Length; i++)
            {
                var currentTodo = TodosFromFiles[i];
                    BuyItemsList.Add(currentTodo);
            }
            
        }
        // funkcija lai varētu iezīmēt multiple lietas 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selectedItems = BuyItmesListControl.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)

           
            {
                var selectedItem = selectedItems[i] as string;
                BuyItemsList.Remove(selectedItem as string);
            }
            
        }
        
    }
}
