using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Ask_The_Tree.Properties;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ask_The_Tree
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
         
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var settingspage = new SettingsPage();
            
            if (txtUser.Text == "s-creators" & txtPass.Password.ToString() == "wesam123")
            {
                
                    settingspage.Show();
                    this.Close();
                
                
            }
            else
            {
                MessageBox.Show("User Name OR Password is Wrong","Issue",MessageBoxButton.OKCancel,MessageBoxImage.Stop);

            }

           

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        { var englishpage = new Englishpage();
            var arabicpage = new Testing();

            if (Settings.Default.destPage == "E")
            {
                englishpage.Show();
                this.Hide();
            }
            if (Settings.Default.destPage == "A")
            {
                arabicpage.Show();
                this.Hide();
            }
        }
    }
}
