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
using System.Windows.Shapes;

namespace practice.View
{
    /// <summary>
    /// Логика взаимодействия для BalanceManageWindow.xaml
    /// </summary>
    public partial class BalanceManageWindow : Window
    {
        public BalanceManageWindow()
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
        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0) || e.Text == "." || e.Text == ",")
            {
                if ((e.Text == "." || e.Text == ",") && ((sender as TextBox).Text.Contains(".") || (sender as TextBox).Text.Contains(",")))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пополнение прошло успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            DepositDetailsWindow depositDetailsWindow = new DepositDetailsWindow();
            depositDetailsWindow.Show();
            Close();
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Снятие средств прошло успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            DepositDetailsWindow depositDetailsWindow = new DepositDetailsWindow();
            depositDetailsWindow.Show();
            Close();
        }
        public void sberImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.Show();
            Close();
        }
    }
}
