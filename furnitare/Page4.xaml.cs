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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Window
    {
        public static FurnitureShopEntities db = new FurnitureShopEntities();
        public Page4()
        {
            InitializeComponent();
            db = new FurnitureShopEntities();

            Grof2.ItemsSource = db.Shop.ToList();
        }
        private void red_Click(object sender, RoutedEventArgs e)
        {
            var q = Grof2.SelectedItem as Shop;
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
                    db.Shop.Remove(q);
                    db.SaveChanges();
                    Grof2.ItemsSource = db.Shop.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
            }
            
        } 

        private void dwq_Copy_Click(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3();
            this.Close();
            p3.Show();
        }
    }
}
