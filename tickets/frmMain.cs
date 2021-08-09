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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivites frm = new frmActivites();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTickets frm = new frmTickets();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDivisions frm = new frmDivisions();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRequesters frm = new frmRequesters();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocations frm = new frmLocations();
            frm.ShowDialog();
            frm.Dispose();
        }
        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuide frm = new frmGuide();
            frm.ShowDialog();
            frm.Dispose();
        }
        private void estatísticasF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCharts frm = new frmCharts();
            frm.ShowDialog();
            frm.Dispose();
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
            frm.Dispose();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    atividadesToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F2:
                    ticketsToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F3:
                    produtoToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F4:
                    marcaToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F5:
                    fornecedorToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F6:
                    usersToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F7:
                    relatóriosToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F8:
                    estatísticasF8ToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F9:
                    manualToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F10:
                    sobreToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F12:
                    sairToolStripMenuItem_Click(sender, e);
                    break;

            }
        }

      
    }
        
    }
