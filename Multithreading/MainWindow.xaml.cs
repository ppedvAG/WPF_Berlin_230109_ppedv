using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Multithreading
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

        public int Counter { get; set; } = 0;

        private void Btn_ShortTask_Click(object sender, RoutedEventArgs e)
        {
            Counter += 1;
            Tbl_ShortTask.Text = Counter.ToString();
        }

        private async void Btn_LongTask_Click(object sender, RoutedEventArgs e)
        {
            string taskResult = "";

            taskResult = await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Fertig";
            });

            Tbl_LongTask.Text = taskResult;

        }
    }
}
