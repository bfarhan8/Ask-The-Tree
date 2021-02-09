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
    /// Interaction logic for Englishpage.xaml
    /// </summary>
    public partial class Englishpage : Window
    {
        public Englishpage()
        {
            InitializeComponent();
            btn1Text.Text = Settings.Default.btn1E;
            btn2Text.Text = Settings.Default.btn2E;
            btn3Text.Text = Settings.Default.btn3E;
            btn4Text.Text = Settings.Default.btn4E;
            btn5Text.Text = Settings.Default.btn5E;
            btn6Text.Text = Settings.Default.btn6E;
            btn7Text.Text = Settings.Default.btn7E;
            btn8Text.Text = Settings.Default.btn8E;
            btn9Text.Text = Settings.Default.btn9E;

            btn1Text.FontSize =Convert.ToDouble(Settings.Default.btn1Esize);
            btn2Text.FontSize = Convert.ToDouble(Settings.Default.btn2Esize);
            btn3Text.FontSize = Convert.ToDouble(Settings.Default.btn3Esize);
            btn4Text.FontSize = Convert.ToDouble(Settings.Default.btn4Esize);
            btn5Text.FontSize = Convert.ToDouble(Settings.Default.btn5Esize);
            btn6Text.FontSize = Convert.ToDouble(Settings.Default.btn6Esize);
            btn7Text.FontSize = Convert.ToDouble(Settings.Default.btn7Esize);
            btn8Text.FontSize = Convert.ToDouble(Settings.Default.btn8Esize);
            btn9Text.FontSize = Convert.ToDouble(Settings.Default.btn9Esize);

           lblBack.FontSize = btn1Text.FontSize = Convert.ToDouble(Settings.Default.btnBackEsize);

        }
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public void playSound(String link)
        {

            mediaPlayer.Open(new Uri(link, UriKind.RelativeOrAbsolute));
            mediaPlayer.Play();

        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn1AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn2AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn3AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn4AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn5AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn6AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn7AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn8AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn9AudioE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }
        //Testing is the name of Arabic Page

        

        private void btnArabic_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            Settings.Default.destPage = "A";
            Settings.Default.Save();

            Testing Testing = new Testing();
            Testing.Show();
            this.Hide();

            
        }

        private void pgeEnglish_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //var login = new Login();

            //login.Show();
            //this.Hide();
        }

        private void pgeEnglish_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void lblBack_TouchDown(object sender, TouchEventArgs e)
        {
            var language = new LanguageSelection();
            language.Show();
            this.Hide();


        }

        private void secretLogin_TouchDown(object sender, TouchEventArgs e)
        {
            var login = new Login();

            login.Show();
            this.Hide();
        }

        private void secretLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var login = new Login();

            login.Show();
            this.Hide();
        }
    }
}
