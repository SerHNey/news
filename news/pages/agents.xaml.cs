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
using System.Windows.Navigation;
using System.Windows.Shapes;
using news.manager;
namespace news.pages
{
    /// <summary>
    /// Логика взаимодействия для agents.xaml
    /// </summary>
    public partial class agents : Page
    {
        public agents()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            manag.MainFrame.Navigate(new pages.glavnai());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            manag.MainFrame.Navigate(new pages.editagents());
        }
    }
}
