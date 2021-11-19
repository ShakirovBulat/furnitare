
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace furnitare
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static FurnitureShopEntities db = new FurnitureShopEntities();
        public static User authUser;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void register_Click(object sender, RoutedEventArgs e)
        {
            Register rg = new Register();
            this.Close();
            rg.Show();
        }

        
        private void login_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in db.User)
            {
                if (user.Login == LoginTb.Text.Trim())
                {
                    if (user.Password == PasswordTB.Password.Trim() && user.Id_Doljnost == 2)
                    {
                        MessageBox.Show($"Привет Пользователь {user.Login}");
                        authUser = user;
                        FurnitUser frus = new FurnitUser();
                        this.Close();
                        frus.Show();
                    }
                    if (user.Password == PasswordTB.Password.Trim() && user.Id_Doljnost == 1)
                    {
                        MessageBox.Show($"Привет админ {user.Login}");
                        Furnitur fr = new Furnitur();
                        this.Close();
                        fr.Show();
                    }
                }
            }
        }
    }
}
