using System;
using System.Collections.Generic;
using System.Data;
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
namespace Practa5_ints
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {   
        OrdersTableAdapter orders = new OrdersTableAdapter();
        public Orders()
        {
            InitializeComponent();
            grid_brend.ItemsSource = orders.GetData();
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Cross_named"].ToString();
              
                    string valueInColumn4 = rowView["Col_vo"].ToString();
                    string valueInColumn5 = rowView["Full_cost"].ToString();



                    Cross_nameber.Text = valueInColumn1;
                    
                    colvo.Text = valueInColumn4;
                    coust.Text = valueInColumn5;
                }
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Cross_nameber.Text != "" &&  colvo.Text != "" && coust.Text !="")
                {
                    orders.InsertQuery(Cross_nameber.Text, Convert.ToInt32(colvo.Text), Convert.ToInt32(coust.Text));
                    grid_brend.ItemsSource = orders.GetData();
                    exeptions.Content = "";
                }
                else
                {
                    exeptions.Content = "Вы не ввели одно из значений!!";
                }
            }
            catch
            {
                exeptions.Content = "Что то введено не правильно";
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Cross_nameber.Text != "" &&  colvo.Text != "" && coust.Text != "")
                {
                    object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                    orders.UpdateQuery(Cross_nameber.Text,  Convert.ToInt32(colvo.Text), Convert.ToInt32(coust.Text), Convert.ToInt32(id));
                    grid_brend.ItemsSource = orders.GetData();
                }
                else
                {
                    exeptions.Content = "Введите значение";
                }
            }
            catch
            {
                exeptions.Content = "Что то введено не правильно";
            }
        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                orders.DeleteQuery(Convert.ToInt32(id));
                grid_brend.ItemsSource = orders.GetData();
            }
            catch
            {
                exeptions.Content = "Выберите столбец";
            }
        }
    }
}
