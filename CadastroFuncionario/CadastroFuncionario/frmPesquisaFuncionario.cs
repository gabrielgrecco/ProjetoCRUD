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
    public partial class frmPesquisaFuncionario : Form
    {
        public frmPesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmMenu teste = Application.OpenForms["frmMenu"] as frmMenu;
            teste.painelForms.Controls.Clear();
            frmAtualizaCadastro frmAtualizaCad = new frmAtualizaCadastro(txtCPF.Text);

            //frmAtualizaCad.MdiParent = teste;
            frmAtualizaCad.TopLevel = false;
            frmAtualizaCad.FormBorderStyle = FormBorderStyle.None;
            frmAtualizaCad.Dock = DockStyle.Fill;
            teste.painelForms.Controls.Add(frmAtualizaCad);
            teste.painelForms.Tag = frmAtualizaCad;
            frmAtualizaCad.BringToFront();
            frmAtualizaCad.Show();
        }
    }
}
