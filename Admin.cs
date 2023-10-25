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
    public partial class Admin : Form
    {
        private MySqlConnection conexao;
        private String acao;

        public Admin()
        {
            InitializeComponent();
        }

        private void limparCampos() //método
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
        private void listagem_MouseUp(object sender, MouseEventArgs e)
        {
            int id = Int32.Parse(listagem.SelectedItems[0].Text.ToString());

            MySqlCommand comando = null;
            MySqlDataReader dados = null;

            try
            {
                comando = new MySqlCommand("select * from tbusuario where idUser=" + id, conexao);
                dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    txtID.Text = $"{dados["idUser"]}";
                    txtNome.Text = $"{dados["nome"]}";
                    txtEmail.Text = $"{dados["email"]}";
                    txtSenha.Text = $"{dados["senha"]}";
                    btEditar.Enabled = true;
                    btExcluir.Enabled = true;
                }
                else
                {
                    limparCampos();
                    MessageBox.Show("Não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dados.Close();
            comando = null;
        }

        private void btListarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("E-mail", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Senha", 100, HorizontalAlignment.Left);
                string sql = "select * from tbUsuario order by idUser"; //ou select idUser,nome,email,senha + from tbusuario order by descricao
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                //Estruturar os dados recebidos do mysql e mostrar ao usuário --- reader = leitor

                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = {dados.GetString(0), //pega o id
                                      dados.GetString(1), //pega a nome
                                      dados.GetString(2), //pega a email
                                      dados.GetString(3)}; //pega a senha

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listagem.Items.Add(estrutura_da_linha);
                }
                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void listagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
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

        private void btCancelar_Click(object sender, EventArgs e) //Código da Internet
        {
            this.Hide();
            Teste frm = new Teste();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
