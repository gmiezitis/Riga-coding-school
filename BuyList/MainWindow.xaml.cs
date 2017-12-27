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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            // izveidojam mainigo
                
          BuyListItemName.Text = "Lūdzu ievadiet pirkumu";
            this.BuyItemsList.Add("āboli");
            this.BuyItemsList.Add("Bumbieri");
       
        //pasakām BuyItemListControl ka jaizmanto m'usu saraksts
        // kā rādamo lietu avots (jāskatās no saraksta, ko rādīt) 
        this.BuyItmesListControl.ItemsSource = this.BuyItemsList;
           
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
    }
}
