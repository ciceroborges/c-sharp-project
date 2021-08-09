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
    public partial class frmRelActivites : Form
    {
        public frmRelActivites()
        {
            InitializeComponent();
        }

        private void frmRelActivites_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ticketsDataSet.vw_activites'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_activitesTableAdapter.Fill(this.ticketsDataSet.vw_activites);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
