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
    /// Логика взаимодействия для DepositDetailsWindow.xaml
    /// </summary>
    public partial class DepositDetailsWindow : Window
    {
        public DepositDetailsWindow()
        {
            InitializeComponent();
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

        private void MoneyButton_Click(object sender, RoutedEventArgs e)
        {
            BalanceManageWindow balanceManageWindow = new BalanceManageWindow();
            balanceManageWindow.Show();
            Close();
        }
        public void sberImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.Show();
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите закрыть данный счет?", "Подтверждение закрытия счета", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainClientWindow mainClientWindow = new MainClientWindow();
                mainClientWindow.Show();
                Close();
            }
        }
    }
}
