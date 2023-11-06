namespace CadastroFuncionario
{
    partial class frmCadastro
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
        public void InitializeComponent()
        {
            txtNome = new TextBox();
            lblNome = new Label();
            lblCPF = new Label();
            lblRG = new Label();
            lblDtNasc = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            dtNascimento = new DateTimePicker();
            txtTelefone = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            txtRG = new MaskedTextBox();
            lblCEP = new Label();
            txtCEP = new TextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblUF = new Label();
            txtUF = new TextBox();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtChefe = new TextBox();
            lblChefe = new Label();
            btnLimpar = new Button();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            btnCadastroCSV = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            cBoxPolitica = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(14, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ActiveCaptionText;
            lblNome.Location = new Point(13, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome *";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPF.Location = new Point(13, 61);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(35, 15);
            lblCPF.TabIndex = 5;
            lblCPF.Text = "CPF *";
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRG.Location = new Point(13, 113);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(32, 15);
            lblRG.TabIndex = 6;
            lblRG.Text = "RG *";
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDtNasc.Location = new Point(13, 165);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(125, 15);
            lblDtNasc.TabIndex = 7;
            lblDtNasc.Text = "Data de nascimento *";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(13, 217);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(107, 15);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone/Celular *";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(13, 269);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail *";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 23);
            txtEmail.TabIndex = 6;
            // 
            // dtNascimento
            // 
            dtNascimento.CustomFormat = "";
            dtNascimento.Format = DateTimePickerFormat.Custom;
            dtNascimento.Location = new Point(13, 183);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(363, 23);
            dtNascimento.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(14, 235);
            txtTelefone.Mask = "(00) 000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(362, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtCPF
            // 
            txtCPF.Culture = new System.Globalization.CultureInfo("es-US");
            txtCPF.Location = new Point(14, 79);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(362, 23);
            txtCPF.TabIndex = 2;
            // 
            // txtRG
            // 
            txtRG.Culture = new System.Globalization.CultureInfo("es-US");
            txtRG.Location = new Point(14, 131);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(362, 23);
            txtRG.TabIndex = 3;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCEP.ForeColor = SystemColors.ActiveCaptionText;
            lblCEP.Location = new Point(391, 9);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(35, 15);
            lblCEP.TabIndex = 20;
            lblCEP.Text = "CEP *";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(392, 27);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(361, 23);
            txtCEP.TabIndex = 9;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogradouro.ForeColor = SystemColors.ActiveCaptionText;
            lblLogradouro.Location = new Point(390, 61);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(79, 15);
            lblLogradouro.TabIndex = 22;
            lblLogradouro.Text = "Logradouro *";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(391, 79);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(362, 23);
            txtLogradouro.TabIndex = 10;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.ForeColor = SystemColors.ActiveCaptionText;
            lblNumero.Location = new Point(389, 113);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(61, 15);
            lblNumero.TabIndex = 24;
            lblNumero.Text = "Número *";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(390, 131);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(79, 23);
            txtNumero.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplemento.ForeColor = SystemColors.ActiveCaptionText;
            lblComplemento.Location = new Point(483, 113);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(86, 15);
            lblComplemento.TabIndex = 26;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(484, 131);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(269, 23);
            txtComplemento.TabIndex = 12;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.ForeColor = SystemColors.ActiveCaptionText;
            lblBairro.Location = new Point(388, 165);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 15);
            lblBairro.TabIndex = 28;
            lblBairro.Text = "Bairro *";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(389, 183);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(362, 23);
            txtBairro.TabIndex = 13;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = SystemColors.ActiveCaptionText;
            lblCidade.Location = new Point(454, 217);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(52, 15);
            lblCidade.TabIndex = 30;
            lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(455, 235);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(296, 23);
            txtCidade.TabIndex = 15;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUF.ForeColor = SystemColors.ActiveCaptionText;
            lblUF.Location = new Point(388, 217);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(30, 15);
            lblUF.TabIndex = 32;
            lblUF.Text = "UF *";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(389, 235);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(51, 23);
            txtUF.TabIndex = 14;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(11, 342);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(365, 23);
            txtCargo.TabIndex = 7;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.Location = new Point(12, 324);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(47, 15);
            lblCargo.TabIndex = 33;
            lblCargo.Text = "Cargo *";
            // 
            // txtChefe
            // 
            txtChefe.Location = new Point(10, 397);
            txtChefe.Name = "txtChefe";
            txtChefe.Size = new Size(366, 23);
            txtChefe.TabIndex = 8;
            // 
            // lblChefe
            // 
            lblChefe.AutoSize = true;
            lblChefe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChefe.Location = new Point(11, 379);
            lblChefe.Name = "lblChefe";
            lblChefe.Size = new Size(101, 15);
            lblChefe.TabIndex = 35;
            lblChefe.Text = "Nome do chefe *";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(39, 39, 58);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(509, 342);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 29);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(39, 39, 58);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(671, 342);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 29);
            btnCadastrar.TabIndex = 18;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(39, 39, 58);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(590, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastroCSV
            // 
            btnCadastroCSV.BackColor = Color.FromArgb(39, 39, 58);
            btnCadastroCSV.FlatStyle = FlatStyle.Flat;
            btnCadastroCSV.ForeColor = Color.White;
            btnCadastroCSV.Location = new Point(509, 390);
            btnCadastroCSV.Name = "btnCadastroCSV";
            btnCadastroCSV.Size = new Size(237, 30);
            btnCadastroCSV.TabIndex = 36;
            btnCadastroCSV.Text = "Carregar .csv de cadastro";
            btnCadastroCSV.UseVisualStyleBackColor = false;
            btnCadastroCSV.Click += btnCadastroCSV_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cBoxPolitica
            // 
            cBoxPolitica.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPolitica.ForeColor = SystemColors.WindowText;
            cBoxPolitica.FormattingEnabled = true;
            cBoxPolitica.Items.AddRange(new object[] { "SIM", "NÃO" });
            cBoxPolitica.Location = new Point(389, 287);
            cBoxPolitica.Name = "cBoxPolitica";
            cBoxPolitica.Size = new Size(193, 23);
            cBoxPolitica.TabIndex = 38;
            cBoxPolitica.SelectedIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(388, 269);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 39;
            label1.Text = "Assinou politica de equipamento *";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(766, 439);
            Controls.Add(label1);
            Controls.Add(cBoxPolitica);
            Controls.Add(btnCadastroCSV);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtChefe);
            Controls.Add(btnLimpar);
            Controls.Add(lblChefe);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(lblUF);
            Controls.Add(txtUF);
            Controls.Add(lblCidade);
            Controls.Add(txtCidade);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(lblComplemento);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(txtLogradouro);
            Controls.Add(lblCEP);
            Controls.Add(txtCEP);
            Controls.Add(txtRG);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(dtNascimento);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblDtNasc);
            Controls.Add(lblRG);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Name = "frmCadastro";
            Text = "Cadastro de funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCPF;
        private Label lblRG;
        private Label lblDtNasc;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private DateTimePicker dtNascimento;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtRG;
        private Label lblCEP;
        private TextBox txtCEP;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblUF;
        private TextBox txtUF;
        private TextBox txtCargo;
        private Label lblCargo;
        private TextBox txtChefe;
        private Label lblChefe;
        private Button btnLimpar;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Button btnCadastroCSV;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
        private ComboBox cBoxPolitica;
        private Label label1;
    }
}