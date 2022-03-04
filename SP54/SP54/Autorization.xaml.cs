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

namespace SP54
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        Entities context = new Entities();
        public Autorization()
        {
            InitializeComponent();
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Text == "Enter your password")
            {
                Password.Text = null;
                Password.Foreground = Brushes.Black;
            }
        }

        private void Email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "Enter your email address")
            {
                Email.Text = null;
                Email.Foreground = Brushes.Black;
            }
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Enter your email address";
                Email.Foreground = Brushes.Gray;
            }
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Enter your password";
                Password.Foreground = Brushes.Gray;
            }
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            var check = context.User.Where(i => i.Email == Email.Text && i.Password == Password.Text).ToList();
            if (check.Any())
            {
                if (check.Where(i => i.RoleId == "A").Any())
                {
                    AdministratorMenu administratorMenu = new AdministratorMenu();
                    administratorMenu.Show();
                    this.Close();
                }
            }
        }
    }
}
