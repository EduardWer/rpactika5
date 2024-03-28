using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practa5_ints
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Page
    {
        public AdminPanel()
        {
            InitializeComponent();
            

        }

        private void Brend_table_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            if (button != null)
            {
                if (button.Name == "Brend_table")
                {
                    frame_adminpanel.Content = new Brend_list();
                }
                else if(button.Name == "Castomer_table")
                {
                    frame_adminpanel.Content = new Castomers_table();
                }
                else if (button.Name == "Crossovky_table")
                {
                    frame_adminpanel.Content = new Crossovki_list();
                }
                else if (button.Name == "Orders_table")
                {
                    frame_adminpanel.Content = new Orders();
                }
                else if (button.Name == "Polzovateli_table")
                {
                    frame_adminpanel.Content = new Polzovateli();
                }
                else if (button.Name == "Postavchiki_table")
                {
                    frame_adminpanel.Content = new postavchiki();
                }
                else if (button.Name == "Postavka_table")
                {
                    frame_adminpanel.Content = new Postavka();
                }
                else if (button.Name == "Roli_table")
                {
                    frame_adminpanel.Content = new AdminListxaml();
                }
                else if (button.Name == "Sclad_table")
                {
                    frame_adminpanel.Content = new Sclad();
                }
                else if (button.Name == "Zakazi_table")
                {
                    frame_adminpanel.Content = new Zakazi();
                }


            }
        }

        
    }
}
