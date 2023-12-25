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
    /// Логика взаимодействия для PageZav.xaml
    /// </summary>
    public partial class PageZav : Page
    {
        private bool isPageOpen;

        public PageZav()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new ha.Page11();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(ha.Page11)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame2.Content = new ha.Page12();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame2.Navigate(typeof(ha.Page12)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame3.Content = new Page13();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame2.Navigate(typeof(Page13)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame6.Content = new ha.Page14();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame6.Navigate(typeof(ha.Page14)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame5.Content = new ha.Page16();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame5.Navigate(typeof(ha.Page16)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame4.Content = new ha.Page15();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame4.Navigate(typeof(ha.Page15)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }
    }
}
