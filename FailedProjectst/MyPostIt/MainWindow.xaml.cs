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
using System.Collections;
using System.Collections.ObjectModel;
using System.IO;


namespace MyPostIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Notes = new ObservableCollection<string>();

        public void UpdateList()
        {
            listBox.ItemsSource = null;
            listBox.Items.Clear();

            if (!(File.Exists("Notes.xml")))
                File.Create("Notes.xml");

            using (System.IO.StreamReader myStreamReader = new StreamReader("Notes.xml"))
            {
                System.Xml.Serialization.XmlSerializer myXML = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<String>));
                Notes = (ObservableCollection<String>)myXML.Deserialize(myStreamReader);

            }

            Notes.Reverse();
            
            listBox.ItemsSource = Notes;
           
            
        }

        public MainWindow()
        {
            

            InitializeComponent();
            UpdateList();
            
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow myAddWindow = new AddWindow();
            myAddWindow.Show();
        }

        
    }
}
