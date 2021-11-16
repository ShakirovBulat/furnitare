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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Window
    {
        public static FurnitureShopEntities db = new FurnitureShopEntities();
        public Page3()
        {
            InitializeComponent();
            db = new FurnitureShopEntities();

            Grof1.ItemsSource = db.Sklad.ToList();
        }
        private void red_Click(object sender, RoutedEventArgs e)
        {
            var q = Grof1.SelectedItem as Sklad;
            if (q == null)
            {
                MessageBox.Show("Эта строка и так пустая.");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить строку?", "Удалить?", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    db.Sklad.Remove(q);
                    db.SaveChanges();
                    Grof1.ItemsSource = db.Sklad.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
            }
        }

        private void dwq_Click(object sender, RoutedEventArgs e)
        {
            Page4 p4 = new Page4();
            this.Close();
            p4.Show();
        }

        private void dwq_Copy_Click(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2();
            this.Close();
            p2.Show();
        }
    }
}
