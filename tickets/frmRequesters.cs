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
    public partial class frmRequesters : Form
    {
        public frmRequesters()
        {
            InitializeComponent();
        }

       
        private void frmRequesters_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.locations'. Você pode movê-la ou removê-la conforme necessário.
            this.locationsTableAdapter.Fill(this.ticketsDataSet.locations);
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.requesters'. Você pode movê-la ou removê-la conforme necessário.
            this.requestersTableAdapter.Fill(this.ticketsDataSet.requesters);



        }

        private void requestersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }
    }
}
