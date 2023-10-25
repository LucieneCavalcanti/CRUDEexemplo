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
    public partial class Relatório : Form
    {
        private MySqlConnection conexao;

        public Relatório()
        {
            InitializeComponent();
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
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Center);
                listagem.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Início", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Final", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Categoria", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Status", 150, HorizontalAlignment.Left);
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
                                      dados.GetString(3), //pega a dataFinal
                                      dados.GetString(5), //pega a categoria 
                                      dados.GetString(6)}; //pega o status

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

        private void Relatório_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Center);
                listagem.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Início", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Final", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Categoria", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Status", 150, HorizontalAlignment.Left);
                string sql = "select * from tbTarefas " + "where status = '" + txtStatus.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = {dados.GetString(0), //pega o id
                                      dados.GetString(1), //pega a descrição
                                      dados.GetString(2), //pega a dataInício
                                      dados.GetString(3), //pega a dataFinal
                                      dados.GetString(5), //pega a categoria 
                                      dados.GetString(6)}; //pega o status

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

        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                String dataInicial = txtData.Value.Year + "-" + txtData.Value.Month + "-" + txtData.Value.Day;
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Center);
                listagem.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Início", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Data Final", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Categoria", 150, HorizontalAlignment.Left);
                listagem.Columns.Add("Status", 150, HorizontalAlignment.Left);
                string sql = "select * from tbTarefas " + "where dataInicio = '" + dataInicial + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = {dados.GetString(0), //pega o id
                                      dados.GetString(1), //pega a descrição
                                      dados.GetString(2), //pega a dataInício
                                      dados.GetString(3), //pega a dataFinal
                                      dados.GetString(5), //pega a categoria 
                                      dados.GetString(6)}; //pega o status

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
    }
}
