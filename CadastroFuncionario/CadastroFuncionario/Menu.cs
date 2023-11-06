using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class frmMenu : Form
    {
        private Form formAtivo;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new frmCadastro());
        }

        private void AbrirFormFilho(Form childForm)
        {
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.painelForms.Controls.Add(childForm);
            this.painelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPesquisaCad_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizaCad_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new frmPesquisaFuncionario());
        }
    }
}
