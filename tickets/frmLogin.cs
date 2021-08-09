using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading;

namespace tickets
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new frmSplash());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //botao entrar
            string login = textBox1.Text;
            string senha = textBox2.Text;
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=g2;Integrated Security=True");
            SqlDataAdapter query = new SqlDataAdapter("select count(*) from users where use_cpf = '" + login + "' and use_password = '" + senha + "'", conn);
            DataTable data = new DataTable();
            query.Fill(data);

            if (data.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuário inválido! Verifique as informações e tente novamente");
            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //botao sair
            this.Close();
        }
    }
}
