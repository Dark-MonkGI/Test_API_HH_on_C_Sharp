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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            HHModel model = new HHModel();
            tbResult.Text =  model.RequestGet("https://api.hh.ru/vacancies/67344660");

            //https://github.com/hhru/api
        }
    }
}
