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
    public partial class frmLocations : Form
    {
        public frmLocations()
        {
            InitializeComponent();
        }

        private void locationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketsDataSet);

        }

        private void frmLocations_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.locations'. Você pode movê-la ou removê-la conforme necessário.
            this.locationsTableAdapter.Fill(this.ticketsDataSet.locations);

        }
    }
}
