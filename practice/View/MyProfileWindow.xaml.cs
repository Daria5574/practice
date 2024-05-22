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
    /// Логика взаимодействия для MyProfileWindow.xaml
    /// </summary>
    public partial class MyProfileWindow : Window
    {
        public MyProfileWindow()
        {
            InitializeComponent();
        }
        private void DepositCategoresButton_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow();
            depositWindow.Show();
            Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainClientWindow mClW = new MainClientWindow();
            mClW.Show();
            Close();
        }
        public void sberImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.Show();
            Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // Обработать результат диалогового окна
            if (result == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
        }
    }
}
