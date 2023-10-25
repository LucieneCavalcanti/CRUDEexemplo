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
    public partial class Principal2 : Form
    {   public Principal2() //construtor
        {
            InitializeComponent();
        }
        public Principal2(string nome, string tipo) //construtor
        {   InitializeComponent();
            lblLogado.Text = nome + " - " + tipo;
            if(tipo.Equals("Aluno"))
                btTarefas.Enabled = false; //ver no seu projeto
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Relatório frm = new Relatório();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btTarefas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarefa frm = new Tarefa();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal2_Load(object sender, EventArgs e)
        {

        }
    }
}
