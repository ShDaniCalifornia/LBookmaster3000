using LBookmaster3000.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LBookmaster3000.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCaralogWindow.xaml
    /// </summary>
    public partial class BrowseCaralogWindow : Window
    {
        public BrowseCaralogWindow()
        {
            InitializeComponent();

            // Загружаю данные из БД в ListView
            BookAuthorsLv.ItemsSource = App.context.Bookauthor.ToList();

            CountOfBooksTbl.DataContext = App.context.Book.ToList();

            // Выбираем элемент из списка по его индексу
            BookAuthorsLv.SelectedIndex = 0;

            // Прячем элементы меню
            LogoutMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Collapsed;


        }

        // Отслеживаем изменение выбора в ListView
        private void BookAuthorsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Загружаем в контекст данных Grid'a выбранный элемент из ListView (для реализации привязки элементов)
            BookDetailsGrid.DataContext = BookAuthorsLv.SelectedItem as Bookauthor; // as - как

        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            // Открываем окно в режиме диалогового
            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                LoginMi.Visibility = Visibility.Collapsed;
                LogoutMi.Visibility = Visibility.Visible;
                LibraryMi.Visibility = Visibility.Visible;
            }
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {
            // Открываем окно в режиме диалогового
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();

            LoginMi.Visibility = Visibility.Visible;
            LogoutMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Collapsed;
        }

        private void CLoseMi_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем текущее окно
            Close();
        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            Circulation circulation = new Circulation();
            circulation.Show();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsLv.ItemsSource = App.context.Bookauthor.Where(ba => ba.Book.Title.Contains(TitleTb.Text) && ba.Author.Lastname.Contains(AuthorTb.Text)).ToList();
        }

        private void AuthorHl_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsDetailsWindow bookAuthorsDetailsWindow = new BookAuthorsDetailsWindow(BookAuthorsLv.SelectedItem as Bookauthor);
            bookAuthorsDetailsWindow.ShowDialog();
        }

        private void TitleTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
