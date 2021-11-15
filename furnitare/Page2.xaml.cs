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
    public partial class Page2 : Window
    {
        public static Furniture_ShopEntities db = new Furniture_ShopEntities();
        public Page2()
        {
            InitializeComponent();
            db = new Furniture_ShopEntities();

            Grof.ItemsSource = db.Furniture.ToList();
        }
    }
}
