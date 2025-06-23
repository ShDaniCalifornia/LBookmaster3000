using LBookmaster3000.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LBookmaster3000.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookAuthorsDetailsWindow.xaml
    /// </summary>
    public partial class BookAuthorsDetailsWindow : Window
    {
        public BookAuthorsDetailsWindow(Bookauthor bookAuthor)
        {
            InitializeComponent();
            AuthorsCmb.ItemsSource = App.context.Bookauthor.Where(ba => ba.bookid == bookAuthor.bookid).ToList(); // ba - предикат
            DataContext = AuthorsCmb.SelectedItem = bookAuthor;
        }

        private void AuthorDateHl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AuthorsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // в контекст данных окна передаем выбранный элемент из выпадающего списка. Сам элемент приводит к типу Bookauthor.
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Открываем браузер по умолчанию, передавая в него абсолютную ссылку
            // на веб-страницу и "разрешает открытие" веб-страницы
            try
            {
                Process.Start(e.Uri.AbsoluteUri);
                e.Handled = true;
            }
            catch
            {
                MessageBox.Show("Невозможно открыть сайт");
            }
        }
    }
}
