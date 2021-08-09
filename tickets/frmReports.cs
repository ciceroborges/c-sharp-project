using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using tickets.ticketsDataSetTableAdapters;
using Microsoft.Reporting.WinForms;

namespace tickets
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.vw_tickets'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_ticketsTableAdapter.Fill(this.ticketsDataSet.vw_tickets);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.divisions'. Você pode movê-la ou removê-la conforme necessário.
            this.divisionsTableAdapter.Fill(this.ticketsDataSet.divisions);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.requesters'. Você pode movê-la ou removê-la conforme necessário.
            this.requestersTableAdapter.Fill(this.ticketsDataSet.requesters);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.vw_activites'. Você pode movê-la ou removê-la conforme necessário.
            //this.vw_activitesTableAdapter.Fill(this.ticketsDataSet.vw_activites);

            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.locations'. Você pode movê-la ou removê-la conforme necessário.
            this.locationsTableAdapter.Fill(this.ticketsDataSet.locations);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.users'. Você pode movê-la ou removê-la conforme necessário.
            this.usersTableAdapter.Fill(this.ticketsDataSet.users);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.activites'. Você pode movê-la ou removê-la conforme necessário.
            this.activitesTableAdapter.Fill(this.ticketsDataSet.activites);



            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketsDataSetTableAdapters.vw_activitesTableAdapter adapter = new ticketsDataSetTableAdapters.vw_activitesTableAdapter();
            ticketsDataSet.vw_activitesDataTable table = new ticketsDataSet.vw_activitesDataTable();
            
            string tecnico = comboBox1.Text;
            string setor = comboBox2.Text;
            DateTime data_inicial = dateTimePicker1.Value;
            DateTime data_final = dateTimePicker2.Value;

            adapter.FillByTecnico(table, tecnico, setor, data_inicial, data_final);

            ReportDataSource MyNewDataSource = new ReportDataSource("DataSetRelActivites", (DataTable)table);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ticketsDataSetTableAdapters.vw_ticketsTableAdapter adapter1 = new ticketsDataSetTableAdapters.vw_ticketsTableAdapter();
            ticketsDataSet.vw_ticketsDataTable view = new ticketsDataSet.vw_ticketsDataTable();

            string divisao = comboBox5.Text;
            string situacao = comboBox4.Text;
            string solicitante = comboBox3.Text;

            adapter1.FillByTickets(view, situacao, divisao, solicitante);

            ReportDataSource NewDataSource = new ReportDataSource("DataSetRelTickets", (DataTable)view);

            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(NewDataSource);
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
