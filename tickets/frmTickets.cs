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
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.locations'. Você pode movê-la ou removê-la conforme necessário.
            this.locationsTableAdapter.Fill(this.ticketsDataSet.locations);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.requesters'. Você pode movê-la ou removê-la conforme necessário.
            this.requestersTableAdapter.Fill(this.ticketsDataSet.requesters);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.users'. Você pode movê-la ou removê-la conforme necessário.
            this.usersTableAdapter.Fill(this.ticketsDataSet.users);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.divisions'. Você pode movê-la ou removê-la conforme necessário.
            this.divisionsTableAdapter.Fill(this.ticketsDataSet.divisions);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.tickets'. Você pode movê-la ou removê-la conforme necessário.
            this.ticketsTableAdapter.Fill(this.ticketsDataSet.tickets);

        }

        private void tic_use_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.FillBy(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.FillBy1(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.FillBy2(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.FillBy3(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tickets_AbertosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.Tickets_Abertos(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tickets_FechadosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.Tickets_Fechados(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void abertosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.Abertos(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void todosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.Todos(this.ticketsDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
