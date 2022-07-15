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
using HHLibrary;

namespace HHProf
{
    /// <summary>
    /// Логика взаимодействия для WinTest.xaml
    /// </summary>
    public partial class WinTest : Window
    {
        HHModel model = new HHModel();

        public WinTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text =  model.RequestGet("https://api.hh.ru/vacancies?text=" + tbSearch.Text);

        }
    }
}
