using System;
using System.Collections;
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

namespace SortedList_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedlist;
        public MainWindow()
        {
            InitializeComponent();
            
            sortedlist = new SortedList();
        }

        private void ADD_Button_Click(object sender, RoutedEventArgs e)
        {
            //add
            sortedlist.Add(Key_txt.Text ,Value_txt.Text);
           
            //make Key_txt.Text,Value_txt.Text empty
            Key_txt.Text = String.Empty;
            Value_txt.Text = String.Empty;  
            
            //show
            ICollection collection = sortedlist.Keys;

            string data = "";
            
                foreach (string key in collection)
                {
                data = data + key + ",";

                }
            MessageBox.Show(data);
          
        }
    }
}
