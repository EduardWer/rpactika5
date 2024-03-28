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
    /// Логика взаимодействия для postavchiki.xaml
    /// </summary>
    public partial class postavchiki : Page
    {
        PostavchikTableAdapter postavchik = new PostavchikTableAdapter();
        public postavchiki()
        {
            InitializeComponent();
            grid_brend.ItemsSource = postavchik.GetData() ;
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Postavchik_name"].ToString();
                    string valueInColumn2 = rowView["Postavchik_address"].ToString();
                    string valueInColumn3 = rowView["Postavchik_phone"].ToString();
                    string valueInColumn4 = rowView["Postavchik_email"].ToString();
                    


                    named.Text = valueInColumn1;
                    adress.Text = valueInColumn2;
                    phone.Text = valueInColumn3;
                    email.Text = valueInColumn4;


                }
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && adress.Text != "" && phone.Text != "" && email.Text != "")
            {
                postavchik.InsertQuery(named.Text, adress.Text, Convert.ToInt32(phone.Text), email.Text);
                grid_brend.ItemsSource = postavchik.GetData();
                exeptions.Content = "";
            }
            else
            {
                exeptions.Content = "Вы не ввели одно из значений!!";
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && adress.Text != "" && phone.Text != "" && email.Text != "")
            {
                object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                postavchik.UpdateQuery(named.Text,adress.Text,Convert.ToInt32(phone.Text),email.Text, Convert.ToInt32(id));
                grid_brend.ItemsSource = postavchik.GetData();
            }
            else
            {
                exeptions.Content = "Введите значение";
            }
        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (grid_brend.SelectedItem as DataRowView).Row[0];
            postavchik.DeleteQuery(Convert.ToInt32(id));
            grid_brend.ItemsSource = postavchik.GetData();
        }
    }
}
