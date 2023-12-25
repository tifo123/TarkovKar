using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TarkovKar
{
    /// <summary>
    /// Логика взаимодействия для PageCus.xaml
    /// </summary>
    public partial class PageCus : Page
    {
        private bool isPageOpen;

        public PageCus()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new haha.PageDORO();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(haha.PageDORO)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame2.Content = new haha.PageF();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame2.Navigate(typeof(haha.PageF)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame3.Content = new haha.PageG();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame3.Navigate(typeof(haha.PageG)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame4.Content = new haha.PageH();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame4.Navigate(typeof(haha.PageH)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame5.Content = new haha.PageJ();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame5.Navigate(typeof(haha.PageJ)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame6.Content = new haha.PageK();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame6.Navigate(typeof(haha.PageK)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }
    }
}
