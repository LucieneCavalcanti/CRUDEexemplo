namespace CRUDEexemplo
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new Label();
            lblID = new Label();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            btListarTodos = new Button();
            listagem = new ListView();
            btExcluir = new Button();
            btEditar = new Button();
            btVoltar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.BackColor = SystemColors.ButtonHighlight;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(93, 62);
            txtID.Name = "txtID";
            txtID.Size = new Size(15, 17);
            txtID.TabIndex = 48;
            txtID.Text = "0";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(60, 62);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 47;
            lblID.Text = "ID:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(681, 56);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(340, 23);
            txtPesquisa.TabIndex = 46;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(619, 59);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(56, 15);
            lblPesquisa.TabIndex = 45;
            lblPesquisa.Text = "Pesquisa:";
            // 
            // btListarTodos
            // 
            btListarTodos.Location = new Point(1027, 55);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(101, 23);
            btListarTodos.TabIndex = 44;
            btListarTodos.Text = "Listar Todos";
            btListarTodos.UseVisualStyleBackColor = true;
            btListarTodos.Click += btListarTodos_Click;
            // 
            // listagem
            // 
            listagem.Location = new Point(619, 98);
            listagem.Name = "listagem";
            listagem.Size = new Size(509, 173);
            listagem.TabIndex = 43;
            listagem.UseCompatibleStateImageBehavior = false;
            listagem.SelectedIndexChanged += listagem_SelectedIndexChanged;
            listagem.MouseUp += listagem_MouseUp;
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Location = new Point(218, 231);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(111, 40);
            btExcluir.TabIndex = 42;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(81, 230);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(111, 41);
            btEditar.TabIndex = 41;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(355, 230);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(111, 41);
            btVoltar.TabIndex = 40;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 23);
            txtEmail.TabIndex = 38;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(93, 181);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(385, 23);
            txtSenha.TabIndex = 37;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(385, 23);
            txtNome.TabIndex = 36;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(39, 184);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 35;
            lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(39, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "E-mail:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(39, 101);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 33;
            lblNome.Text = "Nome:";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 331);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(txtPesquisa);
            Controls.Add(lblPesquisa);
            Controls.Add(btListarTodos);
            Controls.Add(listagem);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btVoltar);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtID;
        private Label lblID;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
        private Button btListarTodos;
        private ListView listagem;
        private Button btExcluir;
        private Button btEditar;
        private Button btVoltar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Label lblSenha;
        private Label lblEmail;
        private Label lblNome;
    }
}