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
        public static Furniture_ShopEntities db = new Furniture_ShopEntities();
        public Page4()
        {
            InitializeComponent();
            db = new Furniture_ShopEntities();

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
                db.Shop.Remove(q);
                db.SaveChanges();
                Grof2.ItemsSource = db.Shop.ToList();
            }
            //try
            //{
            //    if (Grof2.SelectedItems.Count > 0)
            //    {
            //        for (int i = Grof2.SelectedItems.Count - 1; i >= 0; i--)
            //        {
            //            DataRowView rowView = Grof2.SelectedItems[i] as DataRowView;

            //            foreach (DataRow row in Grof2.Row)
            //            {
            //                if (row["Name"].ToString() == rowView.Row["Name"].ToString())
            //                    row.Delete(); // Помечаем строку на удаление
            //            }
            //        }
            //        dataTable.AcceptChanges(); // Фиксируем изменения внесенные в DataTable
            //        dataAdapter.Update(dataTable);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ошибка в функции Button_DeleteSelectedMark_Click!\n\n" + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        } // Конец функции Button_DeleteSelectedMark_Click
        //    foreach (Shop row in Grof2.ItemsSource)
        //    {
        //        //get key
        //        int rowId = Convert.ToInt32(row.Id_Shop);

        //        //avoid updating the last empty row in datagrid
        //        if (rowId > 0)
        //        {
        //            //delete 
        //            Delete(rowId);

        //            //refresh datagrid
        //            Grof2.ItemsSource = db.Shop.ToList();
        //        }
        //    }
        //}
        //public void Delete(int rowId)
        //{
        //    var td = db.Shop.First(c => c.Id_Shop == rowId);
        //    db.Shop.Remove(td);
        //    db.SaveChanges();

        //}

        private void dwq_Copy_Click(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3();
            this.Close();
            p3.Show();
        }
    }
}
