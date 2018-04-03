using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace DzAdoNet
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

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = "Data Source=A-305-07;Initial Catalog=A_trash;Integrated Security=True";
            connection.ConnectionString = connectionString;

            return connection;
        }

        private void CreateTableGroup()
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();
                SqlCommand createCommand = connection.CreateCommand();
                createCommand.CommandText = @"CREATE TABLE gruppa(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))";
                createCommand.ExecuteNonQuery();
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            CreateTableGroup();
        }
    }
}
