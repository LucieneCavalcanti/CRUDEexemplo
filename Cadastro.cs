using MySql.Data.MySqlClient;
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
    public partial class Cadastro : Form
    {
        private MySqlConnection conexao;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost;" + "user=root;" + "database=bdExemploCrud";
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = null;

            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo 'nome' deve ser preenchido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo de 'email' não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo de 'senha' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text.Length < 5)
            {
                MessageBox.Show("O campo de 'senha' deve conter mais do que 5 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //pode gravar
            {
                comando = new MySqlCommand(
                    "insert into tbUsuario (nome, email, senha)" +
                    "values ('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtSenha.Text + "')", conexao);
                var dados = comando.ExecuteReader();
                dados.Close();
                MessageBox.Show("Cadastro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limparCampos();
                conexao.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e) //Código da Internet
        {
            limparCampos();
            this.Hide();
            Login frm = new Login();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btListarTodos_Click(object sender, EventArgs e)
        {

        }

        private void listagem_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblPesquisa_Click(object sender, EventArgs e)
        {
        }

        private void txtID_Click(object sender, EventArgs e)
        {
        }

        private void listagem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
        }
    }
}
