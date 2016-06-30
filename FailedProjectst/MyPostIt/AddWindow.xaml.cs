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
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace MyPostIt
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        ObservableCollection<string> Notes = new ObservableCollection<string>();
        public AddWindow()
        {
            InitializeComponent();
            MainWindow myMainWindow = new MainWindow();
            Notes = myMainWindow.Notes;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string stringToAdd = textBox.Text;
            Notes.Add(stringToAdd);

            using (StringWriter myStringWirter = new StringWriter())
            {
                XmlSerializer myXML = new XmlSerializer(typeof(ObservableCollection<string>));

                
                myXML.Serialize(myStringWirter, Notes);

                using (StreamWriter myStreamWriter = new StreamWriter("Notes.xml"))
                {
                    myStreamWriter.Write(myStringWirter);
                }

            }

            MainWindow myMainWindow = new MainWindow();
            myMainWindow.UpdateList();

            this.Close();
        

        
        }
    }
}
