namespace CRUDEexemplo
{
    partial class Cadastro
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
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            btCadastrar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(253, 36);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(253, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(253, 150);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(385, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(83, 168);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(385, 23);
            txtSenha.TabIndex = 4;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 23);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(137, 211);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(111, 41);
            btCadastrar.TabIndex = 6;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += button1_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(297, 211);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(111, 41);
            btCancelar.TabIndex = 7;
            btCancelar.Text = "Voltar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 294);
            Controls.Add(btCancelar);
            Controls.Add(btCadastrar);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btCadastrar;
        private Button btCancelar;
    }
}