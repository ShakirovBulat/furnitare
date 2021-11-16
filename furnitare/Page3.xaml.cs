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
        public static Furniture_ShopEntities db = new Furniture_ShopEntities();
        public Page3()
        {
            InitializeComponent();
            db = new Furniture_ShopEntities();

            Grof1.ItemsSource = db.Sklad.ToList();
        }
        private void red_Click(object sender, RoutedEventArgs e)
        {
            foreach (Sklad row in Grof1.ItemsSource)
            {
                //get key
                int rowId = Convert.ToInt32(row.Id_Sklad);

                //avoid updating the last empty row in datagrid
                if (rowId > 0)
                {
                    //delete 
                    Delete(rowId);

                    //refresh datagrid
                    Grof1.ItemsSource = db.Sklad.ToList();
                }
            }
        }
        public void Delete(int rowId)
        {
            var tdd = db.Sklad.First(c => c.Id_Sklad == rowId);
            db.Sklad.Remove(tdd);
            db.SaveChanges();

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
