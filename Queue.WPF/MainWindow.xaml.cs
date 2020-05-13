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
using AlgorithmAndDataStructure.Queque;

namespace Queue.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _r = new Random();
        Queue<int> queue = new Queue<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Enqueue_Click(object sender, RoutedEventArgs e)
        {
            int number = _r.Next(0, 999);
            queue_label_1.Content = number;

        }
    }
}
