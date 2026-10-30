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
using System.Collections;

namespace collections
{
    /// <summary>
    /// Interaction logic for hashtable.xaml
    /// </summary>
    public partial class hashtable : Window
    {
        public hashtable()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "gaurav");
            hashtable.Add("age", 20);
            MessageBox.Show("Age: " + hashtable["age"]);
            hashtable.Remove("age");
        }
    }
}
