using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Practa5_ints.PracticheskayDataSetTableAdapters;
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Practa5_ints.PracticheskayDataSetTableAdapters;
using System.Collections;
using System.IO;

namespace Practa5_ints
{
    /// <summary>
    /// Логика взаимодействия для UserPanel.xaml
    /// </summary>
    public partial class UserPanel : Page
    {
        CrossovkyTableAdapter crossovky = new CrossovkyTableAdapter();
        OrdersTableAdapter orders = new OrdersTableAdapter();
        PolzovateliTableAdapter polzovateli = new PolzovateliTableAdapter();
        public UserPanel()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            var dataRows = crossovky.GetData().Rows;
            foreach (DataRow dataRow in dataRows)
            {
                string name = dataRow["Crossovky_name"].ToString();
                string title = dataRow["Crossovky_title"].ToString();
                string size = dataRow["Crossovki_size"].ToString();
                int price = Convert.ToInt32(dataRow["Crossovki_price"]);
                // Создание экземпляра класса Product и добавление его в список
                products.Add(new Product(name, title, size, price));

            }
            // Установка списка товаров в качестве источника данных для элемента управления
            list__.ItemsSource = products;


        }




        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Получаем выбранную строку в DataGrid
            Product selectedProduct = (Product)list__.SelectedItem;

            if (selectedProduct != null)
            {
                List<Product> products = new List<Product>();
                string name = selectedProduct.name_wer;
                int price = selectedProduct.Price;
                string size = selectedProduct.Size;
                string title = selectedProduct.Description;
                products.Add(new Product(name, title, size, price));
                selected.Items.Add(products[0]);
                selected.Items.Refresh();
                couunt.Content = Convert.ToInt32(couunt.Content) + price;
            }






        }

        private void selected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product selectedProduct = selected.SelectedItem as Product;
            selected.Items.Remove(selectedProduct);
            selected.Items.Refresh();

            Product selecte = (Product)list__.SelectedItem;

            if (selectedProduct != null)
            {


                int price = selectedProduct.Price;

                couunt.Content = Convert.ToInt32(couunt.Content) - price;

            }
        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            List<string> products = new List<string>();
            var dataRows = selected.Items;
            foreach (Product dataRow in dataRows)
            {
                string name = dataRow.name_wer;
                
                
                
                // Создание экземпляра класса Product и добавление его в список
                products.Add(name);

            }
            string names = string.Join(",", products);
            
            orders.InsertQuery(names, selected.Items.Count, Convert.ToInt32(couunt.Content));

            using (StreamWriter file = new StreamWriter("C:\\Users\\Eduard\\Desktop\\chek.txt"))
            {
                file.WriteLine($"\t\t Магазин кросов\n" + $"\t\t Кассовый чек .......\n" + $"\t{names}\n" + $"\tИтог оплате: {couunt.Content}\n" + $"\tОплачено:{couunt.Content}\n");
                MessageBox.Show("Покупка прошла успешно!");
            }






        }



    }



}
 

  

