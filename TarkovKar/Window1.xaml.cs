using System;
using System.Collections.Generic;
using System.Data;
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
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TarkovKar
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            TextLogin.Text = "Введите имя";
            TextPassword.Text = "Введите пароль";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TextLogin.Text;
            string password = TextPassword.Text;

            if(TextLogin.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (TextPassword.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }


            int Admin = 1;
            int user = 2;
            int quser = 3;
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            SqlCommand command = new SqlCommand("INSERT INTO [user8] (Login , Password, Role) VALUES (@Login, @Password, @Role ) ");
            command.Parameters.Add("@Login", SqlDbType.VarChar).Value = TextLogin.Text;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = TextPassword.Text;
            command.Parameters.Add("@Role", SqlDbType.Int).Value = quser;
            command.Connection = connection1;

            connection1.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
                var MainWindow = new MainWindow(); //create your new form.
                MainWindow.Show(); //show the new form.
                this.Close(); //only if you want to close the current form.
            }

            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }



            connection1.Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextLogin.Text == "Введите имя")
                TextLogin.Text = "";
        }

        private void TextLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextLogin.Text == "")
                TextLogin.Text = "Введите имя";
        }

        private void TextPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextPassword.Text == "Введите пароль")
                TextPassword.Text = "";
        }

        private void TextPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextPassword.Text == "")
                TextPassword.Text = "Введите пароль";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window1 = new MainWindow(); //create your new form.
            window1.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }
    }
    }

