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

namespace Wpf.Queue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue<int> queue = new Queue<int>();
        Random _r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Enqueue_Click(object sender, RoutedEventArgs e)
        {
            int num = _r.Next(0, 999);
            queue.Enqueue(num);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            for (int i = 1; i <= 6; i++)
            {
                Label label = (Label)FindName("queue_label_" + i);
                label.Content = string.Empty;
            }
            int index = 0;
            foreach (int messege in queue)
            {
                if (index <= 5)
                {
                    Label label = (Label)FindName("queue_label_" + (index + 1));
                    label.Content = messege;
                }
                else
                {
                    break;
                }
                index++;
            }
        }

        private void button_Dequeue_Click(object sender, RoutedEventArgs e)
        {
            int num = queue.Dequeue();
            listBox1.Items.Add(num);
            UpdateGrid();
        }
    }
}
