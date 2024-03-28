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
    /// Логика взаимодействия для Zakazi.xaml
    /// </summary>
    public partial class Zakazi : Page
    {
        ZakaziTableAdapter zakazi = new ZakaziTableAdapter();
        public Zakazi()
        {
            InitializeComponent();
            grid_brend.ItemsSource = zakazi.GetData();
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Crossovki_id"].ToString();
                    string valueInColumn2 = rowView["Orders_id"].ToString();


                    namber.Text = valueInColumn1;
                    zakaz.Text = valueInColumn2;

                }
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (namber.Text != "" && zakaz.Text != "")
                {
                    zakazi.InsertQuery(Convert.ToInt32(namber.Text),Convert.ToInt32(zakaz.Text));
                    grid_brend.ItemsSource = zakazi.GetData();
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
                if (namber.Text != "" && zakaz.Text != "")
                {
                    object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                    zakazi.UpdateQuery(Convert.ToInt32(namber.Text), Convert.ToInt32(zakaz.Text), Convert.ToInt32(id));
                    grid_brend.ItemsSource = zakazi.GetData();
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
                zakazi.DeleteQuery(Convert.ToInt32(id));
                grid_brend.ItemsSource = zakazi.GetData();
            }
            catch
            {
                exeptions.Content = "Выберите столбец";
            }
        }
    }
}
