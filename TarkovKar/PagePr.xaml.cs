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

namespace TarkovKar
{
    /// <summary>
    /// Логика взаимодействия для PagePr.xaml
    /// </summary>
    public partial class PagePr : Page
    {
        public PagePr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            // Создайте экземпляр окна WPF
            MainWindow mainWindow = new MainWindow();

            // Закройте все открытые окна
            foreach (Window window in Application.Current.Windows)
            {
                if (window != mainWindow)
                {
                    window.Close();
                }
            }

            // Покажите окно WPF
            mainWindow.Show();

            // Закройте текущую страницу
            NavigationService.Navigate(null);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
