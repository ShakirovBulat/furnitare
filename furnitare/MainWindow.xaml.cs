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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = " ";

            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

            allowchar += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            String[] ar = allowchar.Split(a);

            String pwd = " ";

            string temp = " ";

            Random r = new Random();



            for (int i = 0; i < 6; i++)

            {

                temp = ar[(r.Next(0, ar.Length))];



                pwd += temp;

            }



            t4.Text = pwd;
        }
        private void register_Click(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            this.Close();
            p1.Show();
        }

        
        private void login_Click(object sender, RoutedEventArgs e)
        {
            ////try
            ////{
            ////    if (t1.Text != "" && t2.Text != "")
            ////    {
            ////        string query = "select id,username,password,firstname,lastname,address from user WHERE username ='" + t1.Text + "' AND password ='" + t1.Text + "'";
            ////        Shop row;
            ////        row = con.ExecuteReader(query);
            ////        if (row.HasRows)
            ////        {
            ////            while (row.Read())
            ////            {
            ////                id = row["id"].ToString();
            ////                username = row["username"].ToString();
            ////                password = row["password"].ToString();
            ////                firstname = row["firstname"].ToString();
            ////                lastname = row["lastname"].ToString();
            ////                address = row["address"].ToString();
            ////            }
            ////            MessageBox.Show("Data found your name is " + firstname + " " + lastname + " " + " and your address at " + address);
            ////        }
            ////        else
            ////        {
            ////            MessageBox.Show("Data not found", "Information");
            ////        }
            ////    }
            ////    else
            ////    {
            ////        MessageBox.Show("Username or Password is empty", "Information");
            ////    }
            ////}
            ////catch
            ////{
            ////    MessageBox.Show("Connection Error", "Information");
            ////}
            //if (t1.Text.Length > 0) // проверяем введён ли логин
            //{
            //    if (t2.Text.Length > 0) // проверяем введён ли пароль
            //    {
            //        Sotrudnik dt_user = Sotrudnik.Select("SELECT * FROM [dbo].[Sotrudnik] WHERE [Id_Sotrudnik] = '" + t1.Text + "' AND [Фамилия] = '" + t2.Text + "'");
            //        if (dt_user.Shop.Count > 0) // если такая запись существует       
            //        {
            //            MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался         
            //        }
            //        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
            //    }
            //    else MessageBox.Show("Введите пароль"); // выводим ошибку    
            //}
            //else MessageBox.Show("Введите логин"); // выводим ошибку 
        }
    }
}
