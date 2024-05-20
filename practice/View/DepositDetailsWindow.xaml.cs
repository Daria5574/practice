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
    }
}
