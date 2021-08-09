using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tickets
{
    public partial class frmCharts : Form
    {
        public frmCharts()
        {
            InitializeComponent();
        }

        private void frmCharts_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'chartDataSet.tickets'. Você pode movê-la ou removê-la conforme necessário.
            this.ticketsTableAdapter1.Fill(this.chartDataSet.tickets);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.activites'. Você pode movê-la ou removê-la conforme necessário.
            this.activitesTableAdapter.Fill(this.ticketsDataSet.activites);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.tickets'. Você pode movê-la ou removê-la conforme necessário.
            this.ticketsTableAdapter.Fill(this.ticketsDataSet.tickets);


        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
