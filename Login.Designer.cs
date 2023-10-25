namespace CRUDEexemplo
{
    partial class Login
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
            btSair = new Button();
            btEntrar = new Button();
            txtAcesso = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // btSair
            // 
            btSair.Location = new Point(396, 182);
            btSair.Name = "btSair";
            btSair.Size = new Size(128, 44);
            btSair.TabIndex = 15;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // btEntrar
            // 
            btEntrar.Location = new Point(89, 182);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(128, 44);
            btEntrar.TabIndex = 14;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // txtAcesso
            // 
            txtAcesso.Location = new Point(111, 66);
            txtAcesso.Name = "txtAcesso";
            txtAcesso.Size = new Size(385, 23);
            txtAcesso.TabIndex = 13;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(111, 129);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(385, 23);
            txtSenha.TabIndex = 12;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(281, 111);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 10;
            lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(281, 48);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblEmail_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 277);
            Controls.Add(btSair);
            Controls.Add(btEntrar);
            Controls.Add(txtAcesso);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Name = "Login";
            Text = "Login";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSair;
        private Button btEntrar;
        private TextBox txtAcesso;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblEmail;
    }
}