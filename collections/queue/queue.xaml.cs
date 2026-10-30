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
    /// Interaction logic for queue.xaml
    /// </summary>
    public partial class queue : Window
    {
        public queue()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Queue queue= new Queue();
            queue.Enqueue("Gokula");
            queue.Enqueue("Gaurav");
            MessageBox.Show("first element: " + queue.Peek());
            queue.Dequeue();
        }
    }
}
