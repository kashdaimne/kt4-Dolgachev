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

namespace kt4
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageRaspisanie());
        }

        private void Btn_Plan_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageReitPlan());
        }

        private void Btn_Sotrud_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageSotrud());
        }

        private void Btn_MO_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageMO());
        }

        private void Btn_DO_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageDO());
        }
    }
}
