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
    /// Логика взаимодействия для Postavka.xaml
    /// </summary>
    public partial class Postavka : Page
    {   
        PostavkaTableAdapter postavka = new PostavkaTableAdapter();
        public Postavka()
        {
            InitializeComponent();
            grid_brend.ItemsSource = postavka.GetData();

        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && Col_vo.Text != "" && Date_pastav.Text != "" && postavchic.Text != "")
            {
                postavka.InsertQuery(named.Text,Convert.ToInt32(Col_vo.Text),Date_pastav.Text,Convert.ToInt32(postavchic.Text));
                grid_brend.ItemsSource = postavka.GetData();
                exeptions.Content = "";
            }
            else
            {
                exeptions.Content = "Вы не ввели одно из значений!!";
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && Col_vo.Text != "" && Date_pastav.Text != "" && postavchic.Text != "")
            {
                object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                postavka.UpdateQuery(named.Text, Convert.ToInt32(Col_vo.Text), Date_pastav.Text, Convert.ToInt32(postavchic.Text),Convert.ToInt32(id));
                grid_brend.ItemsSource = postavka.GetData();
            }
            else
            {
                exeptions.Content = "Введите значение";
            }
        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (grid_brend.SelectedItem as DataRowView).Row[0];
            postavka.DeleteQuery(Convert.ToInt32(id));
            grid_brend.ItemsSource = postavka.GetData();
        }

        

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Postavka"].ToString();
                    string valueInColumn2 = rowView["Col_vo"].ToString();
                    string valueInColumn3 = rowView["Date_postavki"].ToString();
                    string valueInColumn4 = rowView["Postavchik"].ToString();


                    named.Text = valueInColumn1;
                    Col_vo.Text = valueInColumn2;
                    Date_pastav.Text = valueInColumn3;
                    postavchic.Text = valueInColumn4;

                }
            }
        }
    }
}
