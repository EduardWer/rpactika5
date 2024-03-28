using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для Brend_list.xaml
    /// </summary>
    public partial class Brend_list : Page
    {
        BrendTableAdapter brends_table = new BrendTableAdapter();
        public Brend_list()
        {
            InitializeComponent();
            grid_brend.ItemsSource = brends_table.GetData();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firm_named.Text != "" && country.Text != "")
                {
                    brends_table.InsertBrend(firm_named.Text, country.Text);
                    grid_brend.ItemsSource = brends_table.GetData();
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
                if (firm_named.Text != "" && country.Text != "")
                {
                    object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                    brends_table.UpdateBrend(Brend_name: firm_named.Text, Country_producer: country.Text, Convert.ToInt32(id));
                    grid_brend.ItemsSource = brends_table.GetData();
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
                brends_table.DeleteBrend(Convert.ToInt32(id));
                grid_brend.ItemsSource = brends_table.GetData();
            }
            catch
            {
                exeptions.Content = "Выберите столбец";
            }
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {

            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Brend_name"].ToString();
                    string valueInColumn2 = rowView["Country_producer"].ToString();
                   

                    firm_named.Text = valueInColumn1;
                    country.Text = valueInColumn2;
                    
                }
            }
        }

        private void import_Click(object sender, RoutedEventArgs e)
        {
            Class3 class3 = new Class3();
            List<Class3.BrendsData> class_Datas = ConvertJsondb.Deseria<List<Class3.BrendsData>>();
            foreach (var items in class_Datas)

            {
                
                brends_table.InsertBrend(items.name,items.country);
            }
            grid_brend.ItemsSource = brends_table.GetData();
        }
    }
}
