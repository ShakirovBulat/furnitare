﻿using System;
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
            foreach (Shop row in Grof2.ItemsSource)
            {
                //get key
                int rowId = Convert.ToInt32(row.Id_Shop);

                //avoid updating the last empty row in datagrid
                if (rowId > 0)
                {
                    //delete 
                    Delete(rowId);

                    //refresh datagrid
                    Grof2.ItemsSource = db.Shop.ToList();
                }
            }
        }
        public void Delete(int rowId)
        {
            var td = db.Shop.First(c => c.Id_Shop == rowId);
            db.Shop.Remove(td);
            db.SaveChanges();

        }

        private void dwq_Copy_Click(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3();
            this.Close();
            p3.Show();
        }
    }
}