using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEexemplo
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Código da Internet
        {
            this.Hide();
            Tarefa frm = new Tarefa();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e) //Código da Internet
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Relatório frm = new Relatório();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
