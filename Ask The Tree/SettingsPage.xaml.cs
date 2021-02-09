using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Ask_The_Tree.Properties;
using Microsoft.Win32;
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
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Window
    {
        public SettingsPage()
        {
            InitializeComponent();
            //Add Items in combo box of English audio.

            cmbAudioEnglish.Items.Add("Button 1");
            cmbAudioEnglish.Items.Add("Button 2");
            cmbAudioEnglish.Items.Add("Button 3");
            cmbAudioEnglish.Items.Add("Button 4");
            cmbAudioEnglish.Items.Add("Button 5");
            cmbAudioEnglish.Items.Add("Button 6");
            cmbAudioEnglish.Items.Add("Button 7");
            cmbAudioEnglish.Items.Add("Button 8");
            cmbAudioEnglish.Items.Add("Button 9");

            //Add Items in combo box of Arabic audio.

            cmbAudioArabic.Items.Add("Button 1");
            cmbAudioArabic.Items.Add("Button 2");
            cmbAudioArabic.Items.Add("Button 3");
            cmbAudioArabic.Items.Add("Button 4");
            cmbAudioArabic.Items.Add("Button 5");
            cmbAudioArabic.Items.Add("Button 6");
            cmbAudioArabic.Items.Add("Button 7");
            cmbAudioArabic.Items.Add("Button 8");
            cmbAudioArabic.Items.Add("Button 9");
            cmbAudioArabic.Items.Add("Extra Button");

            //Add Items in combo box of English Question.

            cmbQuestionEnglish.Items.Add("Button 1");
            cmbQuestionEnglish.Items.Add("Button 2");
            cmbQuestionEnglish.Items.Add("Button 3");
            cmbQuestionEnglish.Items.Add("Button 4");
            cmbQuestionEnglish.Items.Add("Button 5");
            cmbQuestionEnglish.Items.Add("Button 6");
            cmbQuestionEnglish.Items.Add("Button 7");
            cmbQuestionEnglish.Items.Add("Button 8");
            cmbQuestionEnglish.Items.Add("Button 9");
          


            //Add Items in combo box of Arabic Question.

            cmbQuestionArabic.Items.Add("Button 1");
            cmbQuestionArabic.Items.Add("Button 2");
            cmbQuestionArabic.Items.Add("Button 3");
            cmbQuestionArabic.Items.Add("Button 4");
            cmbQuestionArabic.Items.Add("Button 5");
            cmbQuestionArabic.Items.Add("Button 6");
            cmbQuestionArabic.Items.Add("Button 7");
            cmbQuestionArabic.Items.Add("Button 8");
            cmbQuestionArabic.Items.Add("Button 9");
            cmbQuestionArabic.Items.Add("Extra Button");
            //Add Items in combo box of Arabic Size Name

            cmbNameArabic.Items.Add("Button 1");
            cmbNameArabic.Items.Add("Button 2");
            cmbNameArabic.Items.Add("Button 3");
            cmbNameArabic.Items.Add("Button 4");
            cmbNameArabic.Items.Add("Button 5");
            cmbNameArabic.Items.Add("Button 6");
            cmbNameArabic.Items.Add("Button 7");
            cmbNameArabic.Items.Add("Button 8");
            cmbNameArabic.Items.Add("Button 9");
            cmbNameArabic.Items.Add("Extra Button");
            cmbNameArabic.Items.Add("Back Button");

            //Add Items in combo box of Arabic size

            cmbSizeArabic.Items.Add("8.0");
            cmbSizeArabic.Items.Add("9.0");
            cmbSizeArabic.Items.Add("10.0");
            cmbSizeArabic.Items.Add("11.0");
            cmbSizeArabic.Items.Add("14.0");
            cmbSizeArabic.Items.Add("18.0");
            cmbSizeArabic.Items.Add("20.0");
            cmbSizeArabic.Items.Add("22.0");
            cmbSizeArabic.Items.Add("28.0");
            cmbSizeArabic.Items.Add("34.0");
            cmbSizeArabic.Items.Add("38.0");
            cmbSizeArabic.Items.Add("50.0");
            cmbSizeArabic.Items.Add("62.0");
            cmbSizeArabic.Items.Add("72.0");

            // Add Items in Combo box of English size name

            cmbNameEnglish.Items.Add("Button 1");
            cmbNameEnglish.Items.Add("Button 2");
            cmbNameEnglish.Items.Add("Button 3");
            cmbNameEnglish.Items.Add("Button 4");
            cmbNameEnglish.Items.Add("Button 5");
            cmbNameEnglish.Items.Add("Button 6");
            cmbNameEnglish.Items.Add("Button 7");
            cmbNameEnglish.Items.Add("Button 8");
            cmbNameEnglish.Items.Add("Button 9");
            cmbNameEnglish.Items.Add("Back Button");

            // Add Items in the combobox of English size

            cmbSizeEnglish.Items.Add("8.0");
            cmbSizeEnglish.Items.Add("9.0");
            cmbSizeEnglish.Items.Add("10.0");
            cmbSizeEnglish.Items.Add("11.0");
            cmbSizeEnglish.Items.Add("14.0");
            cmbSizeEnglish.Items.Add("18.0");
            cmbSizeEnglish.Items.Add("20.0");
            cmbSizeEnglish.Items.Add("22.0");
            cmbSizeEnglish.Items.Add("28.0");
            cmbSizeEnglish.Items.Add("34.0");
            cmbSizeEnglish.Items.Add("38.0");
            cmbSizeEnglish.Items.Add("50.0");
            cmbSizeEnglish.Items.Add("62.0");
            cmbSizeEnglish.Items.Add("72.0");


        }
        string filename;
        private void slctFileEnglish_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Please Select an Audio File";

                Nullable<bool> result = openFileDialog.ShowDialog();

                if (result == true)
                {
                    filename = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Issue Is in Selecting File(English) " + ex);
            }
        }

        private void btnSaveAudioEnglish_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbAudioEnglish.Text == "Button 1")
                {
                    Settings.Default.btn1AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 2")
                {
                    Settings.Default.btn2AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 3")
                {
                    Settings.Default.btn3AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 4")
                {
                    Settings.Default.btn4AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 5")
                {
                    Settings.Default.btn5AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 6")
                {
                    Settings.Default.btn6AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 7")
                {
                    Settings.Default.btn7AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 8")
                {
                    Settings.Default.btn8AudioE = filename;
                }
                if (cmbAudioEnglish.Text == "Button 9")
                {
                    Settings.Default.btn9AudioE = filename;
                }

                Settings.Default.Save();
                MessageBox.Show("Audio File Has Been Saved Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue Is in Saving File(English Audio) " + ex);
            }
        }
        string filenameA;
        private void slctFileArabic_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Please Select an Audio File";

                Nullable<bool> result = openFileDialog.ShowDialog();

                if (result == true)
                {
                    filenameA = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Issue Is In Audio File Selection(Arabic) " + ex);
            }
        }

        private void btnSaveAudioArabic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbAudioArabic.Text == "Button 1")
                {
                    Settings.Default.btn1AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 2")
                {
                    Settings.Default.btn2AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 3")
                {
                    Settings.Default.btn3AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 4")
                {
                    Settings.Default.btn4AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 5")
                {
                    Settings.Default.btn5AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 6")
                {
                    Settings.Default.btn6AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 7")
                {
                    Settings.Default.btn7AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 8")
                {
                    Settings.Default.btn8AudioA = filenameA;
                }
                if (cmbAudioArabic.Text == "Button 9")
                {
                    Settings.Default.btn9AudioA = filenameA;
                }
                if (cmbAudioArabic.Text =="Extra Button")
                {
                    Settings.Default.btnExtraAudio = filenameA;
                }

                Settings.Default.Save();
                MessageBox.Show("Audio File Has Been Saved Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue Is in Saving File(Arabic Audio) " + ex);
            }
        }

        private void txtQuestionEnglish_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSaveQuestionEnglish_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbQuestionEnglish.Text == "Button 1")
                {
                    Settings.Default.btn1E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 2")
                {
                    Settings.Default.btn2E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 3")
                {
                    Settings.Default.btn3E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 4")
                {
                    Settings.Default.btn4E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 5")
                {
                    Settings.Default.btn5E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 6")
                {
                    Settings.Default.btn6E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 7")
                {
                    Settings.Default.btn7E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 8")
                {
                    Settings.Default.btn8E = txtQuestionEnglish.Text;
                }
                if (cmbQuestionEnglish.Text == "Button 9")
                {
                    Settings.Default.btn9E = txtQuestionEnglish.Text;
                }
                Settings.Default.Save();
                MessageBox.Show("Text Has Been Changed Sucessfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                txtQuestionEnglish.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is in Saving Text(English) " + ex);
            }
        }

        private void btnSaveQuestionArabic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(cmbQuestionArabic.Text == "Button 1")
                {
                    Settings.Default.btn1A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 2")
                {
                    Settings.Default.btn2A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 3")
                {
                    Settings.Default.btn3A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 4")
                {
                    Settings.Default.btn4A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 5")
                {
                    Settings.Default.btn5A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 6")
                {
                    Settings.Default.btn6A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 7")
                {
                    Settings.Default.btn7A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 8")
                {
                    Settings.Default.btn8A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Button 9")
                {
                    Settings.Default.btn9A = txtQuestionArabic.Text;
                }
                if (cmbQuestionArabic.Text == "Extra Button")
                {
                    Settings.Default.btnExtra = txtQuestionArabic.Text;
                }
                Settings.Default.Save();
                MessageBox.Show("Text Has Been Changed Sucessfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                txtQuestionArabic.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is in Saving Text(Arabic) " + ex);
            }
        }
       
        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            Testing arabicpage = new Testing();
            Englishpage englishpage = new Englishpage();

            if (Settings.Default.destPage == "A")
            {

                arabicpage.Show();
                this.Hide();
            }
           if (Settings.Default.destPage == "E")
            {
               
                englishpage.Show();
                this.Close();
            }
        }

        private void btnSaveSizeEnglish_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbNameEnglish.Text == "Button 1")
                {
                    Settings.Default.btn1Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 2")
                {
                    Settings.Default.btn2Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 3")
                {
                    Settings.Default.btn3Esize = cmbSizeEnglish.Text.ToString();
                }

                if (cmbNameEnglish.Text == "Button 4")
                {
                    Settings.Default.btn4Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 5")
                {
                    Settings.Default.btn5Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 6")
                {
                    Settings.Default.btn6Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 7")
                {
                    Settings.Default.btn7Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 8")
                {
                    Settings.Default.btn8Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Button 9")
                {
                    Settings.Default.btn9Esize = cmbSizeEnglish.Text.ToString();
                }
                if (cmbNameEnglish.Text == "Back Button")
                {
                    Settings.Default.btnBackEsize = cmbSizeEnglish.Text.ToString();
                }
                if(cmbSizeEnglish.Text =="")
                {
                    MessageBox.Show("Value is Not Selected", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                Settings.Default.Save();
                MessageBox.Show("Size has been changed Sucessfully","Information",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Issue is in Saving Size (English) "+ ex);    
            }

        }

        private void btnSaveSizeArabic_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (cmbNameArabic.Text == "Button 1")
                {
                    Settings.Default.btn1Asize = cmbSizeArabic.Text;
                }
                if (cmbNameArabic.Text == "Button 2")
                {
                    Settings.Default.btn2Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 3")
                {
                    Settings.Default.btn3Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 4")
                {
                    Settings.Default.btn4Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 5")
                {
                    Settings.Default.btn5Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 6")
                {
                    Settings.Default.btn6Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 7")
                {
                    Settings.Default.btn7Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 8")
                {
                    Settings.Default.btn8Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Button 9")
                {
                    Settings.Default.btn9Asize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Back Button")
                {
                    Settings.Default.btnBackAsize = cmbSizeArabic.Text;
                }

                if (cmbNameArabic.Text == "Extra Button")
                {
                    Settings.Default.btnExtraSize = cmbSizeArabic.Text;
                }
                if (cmbSizeArabic.Text == "" | cmbNameArabic.Text =="")
                {
                    MessageBox.Show("Value is Not Selected","Warning",MessageBoxButton.OK,MessageBoxImage.Warning);
                    return;
                }
                Settings.Default.Save();
                MessageBox.Show("Size has been changed Sucessfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            { MessageBox.Show("Issue is in Saving Size(Arabic) "+ ex); }
        }
    }
}
