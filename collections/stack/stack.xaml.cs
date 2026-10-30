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
    /// Interaction logic for stack.xaml
    /// </summary>
    public partial class stack : Window
    {
        public stack()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stack stack = new Stack();
            stack.Push("gokul");
            stack.Push("gaurav");
            MessageBox.Show(("Top element: " + stack.Peek()));
            stack.Pop();
        }
    }
}
