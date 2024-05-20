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
using System.Windows.Shapes;

namespace practice.View
{
    /// <summary>
    /// Логика взаимодействия для MainClientWindow.xaml
    /// </summary>
    public partial class MainClientWindow : Window
    {
        public class MyListItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public MainClientWindow()
        {
            InitializeComponent();

            var myList = new List<MyListItem>
             {
                 new MyListItem { Name = "Примерный элемент", Description = "Это описание для примера" }
             };

            // Привязка источника данных к ListView
            depositListView.ItemsSource = myList;
        }
        public void myProfileImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MyProfileWindow myProfWind = new MyProfileWindow();
            myProfWind.Show();
            Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainClientWindow mClW = new MainClientWindow();
            mClW.Show();
            Close();
        }
        private void DepositCategoresButton_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow();
            depositWindow.Show();
            Close();
        }
        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListViewItem listViewItem)
            {
                DepositDetailsWindow DepositDetailsW = new DepositDetailsWindow();
                DepositDetailsW.Show();
                Close();
            }
        }
    }
}

