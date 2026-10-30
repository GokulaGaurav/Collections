using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace collections
{
    /// <summary>
    /// Interaction logic for sortedlist.xaml
    /// </summary>
    public partial class sortedlist : Window
    {
        public sortedlist()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add("A", "Value A");
            sortedList.Add("B", "Value B");

            foreach (DictionaryEntry item in sortedList)
            {
                MessageBox.Show((item.Key + ": " + item.Value));
            }
        }
    }
}
