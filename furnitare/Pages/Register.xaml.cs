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


namespace furnitare
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            GenderCB.ItemsSource = MainWindow.db.Gender.ToList();
            GenderCB.DisplayMemberPath = "Name";
        }
        private void authorization_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            var selectedGender = GenderCB.SelectedItem as Gender;
            Sotrudniki client = new Sotrudniki();
            User user = new User();
            if (lastTB.Text == "" || firsTB.Text == "")
            {
                MessageBox.Show("Введите все данные");
            } 
            else
            {
                try
                {
                    client.FirstName = firsTB.Text;
                    client.LastName = lastTB.Text;
                    client.Patronymic = PervTB.Text;
                    client.Id_Gender = selectedGender.Id_Gender;



                    user.Login = LoginTB.Text;
                    user.Password = PasswordTB.Password;
                    user.Id_Doljnost = 2;
                    user.Id_Sotrudniki = client.Id_Sotrudniki;

                    MainWindow.db.User.Add(user);
                    MainWindow.db.Sotrudniki.Add(client);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Succesfull");
                }
                catch
                {
                    MessageBox.Show("login уже существует");
                }
            }
        }
    }
}
