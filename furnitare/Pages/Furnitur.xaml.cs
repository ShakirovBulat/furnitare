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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Furnitur : Window
    {
        public static FurnitureShopEntities db = new FurnitureShopEntities();
        public Furnitur()
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

        private void ButtonDel(object sender, RoutedEventArgs e)
        {
            var q = Grof.SelectedItem as Furniture;
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
                    db.Furniture.Remove(q);
                    db.SaveChanges();
                    Grof.ItemsSource = db.Furniture.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
                
            }
            
        }

        private void wmBtn_Click(object sender, RoutedEventArgs e)
        {
            Sklud sk = new Sklud();
            this.Close();
            sk.Show();
        }
    }
}
