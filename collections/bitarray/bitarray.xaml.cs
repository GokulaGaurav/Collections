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
    /// Interaction logic for bitarray.xaml
    /// </summary>
    public partial class bitarray : Window
    {
        public bitarray()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BitArray bitArray = new BitArray(4);
            bitArray.Set(0, true);
            bitArray.Set(1, false);

            foreach (bool bit in bitArray)
            {
                MessageBox.Show((bit));
            }
        }
    }
}
