using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
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
using System.Xml.Linq;
using Practa5_ints.PracticheskayDataSetTableAdapters;
namespace Practa5_ints
{
    /// <summary>
    /// Логика взаимодействия для AdminListxaml.xaml
    /// </summary>
    public partial class AdminListxaml : Page
    {   
        RoliTableAdapter rols = new RoliTableAdapter();
        public AdminListxaml()
        {
            InitializeComponent();
            grid_roli.ItemsSource = rols.GetData();
        }

        

        private void create_Click(object sender, RoutedEventArgs e)
        {
            var password = new_password.Text;
            var login = new_login.Text;
            var rol = new_rol.Text;
            if (password != "" && login != "")
            {
                if (rol == "admin" || rol == "user")
                {
                    rols.InsertAdmin(rol, login, password);
                    grid_roli.ItemsSource = rols.GetData();
                    exeption.Content = "";
                }
                else
                {
                    exeption.Content = "Такой роли не существует!!";
                }
            }
            else
            {
                exeption.Content = "Вы не ввели данные!!";
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            var password = new_password.Text;
            var login = new_login.Text;
            var rol = new_rol.Text;
            object id = (grid_roli.SelectedItem as DataRowView).Row[0];
            if (password != "" && login != "")
            {
                if (rol == "admin" || rol == "user")
                {
                    rols.UpdateAdmin(Roli_name: rol, Roli_login: login, Roli_password: password, Original_Roli_id: Convert.ToInt32(id));
                    grid_roli.ItemsSource = rols.GetData();
                }
                else
                {
                    exeption.Content = "Не верная роль!!!";
                }
            }
            else
            {
                exeption.Content = "Вы не ввели данные";
            }

        }

        private void delate_Click(object sender, RoutedEventArgs e)
        {
            object id = (grid_roli.SelectedItem as DataRowView).Row[0];
            rols.DeleteAdmin(Convert.ToInt32(id));
            grid_roli.ItemsSource = rols.GetData();

        }

        private void grid_roli_Selected(object sender, RoutedEventArgs e)
        {
            
                if (grid_roli.SelectedItems.Count > 0)
                {
                    DataRowView rowView = grid_roli.SelectedItems[0] as DataRowView;

                    if (rowView != null)
                    {
                        string valueInColumn1 = rowView["Roli_name"].ToString();
                        string valueInColumn2 = rowView["Roli_login"].ToString();
                        string valueInColumn3 = rowView["Roli_password"].ToString();
                        
                        new_rol.Text = valueInColumn1;
                        new_login.Text = valueInColumn2;
                        new_password.Text = valueInColumn3;
                        
                    }
                }

            }
        }
    
}
