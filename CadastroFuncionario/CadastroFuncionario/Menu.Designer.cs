namespace CadastroFuncionario
{
    partial class frmMenu
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
            painelMenu = new Panel();
            btnInativaCad = new Button();
            btnPesquisaCad = new Button();
            btnAtualizaCad = new Button();
            btnNovoCad = new Button();
            painelLogo = new Panel();
            painelTitulo = new Panel();
            lblTitulo = new Label();
            painelForms = new Panel();
            painelMenu.SuspendLayout();
            painelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // painelMenu
            // 
            painelMenu.BackColor = Color.FromArgb(51, 51, 76);
            painelMenu.Controls.Add(btnInativaCad);
            painelMenu.Controls.Add(btnPesquisaCad);
            painelMenu.Controls.Add(btnAtualizaCad);
            painelMenu.Controls.Add(btnNovoCad);
            painelMenu.Controls.Add(painelLogo);
            painelMenu.Dock = DockStyle.Left;
            painelMenu.Location = new Point(0, 0);
            painelMenu.Name = "painelMenu";
            painelMenu.Size = new Size(175, 508);
            painelMenu.TabIndex = 1;
            // 
            // btnInativaCad
            // 
            btnInativaCad.Dock = DockStyle.Top;
            btnInativaCad.FlatAppearance.BorderSize = 0;
            btnInativaCad.FlatStyle = FlatStyle.Flat;
            btnInativaCad.ForeColor = Color.Gainsboro;
            btnInativaCad.Image = Properties.Resources.Inativar;
            btnInativaCad.ImageAlign = ContentAlignment.MiddleLeft;
            btnInativaCad.Location = new Point(0, 213);
            btnInativaCad.Name = "btnInativaCad";
            btnInativaCad.Padding = new Padding(10, 0, 0, 0);
            btnInativaCad.Size = new Size(175, 47);
            btnInativaCad.TabIndex = 4;
            btnInativaCad.Text = "   Inativar cadastro";
            btnInativaCad.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaCad
            // 
            btnPesquisaCad.Dock = DockStyle.Top;
            btnPesquisaCad.FlatAppearance.BorderSize = 0;
            btnPesquisaCad.FlatStyle = FlatStyle.Flat;
            btnPesquisaCad.ForeColor = Color.Gainsboro;
            btnPesquisaCad.Image = Properties.Resources.Pesquisar1;
            btnPesquisaCad.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisaCad.Location = new Point(0, 166);
            btnPesquisaCad.Name = "btnPesquisaCad";
            btnPesquisaCad.Padding = new Padding(10, 0, 0, 0);
            btnPesquisaCad.Size = new Size(175, 47);
            btnPesquisaCad.TabIndex = 3;
            btnPesquisaCad.Text = "      Pesquisar cadastro";
            btnPesquisaCad.UseVisualStyleBackColor = true;
            btnPesquisaCad.Click += btnPesquisaCad_Click;
            // 
            // btnAtualizaCad
            // 
            btnAtualizaCad.Dock = DockStyle.Top;
            btnAtualizaCad.FlatAppearance.BorderSize = 0;
            btnAtualizaCad.FlatStyle = FlatStyle.Flat;
            btnAtualizaCad.ForeColor = Color.Gainsboro;
            btnAtualizaCad.Image = Properties.Resources.Editar;
            btnAtualizaCad.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizaCad.Location = new Point(0, 119);
            btnAtualizaCad.Name = "btnAtualizaCad";
            btnAtualizaCad.Padding = new Padding(10, 0, 0, 0);
            btnAtualizaCad.Size = new Size(175, 47);
            btnAtualizaCad.TabIndex = 2;
            btnAtualizaCad.Text = "     Atualizar cadastro";
            btnAtualizaCad.UseVisualStyleBackColor = true;
            btnAtualizaCad.Click += btnAtualizaCad_Click;
            // 
            // btnNovoCad
            // 
            btnNovoCad.Dock = DockStyle.Top;
            btnNovoCad.FlatAppearance.BorderSize = 0;
            btnNovoCad.FlatStyle = FlatStyle.Flat;
            btnNovoCad.ForeColor = Color.Gainsboro;
            btnNovoCad.Image = Properties.Resources.Novo;
            btnNovoCad.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCad.Location = new Point(0, 72);
            btnNovoCad.Name = "btnNovoCad";
            btnNovoCad.Padding = new Padding(10, 0, 0, 0);
            btnNovoCad.Size = new Size(175, 47);
            btnNovoCad.TabIndex = 1;
            btnNovoCad.Text = "Novo cadastro";
            btnNovoCad.UseVisualStyleBackColor = true;
            btnNovoCad.Click += btnNovo_Click;
            // 
            // painelLogo
            // 
            painelLogo.BackColor = Color.FromArgb(39, 39, 58);
            painelLogo.Dock = DockStyle.Top;
            painelLogo.Location = new Point(0, 0);
            painelLogo.Name = "painelLogo";
            painelLogo.Size = new Size(175, 72);
            painelLogo.TabIndex = 0;
            // 
            // painelTitulo
            // 
            painelTitulo.BackColor = Color.FromArgb(51, 51, 76);
            painelTitulo.Controls.Add(lblTitulo);
            painelTitulo.Dock = DockStyle.Top;
            painelTitulo.Location = new Point(175, 0);
            painelTitulo.Name = "painelTitulo";
            painelTitulo.Size = new Size(766, 72);
            painelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(235, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Controle de funcionários";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelForms
            // 
            painelForms.BackColor = SystemColors.Control;
            painelForms.Dock = DockStyle.Fill;
            painelForms.ForeColor = Color.Black;
            painelForms.Location = new Point(175, 72);
            painelForms.Name = "painelForms";
            painelForms.Size = new Size(766, 436);
            painelForms.TabIndex = 5;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(941, 508);
            Controls.Add(painelForms);
            Controls.Add(painelTitulo);
            Controls.Add(painelMenu);
            ForeColor = Color.White;
            IsMdiContainer = true;
            Name = "frmMenu";
            Text = "Menu";
            painelMenu.ResumeLayout(false);
            painelTitulo.ResumeLayout(false);
            painelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelMenu;
        private Button btnInativaCad;
        private Button btnPesquisaCad;
        private Button btnAtualizaCad;
        private Button btnNovoCad;
        private Panel painelLogo;
        private Panel painelTitulo;
        private Label lblTitulo;
        public Panel painelForms;
    }
}