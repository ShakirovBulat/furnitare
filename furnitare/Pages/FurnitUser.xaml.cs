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
    /// Логика взаимодействия для FurnitUser.xaml
    /// </summary>
    public partial class FurnitUser : Window
    {
        public static FurnitureShopEntities db = new FurnitureShopEntities();
        public FurnitUser()
        {
            InitializeComponent();
            db = new FurnitureShopEntities();

            Grof.ItemsSource = db.Furniture.ToList();
        }
        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            var q = Grof.SelectedItem as Furniture;
            if (q == null)
            {
                MessageBox.Show("Эта строка пуста.");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите сохранить?", "Сохранить?", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    db.Furniture.Add(q);
                    db.SaveChanges();
                    Grof.ItemsSource = db.Furniture.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }

            }
        }
    }
}
