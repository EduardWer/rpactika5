using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using Microsoft.Win32;
using Practa5_ints.PracticheskayDataSetTableAdapters;


namespace Practa5_ints
{
    /// <summary>
    /// Логика взаимодействия для Crossovki_list.xaml
    /// </summary>
    
  

public partial class Crossovki_list : Page
    {   

        CrossovkyTableAdapter crossovky = new CrossovkyTableAdapter();

        public Crossovki_list()
        {
            InitializeComponent();
            grid_brend.ItemsSource = crossovky.GetData();
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Crossovky_name"].ToString();
                    string valueInColumn2 = rowView["Crossovky_title"].ToString();
                    string valueInColumn3 = rowView["Crossovki_size"].ToString();
                    string valueInColumn4 = rowView["Postavka_id"].ToString();
                    string valueInColumn5 = rowView["Crossovki_brend"].ToString();



                    named.Text = valueInColumn1;
                    title.Text = valueInColumn2;
                    size.Text = valueInColumn3;
                    postavka.Text = valueInColumn4;
                    brend.Text = valueInColumn5;

                }
            }
        }
        private void jsonReader_Click(object sender, RoutedEventArgs e)
        {

             Class1 class1 = new Class1();
            List<Class1.Class_data> class_Datas = ConvertJsondb.Deseria<List<Class1.Class_data>>();
            foreach (var items in class_Datas)

            {
                var postavka = Convert.ToInt32(items.Postavka_id);
                var brend = Convert.ToInt32(items.Brend);
                crossovky.InsertQuery(items.Name,items.Title,items.Size,postavka,brend);
            }
            grid_brend.ItemsSource = crossovky.GetData();

        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            
            if (named.Text != "" && title.Text != "" && size.Text != "" && postavka.Text != "" && brend.Text != "")
            {
                crossovky.InsertQuery(named.Text, title.Text, size.Text, Convert.ToInt32(postavka.Text),Convert.ToInt32(brend.Text));
                grid_brend.ItemsSource = crossovky.GetData();
                exeptions.Content = "";
            }
            else
            {
                exeptions.Content = "Вы не ввели одно из значений!!";
            }




           
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (named.Text != "" && title.Text != "" && size.Text != "" && postavka.Text != "" && brend.Text != "")
            {
                object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                crossovky.UpdateCrossovky(named.Text, title.Text, size.Text, Convert.ToInt32(postavka.Text), Convert.ToInt32(brend.Text), Convert.ToInt32(id));
                grid_brend.ItemsSource = crossovky.GetData();
            }
            else
            {
                exeptions.Content = "Введите значение";
            }
        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (grid_brend.SelectedItem as DataRowView).Row[0];
            crossovky.DeleteCrossovky(Convert.ToInt32(id));
            grid_brend.ItemsSource = crossovky.GetData();
        }
    }
}
