using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HHLibrary;

namespace API_HH
{
    public partial class fSearching : Form
    {

        HHModel newModel = new HHModel();
        public fSearching()
        {
            InitializeComponent();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            List<Vacancy> listVacancies = newModel.JsonParserResoutSearching(newModel.RequestGet("https://api.hh.ru/vacancies?text=" + tbSearch.Text));


            lblCount.Text = "Number of vacancies: " + listVacancies.Count().ToString();

            gvSearchingResults.Rows.Clear();

            foreach(Vacancy vacancy in listVacancies)
            {
                DataGridViewRow row = (DataGridViewRow)gvSearchingResults.Rows[0].Clone();

                row.Cells[0].Value = vacancy.id;
                row.Cells[1].Value = vacancy.name;
                row.Cells[2].Value = vacancy.salary_from;
                row.Cells[3].Value = vacancy.salary_to;
                row.Cells[4].Value = vacancy.employer_name;
                row.Cells[5].Value = vacancy.address;
                row.Cells[6].Value = vacancy.info;

                gvSearchingResults.Rows.Add(row);
            }

        }
    }
}
