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
    public partial class frmListaUsuarios : Form
    {
        string caminho;
        public frmListaUsuarios(string path)
        {
            InitializeComponent();
            caminho = path;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmCadastro func = new frmCadastro();
            func.CadastrarViaCSV(caminho);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
