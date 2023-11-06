namespace CadastroFuncionario
{
    partial class frmPesquisaFuncionario
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
            label1 = new Label();
            txtCPF = new TextBox();
            btnPesquisar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe o CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(57, 49);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(171, 23);
            txtCPF.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(39, 39, 58);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(57, 86);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(80, 29);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(39, 39, 58);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(143, 86);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmPesquisaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 143);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtCPF);
            Controls.Add(label1);
            Name = "frmPesquisaFuncionario";
            Text = "Pesquisa por CPF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCPF;
        private Button btnPesquisar;
        private Button btnCancelar;
    }
}