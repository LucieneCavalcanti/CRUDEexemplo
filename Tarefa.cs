using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace CRUDEexemplo
{
    public partial class Tarefa : Form
    {
        private MySqlConnection conexao;
        private String acao;

        public Tarefa()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarCampos();
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            acao = "novo";
        }

        private void limparCampos() //método
        {
            txtDescricao.Text = string.Empty;
            txtResponsavel.Text = string.Empty;
            txtDataInicial.Text = string.Empty;
            txtDataFinal.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtObservacoes.Text = string.Empty;
        }

        private void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtResponsavel.Enabled = true;
            txtDataInicial.Enabled = true;
            txtDataFinal.Enabled = true;
            txtCategoria.Enabled = true;
            txtStatus.Enabled = true;
            txtObservacoes.Enabled = true;
        }

        private void desabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtResponsavel.Enabled = false;
            txtDataInicial.Enabled = false;
            txtDataFinal.Enabled = false;
            txtCategoria.Enabled = false;
            txtStatus.Enabled = false;
            txtObservacoes.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
            btNovo.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = null;

            if (txtDescricao.Text.Length < 5)
            {
                MessageBox.Show("O campo descrição deve conter, pelo menos, 5 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDataInicial.Text.Length < 10)
            {
                MessageBox.Show("O campo de data inicial não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //pode gravar
            {
                String dataInicial = txtDataInicial.Value.Year + "-" + txtDataInicial.Value.Month + "-" + txtDataInicial.Value.Day;
                String dataFinal = txtDataFinal.Value.Year + "-" + txtDataFinal.Value.Month + "-" + txtDataFinal.Value.Day;

                if (acao.Equals("novo"))
                {
                    comando = new MySqlCommand(
                        "insert into tbTarefas (descricao, dataInicio, dataFinal, nomeResponsavel, categoria, status, observacoes)" +
                        "values ('" + txtDescricao.Text + "','" + dataInicial + "','" + dataFinal + "','" + txtResponsavel.Text + "','" + txtCategoria.Text + "','" + txtStatus.Text + "','" + txtObservacoes.Text + "')", conexao);
                }
                else if (acao.Equals("editar"))
                {
                    comando = new MySqlCommand(
                        "update tbTarefas set descricao='" + txtDescricao.Text + "', dataInicio='" + dataInicial + "', dataFinal='" + dataFinal + "', nomeResponsavel='" + txtResponsavel.Text + "', categoria='" + txtCategoria.Text + "', status='" + txtStatus.Text + "', observacoes='" + txtObservacoes.Text + "' where id=" + jlId.Text, conexao);
                }
                var dados = comando.ExecuteReader();
                dados.Close();
                MessageBox.Show("Tarefa salva com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limparCampos();
                desabilitarCampos();
                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
            }
        }

        private void txtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Início", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
                string sql = "select * from tbTarefas order by descricao"; //ou select id,descricao,dataInicio,categoria + from tbTarefas order by descricao
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                //Estruturar os dados recebidos do mysql e mostrar ao usuário --- reader = leitor

                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = {dados.GetString(0), //pega o id
                                      dados.GetString(1), //pega a descrição
                                      dados.GetString(2), //pega a dataInício
                                      dados.GetString(5)}; //pega a categoria -- caso mudar o select ^ = mude de "5" pra "3"

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void listagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listagem_MouseUp(object sender, MouseEventArgs e)
        {
            int id = Int32.Parse(listagem.SelectedItems[0].Text.ToString());

            MySqlCommand comando = null;
            MySqlDataReader dados = null;

            try
            {
                comando = new MySqlCommand("select * from tbtarefas where id=" + id, conexao);
                dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    jlId.Text = $"{dados["id"]}";
                    txtDescricao.Text = $"{dados["descricao"]}";
                    txtResponsavel.Text = $"{dados["nomeResponsavel"]}";
                    txtCategoria.Text = $"{dados["categoria"]}";
                    txtStatus.Text = $"{dados["status"]}";
                    txtDataInicial.Text = $"{dados["dataInicio"]}";
                    txtObservacoes.Text = $"{dados["observacoes"]}";
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            btNovo.Enabled = false;
            acao = "editar";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(jlId.Text.ToString());

            MySqlCommand comando = null;
            MySqlDataReader dados = null;

            try
            {
                comando = new MySqlCommand("delete from tbtarefas where id=" + id, conexao);
                dados = comando.ExecuteReader();

                MessageBox.Show("Tarefa excluída com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limparCampos();
                desabilitarCampos();
                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dados.Close();
            comando = null;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal2 frm = new Principal2();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void txtDataInicial_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}