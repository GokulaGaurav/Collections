using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// Interaction logic for namevaluecollection.xaml
    /// </summary>
    public partial class namevaluecollection : Window
    {
        public namevaluecollection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("Name", "gokul");
            nameValueCollection.Add("Name", "gaurav");

            foreach (string key in nameValueCollection)
            {
                MessageBox.Show((key + ": " + nameValueCollection[key]));
            }
        }
    }
}
