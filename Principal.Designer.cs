namespace CRUDEexemplo
{
    partial class Teste
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
            btTarefas = new Button();
            label1 = new Label();
            btSair = new Button();
            button1 = new Button();
            btCadastro = new Button();
            SuspendLayout();
            // 
            // btTarefas
            // 
            btTarefas.Location = new Point(217, 83);
            btTarefas.Name = "btTarefas";
            btTarefas.Size = new Size(123, 54);
            btTarefas.TabIndex = 1;
            btTarefas.Text = "Registrar Tarefas";
            btTarefas.UseVisualStyleBackColor = true;
            btTarefas.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // btSair
            // 
            btSair.Location = new Point(509, 83);
            btSair.Name = "btSair";
            btSair.Size = new Size(123, 54);
            btSair.TabIndex = 4;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // button1
            // 
            button1.Location = new Point(75, 83);
            button1.Name = "button1";
            button1.Size = new Size(123, 54);
            button1.TabIndex = 5;
            button1.Text = "Relatórios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btCadastro
            // 
            btCadastro.Location = new Point(363, 83);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(123, 54);
            btCadastro.TabIndex = 2;
            btCadastro.Text = "Administrar Cadastros";
            btCadastro.UseVisualStyleBackColor = true;
            btCadastro.Click += button3_Click;
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 168);
            Controls.Add(button1);
            Controls.Add(btSair);
            Controls.Add(label1);
            Controls.Add(btCadastro);
            Controls.Add(btTarefas);
            Name = "Teste";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btTarefas;
        private Label label1;
        private Button btSair;
        private Button button1;
        private Button btCadastro;
    }
}