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
    /// Логика взаимодействия для PageSotrud.xaml
    /// </summary>
    public partial class PageSotrud : Page
    {
        public PageSotrud()
        {
            InitializeComponent();
            DGridSotr.ItemsSource = KT4Entities2.GetContext().sotdurniki.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
