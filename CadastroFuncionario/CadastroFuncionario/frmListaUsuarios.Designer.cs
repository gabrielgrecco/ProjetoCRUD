namespace CadastroFuncionario
{
    partial class frmListaUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            CPF = new DataGridViewTextBoxColumn();
            RG = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            NomeChefe = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Rua = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            AssinouPolitica = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CPF, RG, Nome, Email, DataNascimento, Celular, Cargo, NomeChefe, CEP, Rua, Numero, Complemento, Bairro, UF, Cidade, AssinouPolitica, Ativo });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 407);
            dataGridView1.TabIndex = 0;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.Width = 52;
            // 
            // RG
            // 
            RG.HeaderText = "RG";
            RG.Name = "RG";
            RG.Width = 49;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 66;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 61;
            // 
            // DataNascimento
            // 
            DataNascimento.HeaderText = "Data de nascimento";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Width = 130;
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            Celular.Width = 70;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.Width = 64;
            // 
            // NomeChefe
            // 
            NomeChefe.HeaderText = "Nome do chefe";
            NomeChefe.Name = "NomeChefe";
            NomeChefe.Width = 108;
            // 
            // CEP
            // 
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.Width = 52;
            // 
            // Rua
            // 
            Rua.HeaderText = "Rua";
            Rua.Name = "Rua";
            Rua.Width = 53;
            // 
            // Numero
            // 
            Numero.HeaderText = "Número";
            Numero.Name = "Numero";
            Numero.Width = 78;
            // 
            // Complemento
            // 
            Complemento.HeaderText = "Complemento";
            Complemento.Name = "Complemento";
            Complemento.Width = 111;
            // 
            // Bairro
            // 
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.Width = 66;
            // 
            // UF
            // 
            UF.HeaderText = "UF";
            UF.Name = "UF";
            UF.Width = 47;
            // 
            // Cidade
            // 
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.Width = 69;
            // 
            // AssinouPolitica
            // 
            AssinouPolitica.HeaderText = "Assinou a política";
            AssinouPolitica.Name = "AssinouPolitica";
            AssinouPolitica.Width = 115;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.Width = 62;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 43);
            panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(39, 39, 58);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(713, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(39, 39, 58);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(630, 6);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(77, 29);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "frmListaUsuarios";
            Text = "ListaUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn NomeChefe;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Rua;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn UF;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn AssinouPolitica;
        private DataGridViewTextBoxColumn Ativo;
    }
}