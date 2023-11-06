using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class frmAtualizaCadastro : Form
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        string Sql;
        string CPF;
        public frmAtualizaCadastro(string cpfPesquisa)
        {
            InitializeComponent();
            CPF = cpfPesquisa;
        }

        private void frmAtualizaCadastro_Load(object sender, EventArgs e)
        {
            con.AbrirConexao();
            Sql = "select * from Funcionarios where CPF = " + CPF;
            cmd = new SqlCommand(Sql, con.cnn);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtNome.Text = dr["Nome"].ToString();
            txtBairro.Text = dr["Bairro"].ToString();
            txtCargo.Text = dr["Cargo"].ToString();
            txtCEP.Text = dr["CEP"].ToString();
            txtChefe.Text = dr["NomeChefe"].ToString();
            txtCidade.Text = dr["Cidade"].ToString();
            txtComplemento.Text = dr["Complemento"].ToString();
            txtCPF.Text = dr["CPF"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtLogradouro.Text = dr["Rua"].ToString();
            txtNumero.Text = dr["Numero"].ToString();
            txtChefe.Text = dr["NomeChefe"].ToString();
            txtRG.Text = dr["RG"].ToString();
            txtTelefone.Text = dr["Celular"].ToString();
            txtUF.Text = dr["UF"].ToString();
            dtNascimento.Text = dr["DataNascimento"].ToString();

            cBoxPolitica.SelectedIndex = Convert.ToInt32(dr["AssinouPolitica"]);
            con.FecharConexao();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            Sql = "UPDATE Funcionarios SET Nome = @nome, Email = @email, DataNascimento = @datanascimento, Celular = @celular, " +
                "Cargo = @cargo, NomeChefe = @nomechefe, CEP = @CEP, Rua = @Rua, Numero = @Numero, Complemento = @complemento, Bairro = @Bairro, " +
                "Cidade = @Cidade, AssinouPolitica = @AssinouPolitica, Ativo = @ativo WHERE CPF = " + CPF;

            cmd = new SqlCommand(Sql, con.cnn);
            cmd.Parameters.AddWithValue("nome", txtNome.Text);
            cmd.Parameters.AddWithValue("email", txtEmail.Text);
            cmd.Parameters.AddWithValue("datanascimento", dtNascimento.Value);
            cmd.Parameters.AddWithValue("celular", txtTelefone.Text);
            cmd.Parameters.AddWithValue("cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("nomechefe", txtChefe.Text);
            cmd.Parameters.AddWithValue("CEP", txtCEP.Text);
            cmd.Parameters.AddWithValue("Rua", txtLogradouro.Text);
            cmd.Parameters.AddWithValue("Numero", txtNumero.Text);
            cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
            cmd.Parameters.AddWithValue("Bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("Cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("AssinouPolitica", cBoxPolitica.SelectedIndex);
            cmd.Parameters.AddWithValue("ativo", 1);

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Cadastro atualizado!");
        }
    }
}
