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
{    public partial class Login : Form
    {        private MySqlConnection conexao;

        public Login()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost;" + "user=root;" + 
                    "database=bdExemploCrud";
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Código da Internet
        {
            this.Hide();
            Cadastro frm = new Cadastro();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = null;
            MySqlDataReader dados = null;

            try
            {   comando = new MySqlCommand("select * from tbusuario where email='" 
                    + txtAcesso.Text + "' and senha='" + txtSenha.Text +  "'", conexao);
                dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("Acesso ok");
                    int id = Int32.Parse($"{dados["idUser"]}");
                    string nome =  $"{dados["nome"]}";
                    string tipo = $"{dados["tipo"]}";
                    MessageBox.Show("Bem vindo(a) " + nome);
                    this.Hide();
                    new Principal2(nome,tipo).Show();
                }
                else
                {
                    MessageBox.Show("Acesso Negado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dados.Close();
            comando = null;

            //Adaptação a partir do Chat GPT

            /*string user = txtAcesso.Text;
            string senha = txtSenha.Text;
            string pesquisa = "SELECT COUNT(*) FROM tbUsuario WHERE email = @email AND senha = @senha";

            try
            {

                using (MySqlCommand cmd = new MySqlCommand(pesquisa, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", user);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int count = Convert.ToInt32(result);

                        if (count > 0)
                        {
                            MessageBox.Show("Login bem-sucedido!");

                            if (txtSenha.Text == "admin") //sim, eu sei, estranho né? liga não
                            {
                                this.Hide();
                                Principal2 frm = new Principal2(); 
                                frm.Closed += (s, args) => this.Close();
                                frm.Show();
                            }
                            else
                            {
                                this.Hide();
                                Principal2 frm = new Principal2();
                                frm.Closed += (s, args) => this.Close();
                                frm.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas. Tente novamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }*/
        }
    }
}
