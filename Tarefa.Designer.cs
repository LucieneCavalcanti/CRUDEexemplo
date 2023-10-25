namespace CRUDEexemplo
{
    partial class Tarefa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDescricao = new TextBox();
            txtResponsavel = new TextBox();
            txtObservacoes = new RichTextBox();
            txtCategoria = new ComboBox();
            txtStatus = new ComboBox();
            jlId = new Label();
            txtDataInicial = new DateTimePicker();
            txtDataFinal = new DateTimePicker();
            btNovo = new Button();
            btSalvar = new Button();
            btCancelar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            label10 = new Label();
            label11 = new Label();
            listagem = new ListView();
            btListarTodos = new Button();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            btVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 133);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 132);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 194);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Nome do Responsável";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 247);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 191);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 6;
            label7.Text = "Observações";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 300);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Status";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(62, 93);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(658, 23);
            txtDescricao.TabIndex = 8;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Enabled = false;
            txtResponsavel.Location = new Point(62, 212);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(317, 23);
            txtResponsavel.TabIndex = 9;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Enabled = false;
            txtObservacoes.Location = new Point(429, 212);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(291, 129);
            txtObservacoes.TabIndex = 10;
            txtObservacoes.Text = "";
            // 
            // txtCategoria
            // 
            txtCategoria.Enabled = false;
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Items.AddRange(new object[] { "Doméstica", "Escola", "Lazer", "Pessoal", "Trabalho", "Viagens", "Outros" });
            txtCategoria.Location = new Point(62, 265);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(317, 23);
            txtCategoria.TabIndex = 11;
            txtCategoria.Text = "-- Escolha uma opção --";
            txtCategoria.SelectedIndexChanged += txtCategoria_SelectedIndexChanged;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "Nova", "Em andamento", "Atrasada", "Cancelada", "Concluída" });
            txtStatus.Location = new Point(62, 318);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(317, 23);
            txtStatus.TabIndex = 12;
            txtStatus.Text = "-- Escolha uma opção --";
            // 
            // jlId
            // 
            jlId.AutoSize = true;
            jlId.BackColor = SystemColors.ButtonHighlight;
            jlId.BorderStyle = BorderStyle.FixedSingle;
            jlId.Location = new Point(86, 45);
            jlId.Name = "jlId";
            jlId.Size = new Size(15, 17);
            jlId.TabIndex = 13;
            jlId.Text = "0";
            jlId.Click += label9_Click;
            // 
            // txtDataInicial
            // 
            txtDataInicial.Enabled = false;
            txtDataInicial.Location = new Point(62, 150);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(317, 23);
            txtDataInicial.TabIndex = 14;
            txtDataInicial.ValueChanged += txtDataInicial_ValueChanged;
            // 
            // txtDataFinal
            // 
            txtDataFinal.Enabled = false;
            txtDataFinal.Location = new Point(429, 150);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(291, 23);
            txtDataFinal.TabIndex = 15;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(73, 370);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(89, 38);
            btNovo.TabIndex = 16;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Location = new Point(183, 370);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(89, 38);
            btSalvar.TabIndex = 17;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Enabled = false;
            btCancelar.Location = new Point(291, 370);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(89, 38);
            btCancelar.TabIndex = 18;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(400, 370);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(89, 38);
            btEditar.TabIndex = 19;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Location = new Point(508, 370);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(89, 38);
            btExcluir.TabIndex = 20;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 75);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 21;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(124, 133);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 22;
            label11.Text = "*";
            // 
            // listagem
            // 
            listagem.Location = new Point(764, 133);
            listagem.Name = "listagem";
            listagem.Size = new Size(509, 275);
            listagem.TabIndex = 23;
            listagem.UseCompatibleStateImageBehavior = false;
            listagem.SelectedIndexChanged += listagem_SelectedIndexChanged;
            listagem.MouseUp += listagem_MouseUp;
            // 
            // btListarTodos
            // 
            btListarTodos.Location = new Point(1172, 93);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(101, 23);
            btListarTodos.TabIndex = 24;
            btListarTodos.Text = "Listar Todos";
            btListarTodos.UseVisualStyleBackColor = true;
            btListarTodos.Click += button1_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(764, 93);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(402, 23);
            txtPesquisa.TabIndex = 26;
            txtPesquisa.TextChanged += textBox1_TextChanged;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(764, 75);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(53, 15);
            lblPesquisa.TabIndex = 25;
            lblPesquisa.Text = "Pesquisa";
            lblPesquisa.Click += label12_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(616, 370);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(89, 38);
            btVoltar.TabIndex = 27;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // Tarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 450);
            Controls.Add(btVoltar);
            Controls.Add(txtPesquisa);
            Controls.Add(lblPesquisa);
            Controls.Add(btListarTodos);
            Controls.Add(listagem);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btNovo);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicial);
            Controls.Add(jlId);
            Controls.Add(txtStatus);
            Controls.Add(txtCategoria);
            Controls.Add(txtObservacoes);
            Controls.Add(txtResponsavel);
            Controls.Add(txtDescricao);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tarefa";
            Text = "Registro de Tarefa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDescricao;
        private TextBox txtResponsavel;
        private RichTextBox txtObservacoes;
        private ComboBox txtCategoria;
        private Label jlId;
        private DateTimePicker txtDataInicial;
        private DateTimePicker txtDataFinal;
        private Button btNovo;
        private Button btSalvar;
        private Button btCancelar;
        private Button btEditar;
        private Button btExcluir;
        private ComboBox txtStatus;
        private Label label10;
        private Label label11;
        private ListView listagem;
        private Button btListarTodos;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
        private Button btVoltar;
    }
}