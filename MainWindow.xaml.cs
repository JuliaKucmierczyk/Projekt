using Microsoft.EntityFrameworkCore;
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

namespace ProjektZaliczeniowy2
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
        public class BloggingContext : DbContext
        {


            public string ConnectionString { get; }

            public BloggingContext(string connectionString)
            {
                this.ConnectionString = connectionString;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(this.ConnectionString);
            }
        }
        // Hint: change `DESKTOP-123ABC\SQLEXPRESS` to your server name
        //       alternatively use `localhost` or `localhost\SQLEXPRESS`
        public static void Connect()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=blogdb;Integrated Security=True";

            using (BloggingContext db = new BloggingContext(connectionString))
            {
                Console.WriteLine($"Database ConnectionString: {db.ConnectionString}.");
            }
        }
        private void ShowTabel(object sender, RoutedEventArgs e)
        {

        }
    }
}
