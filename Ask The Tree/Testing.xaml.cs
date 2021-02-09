using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Media;
using Ask_The_Tree.Properties;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
namespace Ask_The_Tree
{
    /// <summary>
    /// Interaction logic for Testing.xaml
    /// </summary>
    public partial class Testing : Window
    {
        public Testing()
        {
          
            InitializeComponent();
            btn1Text.Text = Settings.Default.btn1A;
            btn2Text.Text = Settings.Default.btn2A;
            btn3Text.Text = Settings.Default.btn3A;
            btn4Text.Text = Settings.Default.btn4A;
            btn5Text.Text = Settings.Default.btn5A;
            btn6Text.Text = Settings.Default.btn6A;
            btn7Text.Text = Settings.Default.btn7A;
            btn8Text.Text = Settings.Default.btn8A;
            btn9Text.Text = Settings.Default.btn9A;
            btnExtraText.Text = Settings.Default.btnExtra;

            btn1Text.FontSize = Convert.ToDouble(Settings.Default.btn1Asize);
            btn2Text.FontSize = Convert.ToDouble(Settings.Default.btn2Asize);
            btn3Text.FontSize = Convert.ToDouble(Settings.Default.btn3Asize);
            btn4Text.FontSize = Convert.ToDouble(Settings.Default.btn4Asize);
            btn5Text.FontSize = Convert.ToDouble(Settings.Default.btn5Asize);
            btn6Text.FontSize = Convert.ToDouble(Settings.Default.btn6Asize);
            btn7Text.FontSize = Convert.ToDouble(Settings.Default.btn7Asize);
            btn8Text.FontSize = Convert.ToDouble(Settings.Default.btn8Asize);
            btn9Text.FontSize = Convert.ToDouble(Settings.Default.btn9Asize);
            btnExtraText.FontSize = Convert.ToDouble(Settings.Default.btnExtraSize);
            lblBack.FontSize = Convert.ToDouble(Settings.Default.btnBackAsize);


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
                playSound(Settings.Default.btn1AudioA.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Issue is "+ ex);
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btn2AudioA.ToString());
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
                playSound(Settings.Default.btn3AudioA.ToString());
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
                playSound(Settings.Default.btn4AudioA.ToString());
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
                playSound(Settings.Default.btn5AudioA.ToString());
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
                playSound(Settings.Default.btn6AudioA.ToString());
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
                playSound(Settings.Default.btn7AudioA.ToString());
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
                playSound(Settings.Default.btn8AudioA.ToString());
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
                playSound(Settings.Default.btn9AudioA.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            Settings.Default.destPage = "E";
            Settings.Default.Save();

            Englishpage englishpage = new Englishpage();
            englishpage.Show();
            this.Hide();

            
        }
      
        private void pgeArabic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //var login = new Login();

            //login.Show();
            //this.Hide();
        }

        private void pgeArabic_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void lblBack_TouchDown(object sender, TouchEventArgs e)
        {
            var language = new LanguageSelection();
            language.Show();
            this.Hide();
        }

        private void btnExtra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                playSound(Settings.Default.btnExtraAudio.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
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

        //private void btn4_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btn4_Click_1(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
