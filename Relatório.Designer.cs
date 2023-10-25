namespace CRUDEexemplo
{
    partial class Relatório
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
            listagem = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStatus = new ComboBox();
            txtData = new DateTimePicker();
            btListarTodos = new Button();
            SuspendLayout();
            // 
            // listagem
            // 
            listagem.Location = new Point(60, 181);
            listagem.Name = "listagem";
            listagem.Size = new Size(793, 234);
            listagem.TabIndex = 0;
            listagem.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 42);
            label1.Name = "label1";
            label1.Size = new Size(184, 56);
            label1.TabIndex = 1;
            label1.Text = "TAREFAS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 142);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Filtrar por Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 142);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "Filtrar por Data:";
            // 
            // txtStatus
            // 
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "Nova", "Em andamento", "Atrasada", "Cancelada", "Concluída" });
            txtStatus.Location = new Point(176, 139);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(196, 23);
            txtStatus.TabIndex = 4;
            txtStatus.Text = " - - - - - - - - - - - - - - - - - - - - -  ";
            txtStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtData
            // 
            txtData.Location = new Point(487, 138);
            txtData.Name = "txtData";
            txtData.Size = new Size(229, 23);
            txtData.TabIndex = 5;
            txtData.ValueChanged += txtData_ValueChanged;
            // 
            // btListarTodos
            // 
            btListarTodos.Location = new Point(738, 138);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(90, 23);
            btListarTodos.TabIndex = 6;
            btListarTodos.Text = "Mostrar Todos";
            btListarTodos.UseVisualStyleBackColor = true;
            btListarTodos.Click += btListarTodos_Click;
            // 
            // Relatório
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 450);
            Controls.Add(btListarTodos);
            Controls.Add(txtData);
            Controls.Add(txtStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listagem);
            Name = "Relatório";
            Text = "Relatório";
            Load += Relatório_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listagem;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtStatus;
        private DateTimePicker txtData;
        private Button btListarTodos;
    }
}