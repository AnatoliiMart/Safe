using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            // Get the current button.

            Button btn = (Button)e.OriginalSource;

            if (btn.Content.ToString() == "C")
                tb1.Text = string.Empty;
            else if (btn.Content.ToString() == "OK")
                MessageBox.Show("Сейф открыт. Поздравляю!");
            else
                tb1.Text += btn.Content.ToString();
        }
    }
}
