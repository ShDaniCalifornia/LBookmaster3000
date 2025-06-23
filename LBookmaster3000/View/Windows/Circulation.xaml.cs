using LBookmaster3000.Models;
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

namespace LBookmaster3000.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Circulation.xaml
    /// </summary>
    public partial class Circulation : Window
    {
        public Circulation()
        {
            InitializeComponent();

            CurrentIssuesLv.ItemsSource = App.context.Book.ToList();

            HistoryLv.ItemsSource = App.context.Book.ToList();
        }

        private void CirculationBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CLoseMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            //CurrentIssuesLv.ItemsSource = App.context.Bookauthor.Where(ba => ba.Book.Title.Contains(TitleTb.Text) && ba.Author.Lastname.Contains(AuthorTb.Text)).ToList();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentIssuesLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HistotyLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HistoryLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CustomerIDTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
