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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool AlreadySaved = false;
        string SavePath; 

        public MainWindow()
        {
            InitializeComponent();
            
        }

        FontFamily timesNewRoman = new FontFamily("Times New Roman");
        FontFamily tahoma = new FontFamily("Tahoma");
        FontFamily segeoUI = new FontFamily("Segeo UI");

        private void FontPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontPicker.SelectedIndex == 0)
                TextPad.FontFamily = timesNewRoman;
            if (FontPicker.SelectedIndex == 1)
                TextPad.FontFamily = tahoma;
            if (FontPicker.SelectedIndex == 2)
                TextPad.FontFamily = segeoUI;
        }

        private void IsSpellCheck_Checked(object sender, RoutedEventArgs e)
        {
            TextPad.SpellCheck.IsEnabled = true;
            
        }

        private void IsSpellCheck_Unchecked (object sender, RoutedEventArgs e)
        {
            
                TextPad.SpellCheck.IsEnabled = false;
            
        }

        private void SizePicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SizePicker.SelectedIndex == 0)
                TextPad.FontSize = 9;
            if (SizePicker.SelectedIndex == 1)
                TextPad.FontSize = 12;
            if (SizePicker.SelectedIndex == 2)
                TextPad.FontSize = 15;
        }

        private void IsOnTop_Checked(object sender, RoutedEventArgs e)
        {
            My_Text_Editor.Topmost = true;
        }

        private void IsOnTop_Unchecked(object sender, RoutedEventArgs e)
        {
            My_Text_Editor.Topmost = false;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog myOpenFileDialog = new Microsoft.Win32.OpenFileDialog();
            myOpenFileDialog.FileName = "MyText";
            myOpenFileDialog.Filter = "Text Documents|*.txt";
            bool? result = myOpenFileDialog.ShowDialog();

            if (result == true)
            {
                System.IO.StreamReader myStreamReader = new System.IO.StreamReader(myOpenFileDialog.FileName);
                using (myStreamReader)
                {
                    string myText = myStreamReader.ReadToEnd();
                    TextPad.Document.Blocks.Clear();
                    TextPad.Document.Blocks.Add(new Paragraph(new Run(myText)));
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!AlreadySaved)
            {
                Microsoft.Win32.SaveFileDialog mySaveFileDialog = new Microsoft.Win32.SaveFileDialog();
                mySaveFileDialog.Filter = "Text Documents | *.txt";

                bool? result = mySaveFileDialog.ShowDialog();

                if (result == true)
                {
                    System.IO.StreamWriter myStreamWriter = new System.IO.StreamWriter(mySaveFileDialog.FileName);
                    using (myStreamWriter)
                    {
                        string myText = new TextRange(TextPad.Document.ContentStart, TextPad.Document.ContentEnd).Text;
                        myStreamWriter.Write(myText);
                    }

                    SavePath = mySaveFileDialog.FileName;
                    AlreadySaved = true;
                    
                }

            }
            else
            {
                System.IO.StreamWriter myStreamWriter = new System.IO.StreamWriter(SavePath);
                using (myStreamWriter)
                {
                    string myText = new TextRange(TextPad.Document.ContentStart, TextPad.Document.ContentEnd).Text;
                    myStreamWriter.Write(myText);
                }
            }

        }

        private void SaveAsButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog mySaveFileDialog = new Microsoft.Win32.SaveFileDialog();
            mySaveFileDialog.Filter = "Text Documents | *.txt";

            bool? result = mySaveFileDialog.ShowDialog();

            if (result == true)
            {
                System.IO.StreamWriter myStreamWriter = new System.IO.StreamWriter(mySaveFileDialog.FileName);
                using (myStreamWriter)
                {
                    string myText = new TextRange(TextPad.Document.ContentStart, TextPad.Document.ContentEnd).Text;
                    myStreamWriter.Write(myText);
                }
            }


            }
    }
}
