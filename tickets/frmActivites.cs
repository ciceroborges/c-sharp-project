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
    public partial class frmActivites : Form
    {
        public frmActivites()
        {
            InitializeComponent();
        }

        

        private void frmActivites_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.locations'. Você pode movê-la ou removê-la conforme necessário.
            this.locationsTableAdapter.Fill(this.ticketsDataSet.locations);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.users'. Você pode movê-la ou removê-la conforme necessário.
            this.usersTableAdapter.Fill(this.ticketsDataSet.users);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.activites'. Você pode movê-la ou removê-la conforme necessário.
            this.activitesTableAdapter.Fill(this.ticketsDataSet.activites);

            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.activites'. Você pode movê-la ou removê-la conforme necessário.
            this.activitesTableAdapter.Fill(this.ticketsDataSet.activites);


        }

        private void activitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void activitesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void activitesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.activitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }
    }
}
