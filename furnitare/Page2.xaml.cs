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
        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            //var newZakaz = new Furniture();
            //db.Furniture.Add(newZakaz);
            //var x = new (db, newZakaz);
            //x.ShowDialog();
            //Grof.ItemsSource = db.Furniture.ToList();
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
                db.Furniture.Remove(q);
                db.SaveChanges();
                Grof.ItemsSource = db.Furniture.ToList();
            }
            //foreach (Furniture row in Grof.ItemsSource)
            //{
            //    //get key
            //    int rowId = Convert.ToInt32(row.Id_Furniture);

            //    //avoid updating the last empty row in datagrid
            //    if (rowId > 0)
            //    {
            //        //delete 
            //        Delete(rowId);

            //        //refresh datagrid
            //        Grof.ItemsSource = db.Furniture.ToList();
            //    }
            //}
        }
        //public void Delete(int rowId)
        //{
        //    var toBeDeleted = db.Furniture.First(c => c.Id_Furniture == rowId);
        //    db.Furniture.Remove(toBeDeleted);
        //    db.SaveChanges();

        //}

        private void wmBtn_Click(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3();
            this.Close();
            p3.Show();
        }
    }
}
