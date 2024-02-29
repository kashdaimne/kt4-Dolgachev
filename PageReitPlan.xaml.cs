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

namespace kt4
{
    /// <summary>
    /// Логика взаимодействия для PageReitPlan.xaml
    /// </summary>
    public partial class PageReitPlan : Page
    {
        public PageReitPlan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RP1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RP2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RP3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RP4());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RP5());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RP6());
        }
    }
}
