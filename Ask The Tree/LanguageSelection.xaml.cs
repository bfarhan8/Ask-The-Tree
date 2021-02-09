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
    /// Interaction logic for LanguageSelection.xaml
    /// </summary>
    public partial class LanguageSelection : Window
    {
        public LanguageSelection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            var englishpage = new Englishpage();
            englishpage.Show();
            this.Hide();
        }

        private void btnArabic_Click(object sender, RoutedEventArgs e)
        {
            var arabicpage = new Testing();
            arabicpage.Show();
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
