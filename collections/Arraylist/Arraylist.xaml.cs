using System.Text;
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

namespace collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_array_Click(object sender, RoutedEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Gaurav");
            arrayList.Add(1);      
            arrayList.Add(true);
            arrayList.Remove("Gaurav");
            foreach (var item in arrayList)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}