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
    /// Логика взаимодействия для Sclad.xaml
    /// </summary>
    public partial class Sclad : Page
    {
        ScladTableAdapter sclad = new ScladTableAdapter();  
        public Sclad()
        {
            InitializeComponent();
            grid_brend.ItemsSource = sclad.GetData();
        }

        private void grid_brend_Selected(object sender, RoutedEventArgs e)
        {
            if (grid_brend.SelectedItems.Count > 0)
            {
                DataRowView rowView = grid_brend.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueInColumn1 = rowView["Col_vo"].ToString();
                    string valueInColumn2 = rowView["Postavka_id"].ToString();
                    string valueInColumn3 = rowView["Crossovki_id"].ToString();


                    Col_vo.Text = valueInColumn1;
                    postavka_id.Text = valueInColumn2;
                    Crossovki_id.Text = valueInColumn3;

                }
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Col_vo.Text != "" && postavka_id.Text != "" && Crossovki_id.Text != "")
                {
                    sclad.InsertQuery(Convert.ToInt32(Col_vo.Text), Convert.ToInt32(postavka_id.Text), Convert.ToInt32(Crossovki_id.Text));
                    grid_brend.ItemsSource = sclad.GetData();
                    exeptions.Content = "";
                }
                else
                {
                    exeptions.Content = "Введите значение";
                }
            }
            catch
            {
                exeptions.Content = "Вы что то ввели не правильно";
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (Col_vo.Text != "" && postavka_id.Text != "" && Crossovki_id.Text !="")
            {
                object id = (grid_brend.SelectedItem as DataRowView).Row[0];
                sclad.UpdateQuery(Convert.ToInt32(Col_vo.Text),Convert.ToInt32(postavka_id.Text),Convert.ToInt32(Crossovki_id.Text), Convert.ToInt32(id));
                grid_brend.ItemsSource = sclad.GetData();
            }
            else
            {
                exeptions.Content = "Введите значение";
                }
            }
            catch
            {
                exeptions.Content = "Вы что то ввели не правильно";
            }
        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (grid_brend.SelectedItem as DataRowView).Row[0];
            sclad.DeleteQuery(Convert.ToInt32(id));
            grid_brend.ItemsSource = sclad.GetData();
        }
    }
}
