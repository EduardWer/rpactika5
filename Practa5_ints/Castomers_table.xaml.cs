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
    /// Логика взаимодействия для Castomers_table.xaml
    /// </summary>
    public partial class Castomers_table : Page
    {
        CastomerTableAdapter castomer = new CastomerTableAdapter();
        public Castomers_table()
        {
            InitializeComponent();
            castomer_grid.ItemsSource = castomer.GetData();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "" && second_name.Text != "" && middle_name.Text != "" && adress.Text != "" && phone.Text != "" && email.Text != "")
            {
                try
                {
                    castomer.InsertCastomer(name.Text, second_name.Text, middle_name.Text, adress.Text, Convert.ToInt32(phone.Text), email.Text);
                    castomer_grid.ItemsSource = castomer.GetData();
                    exeptions.Content = "";
                }
                catch
                {
                    exeptions.Content = "Что то введено не правильно";
                }
            }

            else
            {
                exeptions.Content = "Вы не ввели одно из значений!!";
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "" && second_name.Text != "" && middle_name.Text != "" && adress.Text != "" && phone.Text != "" && email.Text != "")
            {
                object id = (castomer_grid.SelectedItem as DataRowView).Row[0];
                castomer.UpdateCastomer(name.Text, second_name.Text, middle_name.Text, adress.Text, Convert.ToInt32(phone.Text), email.Text, Convert.ToInt32(id));
                castomer_grid.ItemsSource = castomer.GetData();
            }
            else
            {
                exeptions.Content = "Введите значение";
            }
        }

        private void Delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (castomer_grid.SelectedItem as DataRowView).Row[0];
            castomer.DeleteCastomer(Convert.ToInt32(id));
            castomer_grid.ItemsSource = castomer.GetData();
        }



        private void castomer_grid_Selected(object sender, RoutedEventArgs e)
        {
            if (castomer_grid.SelectedItems.Count > 0)
            {
                DataRowView rowView = castomer_grid.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Castomer_name"].ToString();
                    string valueInColumn2 = rowView["Castomer_secomname"].ToString();
                    string valueInColumn3 = rowView["Castomer_middle_name"].ToString();
                    string valueInColumn4 = rowView["Castomer_address"].ToString();
                    string valueInColumn5 = rowView["Castomer_phone"].ToString();
                    string valueInColumn6 = rowView["Castomer_email"].ToString();

                    name.Text = valueInColumn1;
                    second_name.Text = valueInColumn2;
                    middle_name.Text = valueInColumn3;
                    adress.Text = valueInColumn4;
                    phone.Text = valueInColumn5;
                    email.Text = valueInColumn6;
                }
            }
        
        }
    }
}
