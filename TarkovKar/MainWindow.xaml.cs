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
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TarkovKar
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
        private SqlConnection sqlConnection = null;

        
        class DB
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);

            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }

            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            public SqlConnection getConnection()
            {
                return connection;
            }
        }
        public static string Login {  get; set; }
        public string Password { get; set; }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string login = TextLogin.Text;
            string password = TextPassword.Password;
          
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [user8] WHERE (Login)= @uL AND (Password) = @uP ", db.getConnection());
            adapter.SelectCommand = command;
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = password;
            adapter.Fill(table);
            Login = login;
            if (table.Rows.Count > 0)
            {
                var MainWindow = new Window2(); //create your new form.
                MainWindow.Show(); //show the new form.
                this.Close();


            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль!");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var MainWindow = new Window1(); //create your new form.
            MainWindow.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }
        
    }   
}

