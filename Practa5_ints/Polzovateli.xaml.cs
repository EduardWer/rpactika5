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
    /// Логика взаимодействия для Polzovateli.xaml
    /// </summary>
    public partial class Polzovateli : Page
    {   
        PolzovateliTableAdapter polzovateli = new PolzovateliTableAdapter();
        public Polzovateli()
        {
            InitializeComponent();
            grid_brend.ItemsSource = polzovateli.GetData();
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Polzovateli_name"].ToString();
                    string valueInColumn2 = rowView["Polzovateli_secondname"].ToString();
                    string valueInColumn3 = rowView["Polzovateli_middlename"].ToString();
                    string valueInColumn4 = rowView["Rol_id"].ToString();


                    named.Text = valueInColumn1;
                    second_name.Text = valueInColumn2;
                    middle_name.Text=valueInColumn3;
                    rol_id.Text = valueInColumn4;
                }
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && second_name.Text != "" && middle_name.Text != "" && rol_id.Text != "")
            {
                try { 
                    var id = Convert.ToInt32(rol_id.Text);
                polzovateli.InsertQuery(named.Text, second_name.Text, middle_name.Text, id);
                grid_brend.ItemsSource = polzovateli.GetData();
                exeptions.Content = "";
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    exeptions.Content = "Такова id не существует!!!!";
                }
                
            }
            else
            {
                exeptions.Content = "Вы не ввели одно из значений!!";
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && second_name.Text != "" && middle_name.Text != "" && rol_id.Text != "")
            {
                object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                polzovateli.UpdateQuery(named.Text,second_name.Text,middle_name.Text,Convert.ToInt32(rol_id.Text),Convert.ToInt32(id));
                grid_brend.ItemsSource = polzovateli.GetData();
            }
            else
            {
                exeptions.Content = "Введите значение";
            }
        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (grid_brend.SelectedItem as DataRowView).Row[0];
            polzovateli.DeleteQuery(Convert.ToInt32(id));
            grid_brend.ItemsSource = polzovateli.GetData();
        }
    }
}
