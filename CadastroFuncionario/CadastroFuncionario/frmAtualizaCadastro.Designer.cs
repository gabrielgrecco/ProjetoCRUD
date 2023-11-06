namespace CadastroFuncionario
{
    partial class frmAtualizaCadastro
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
            cBoxPolitica = new ComboBox();
            btnCancelar = new Button();
            btnAtualizar = new Button();
            txtChefe = new TextBox();
            lblChefe = new Label();
            txtCargo = new TextBox();
            lblCargo = new Label();
            lblUF = new Label();
            txtUF = new TextBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblCEP = new Label();
            txtCEP = new TextBox();
            txtRG = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            dtNascimento = new DateTimePicker();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblDtNasc = new Label();
            lblRG = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(391, 278);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 75;
            label1.Text = "Assinou politica de equipamento *";
            // 
            // cBoxPolitica
            // 
            cBoxPolitica.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPolitica.ForeColor = SystemColors.WindowText;
            cBoxPolitica.FormattingEnabled = true;
            cBoxPolitica.Items.AddRange(new object[] { "NÃO", "SIM" });
            cBoxPolitica.Location = new Point(392, 296);
            cBoxPolitica.Name = "cBoxPolitica";
            cBoxPolitica.Size = new Size(193, 23);
            cBoxPolitica.TabIndex = 74;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(39, 39, 58);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(661, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 29);
            btnCancelar.TabIndex = 62;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(39, 39, 58);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(580, 395);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 29);
            btnAtualizar.TabIndex = 63;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtChefe
            // 
            txtChefe.Location = new Point(12, 401);
            txtChefe.Name = "txtChefe";
            txtChefe.Size = new Size(366, 23);
            txtChefe.TabIndex = 51;
            // 
            // lblChefe
            // 
            lblChefe.AutoSize = true;
            lblChefe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChefe.Location = new Point(12, 379);
            lblChefe.Name = "lblChefe";
            lblChefe.Size = new Size(101, 15);
            lblChefe.TabIndex = 72;
            lblChefe.Text = "Nome do chefe *";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(12, 349);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(365, 23);
            txtCargo.TabIndex = 50;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.Location = new Point(12, 327);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(47, 15);
            lblCargo.TabIndex = 71;
            lblCargo.Text = "Cargo *";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUF.ForeColor = SystemColors.ActiveCaptionText;
            lblUF.Location = new Point(391, 226);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(30, 15);
            lblUF.TabIndex = 70;
            lblUF.Text = "UF *";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(392, 244);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(51, 23);
            txtUF.TabIndex = 59;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = SystemColors.ActiveCaptionText;
            lblCidade.Location = new Point(457, 226);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(52, 15);
            lblCidade.TabIndex = 69;
            lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(458, 244);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(296, 23);
            txtCidade.TabIndex = 60;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.ForeColor = SystemColors.ActiveCaptionText;
            lblBairro.Location = new Point(391, 174);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 15);
            lblBairro.TabIndex = 68;
            lblBairro.Text = "Bairro *";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(392, 192);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(362, 23);
            txtBairro.TabIndex = 58;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplemento.ForeColor = SystemColors.ActiveCaptionText;
            lblComplemento.Location = new Point(486, 122);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(86, 15);
            lblComplemento.TabIndex = 67;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(487, 140);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(269, 23);
            txtComplemento.TabIndex = 57;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.ForeColor = SystemColors.ActiveCaptionText;
            lblNumero.Location = new Point(392, 122);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(61, 15);
            lblNumero.TabIndex = 66;
            lblNumero.Text = "Número *";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(393, 140);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(79, 23);
            txtNumero.TabIndex = 56;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogradouro.ForeColor = SystemColors.ActiveCaptionText;
            lblLogradouro.Location = new Point(393, 70);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(79, 15);
            lblLogradouro.TabIndex = 65;
            lblLogradouro.Text = "Logradouro *";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(394, 88);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(362, 23);
            txtLogradouro.TabIndex = 55;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCEP.ForeColor = SystemColors.ActiveCaptionText;
            lblCEP.Location = new Point(394, 18);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(35, 15);
            lblCEP.TabIndex = 64;
            lblCEP.Text = "CEP *";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(395, 36);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(361, 23);
            txtCEP.TabIndex = 54;
            // 
            // txtRG
            // 
            txtRG.Culture = new System.Globalization.CultureInfo("es-US");
            txtRG.Location = new Point(12, 141);
            txtRG.Name = "txtRG";
            txtRG.ReadOnly = true;
            txtRG.Size = new Size(362, 23);
            txtRG.TabIndex = 42;
            // 
            // txtCPF
            // 
            txtCPF.Culture = new System.Globalization.CultureInfo("es-US");
            txtCPF.Location = new Point(12, 89);
            txtCPF.Name = "txtCPF";
            txtCPF.ReadOnly = true;
            txtCPF.Size = new Size(362, 23);
            txtCPF.TabIndex = 41;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 245);
            txtTelefone.Mask = "(00) 000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(362, 23);
            txtTelefone.TabIndex = 45;
            // 
            // dtNascimento
            // 
            dtNascimento.CustomFormat = "";
            dtNascimento.Format = DateTimePickerFormat.Custom;
            dtNascimento.Location = new Point(12, 193);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(363, 23);
            dtNascimento.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 23);
            txtEmail.TabIndex = 47;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 275);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 15);
            lblEmail.TabIndex = 53;
            lblEmail.Text = "E-mail *";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(12, 223);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(107, 15);
            lblTelefone.TabIndex = 52;
            lblTelefone.Text = "Telefone/Celular *";
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDtNasc.Location = new Point(12, 171);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(125, 15);
            lblDtNasc.TabIndex = 49;
            lblDtNasc.Text = "Data de nascimento *";
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRG.Location = new Point(12, 119);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(32, 15);
            lblRG.TabIndex = 48;
            lblRG.Text = "RG *";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPF.Location = new Point(12, 67);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(35, 15);
            lblCPF.TabIndex = 46;
            lblCPF.Text = "CPF *";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ActiveCaptionText;
            lblNome.Location = new Point(12, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 15);
            lblNome.TabIndex = 44;
            lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(12, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 23);
            txtNome.TabIndex = 40;
            // 
            // frmAtualizaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(label1);
            Controls.Add(cBoxPolitica);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtualizar);
            Controls.Add(txtChefe);
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
            Name = "frmAtualizaCadastro";
            Text = "frmAtualizaCadastro";
            Load += frmAtualizaCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cBoxPolitica;
        private Button btnCadastroCSV;
        private Button btnCancelar;
        private Button btnAtualizar;
        private TextBox txtChefe;
        private Button btnLimpar;
        private Label lblChefe;
        private TextBox txtCargo;
        private Label lblCargo;
        private Label lblUF;
        private TextBox txtUF;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblCEP;
        private TextBox txtCEP;
        private MaskedTextBox txtRG;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtTelefone;
        private DateTimePicker dtNascimento;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblDtNasc;
        private Label lblRG;
        private Label lblCPF;
        private Label lblNome;
        public TextBox txtNome;
    }
}