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
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TarkovKar
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    /// 
    public partial class Window2 : Window
    {
        string Login = MainWindow.Login;
        public Window2()
        {
            InitializeComponent();
        }
        int RoleUser = 0;
        private bool isPageOpen;

        void uiop()
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);//Подключение бд к коду
            SqlCommand command2 = new SqlCommand("SELECT id,Role FROM [user8] WHERE (Login)= @uL  ", connection1);//выборка id пользователя по логину входа
            command2.Parameters.Add("@uL", SqlDbType.VarChar).Value = Login;

            command2.Connection = connection1;
            connection1.Open();


            using (SqlDataReader oReader = command2.ExecuteReader())
            {
                int IdUser = 0;
                while (oReader.Read())
                {
                    string StringId = oReader["id"].ToString();
                    string StringRoleUser = oReader["Role"].ToString();
                    IdUser = Int32.Parse(StringId);//получение id пользователя под переменной
                    RoleUser = Int32.Parse(StringRoleUser);
                }

                connection1.Close();
            }
        }

        private void Cus_Click(object sender, RoutedEventArgs e)
        {
            uiop();
         
            
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new PageCus();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(PageCus)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }

        }

        private void Zav_Click(object sender, RoutedEventArgs e)
        {
          
            if (RoleUser < 3)
            {
                Frame1.Content = new PageZav();               
            }
            else
            {
                 
                MessageBox.Show("Купите подписку");
                
            } 

            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new PageZav();
                isPageOpen = true;

            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(PageZav)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Les_Click(object sender, RoutedEventArgs e)
        {
            if(RoleUser < 3)
            {
                Frame1.Content = new PageLes();
            }
            else
            {
                MessageBox.Show("Купите подписку");
            }
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new PageLes();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(PageLes)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Frame1_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new PageNovosti();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(PageNovosti)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new Page545();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(Page545)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           

            if (RoleUser < 3)
            {
                Frame1.Content = new Page556();
            }
            else
            {
                MessageBox.Show("Купите подписку");
            }
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new Page556();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(Page556)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }
    

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page762();
            if (RoleUser < 3)
            {
                Frame1.Content = new Page762();
            }
            else
            {
                MessageBox.Show("Купите подписку");
            }
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame1.Content = new Page762();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame1.Navigate(typeof(Page762)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame3.Content = new PagePr();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame3.Navigate(typeof(PagePDD)); // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
            if (!isPageOpen)
            {
                // Открываем страницу
                Frame6.Content = new PagePDD();
                isPageOpen = true;
            }
            else
            {
                // Закрываем страницу
                Frame6.Navigate(typeof(PagePDD));  // Перенаправляемся на эту же страницу, чтобы закрыть открытую страницу
                isPageOpen = false;
            }
        }
    }
}

