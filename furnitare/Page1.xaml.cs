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
    public partial class Page1 : Window
    {
        public static Sotrudnik authUser;
        public Page1()
        {
            InitializeComponent();
        }

        private void authorization_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            if (lastTB.Text == "" || firsTB.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                Sotrudnik client = new Sotrudnik();
                client.Имя = firsTB.Text;
                client.Фамилия = lastTB.Text;
                client.Отчество = PervTB.Text;
                client.ДатаРождения = dtdatetime.SelectedDate.Value;
                client.Id_Sotrudnik = Convert.ToInt32(IdTb.Text);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Succesfull");
            }
        }
    }
}
