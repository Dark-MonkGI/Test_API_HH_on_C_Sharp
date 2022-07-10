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
using HHLibrary;

namespace BotWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HHModel newModel = new HHModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Items.Clear();


            List<Vacancy> listVacancies = newModel.JsonParserResoutSearching(newModel.RequestGet("https://api.hh.ru/vacancies?text=" + tbSearch.Text));


            //lblCount.Text = "Number of vacancies: " + listVacancies.Count().ToString();

            //gvSearchingResults.Rows.Clear();

            foreach (Vacancy vacancy in listVacancies)
            {
                lbResult.Items.Add(vacancy.id + " " + vacancy.name);

                //DataGridViewRow row = (DataGridViewRow)gvSearchingResults.Rows[0].Clone();

                //row.Cells[0].Value = vacancy.id;
                //row.Cells[1].Value = vacancy.name;
                //row.Cells[2].Value = vacancy.salary_from;
                //row.Cells[3].Value = vacancy.salary_to;
                //row.Cells[4].Value = vacancy.employer_name;
                //row.Cells[5].Value = vacancy.address;
                //row.Cells[6].Value = vacancy.info;

                //gvSearchingResults.Rows.Add(row);
            }

        }
    }
}
