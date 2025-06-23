using LBookmaster3000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace LBookmaster3000.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditCustomerWindow.xaml
    /// </summary>
    public partial class AddEditCustomerWindow : Window
    {
        public AddEditCustomerWindow()
        {
            InitializeComponent();

            AddBtn.Visibility = Visibility.Visible;
            SaveBtn.Visibility = Visibility.Collapsed;
        }
        public AddEditCustomerWindow(Customer selectedCustomer)
        {
            InitializeComponent();

            DataContext = selectedCustomer;

            AddBtn.Visibility = Visibility.Collapsed;
            SaveBtn.Visibility = Visibility.Visible;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // 1) Добавление записи в БД
                // Добавление записи в базу данных
                Customer newCustomer = new Customer()
                {
                    Name = NameTb.Text,
                    Address = AddressTb.Text,
                    Zip = Convert.ToInt32(ZipTb.Text),
                    City = CityTb.Text,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text
                };

                // 2) Добавляем объект в таблицу
                App.context.Customer.Add(newCustomer);

                // 3) Сохраняем изменения
                App.context.SaveChanges();
                
                // 4) Уведомить пользователя
                MessageBox.Show("Запись усппешно добавлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                DialogResult = true;
            }
            catch
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
