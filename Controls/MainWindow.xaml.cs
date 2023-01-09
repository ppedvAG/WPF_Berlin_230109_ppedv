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

namespace Controls
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

        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            Btn_KlickMich.Content = (Cbb_Auswahl.SelectedItem as ComboBoxItem)?.Content;

            Lbl_Output.Content = Sdr_Wert.Value.ToString();
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Soll das Fenster wirklich geschlossen werden?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                this.Close();
        }

        private void Neu_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new MainWindow();
            wnd.Title = "Neues Fenster";
            wnd.Show();
        }

        private void Dialog_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new MainWindow();
            wnd.Title = "Neues Dialog-Fenster";
            if (wnd.ShowDialog() == true)
                Lbl_Output.Content = "OKAY";
        }

        private void Btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
