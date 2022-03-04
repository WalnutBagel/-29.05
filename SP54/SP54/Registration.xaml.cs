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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Entities context = new Entities();
        public Registration()
        {
            InitializeComponent();
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

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            context.User.Add(new User
            {
                Email = Email.Text,
                Password = Password.Text,
                FirstName = Name.Text,
                LastName = Surname.Text,
                RoleId = "C"

            }
                );
            context.SaveChanges();
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "Enter your name")
            {
                Name.Text = null;
                Name.Foreground = Brushes.Black;
            }
        }

        private void Surname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Surname.Text == "Enter your surname")
            {
                Surname.Text = null;
                Surname.Foreground = Brushes.Black;
            }
        }
        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Text = "Enter your name";
                Name.Foreground = Brushes.Gray;
            }
        }

        private void Surname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Enter your surname";
                Surname.Foreground = Brushes.Gray;
            }
        }
    }
}
