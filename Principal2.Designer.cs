namespace CRUDEexemplo
{
    partial class Principal2
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
            button1 = new Button();
            btSair = new Button();
            label1 = new Label();
            btTarefas = new Button();
            lblLogado = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(152, 83);
            button1.Name = "button1";
            button1.Size = new Size(123, 54);
            button1.TabIndex = 10;
            button1.Text = "Relatórios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btSair
            // 
            btSair.Location = new Point(438, 83);
            btSair.Name = "btSair";
            btSair.Size = new Size(123, 54);
            btSair.TabIndex = 9;
            btSair.Text = "Sair";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 8;
            label1.Text = "Menu";
            // 
            // btTarefas
            // 
            btTarefas.Location = new Point(294, 83);
            btTarefas.Name = "btTarefas";
            btTarefas.Size = new Size(123, 54);
            btTarefas.TabIndex = 6;
            btTarefas.Text = "Registrar Tarefas";
            btTarefas.UseVisualStyleBackColor = true;
            btTarefas.Click += btTarefas_Click;
            // 
            // lblLogado
            // 
            lblLogado.AutoSize = true;
            lblLogado.Location = new Point(12, 222);
            lblLogado.Name = "lblLogado";
            lblLogado.Size = new Size(38, 15);
            lblLogado.TabIndex = 11;
            lblLogado.Text = "label2";
            // 
            // Principal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 246);
            Controls.Add(lblLogado);
            Controls.Add(button1);
            Controls.Add(btSair);
            Controls.Add(label1);
            Controls.Add(btTarefas);
            Name = "Principal2";
            Text = "Principal2";
            Load += Principal2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btSair;
        private Label label1;
        private Button btTarefas;
        private Label lblLogado;
    }
}