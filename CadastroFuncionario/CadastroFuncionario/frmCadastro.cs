using System.Data;
using System.Data.SqlClient;
using CsvHelper.Configuration;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MimeKit;
using System.Collections;

namespace CadastroFuncionario
{
    public partial class frmCadastro : Form
    {
        Conexao con = new Conexao();
        string Sql;
        SqlCommand cmd = new SqlCommand();

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();

            Funcionario func = new Funcionario();

            func.CPF = txtCPF.Text;
            func.RG = txtRG.Text;
            func.Nome = txtNome.Text;
            func.Email = txtEmail.Text;
            func.DataNascimento = dtNascimento.Value;
            func.Celular = txtTelefone.Text;
            func.Cargo = txtCargo.Text;
            func.NomeChefe = txtChefe.Text;
            func.CEP = txtCEP.Text;
            func.Rua = txtLogradouro.Text;
            func.Numero = txtNumero.Text;
            func.Complemento = txtComplemento.Text;
            func.Bairro = txtBairro.Text;
            func.UF = txtUF.Text;
            func.Cidade = txtCidade.Text;
            func.AssinouPolitica = cBoxPolitica.SelectedIndex;
            func.Ativo = 1;

            // Verifica qual opção foi selecionada para o combobox (NÃO = 0, SIM = 1)
            if (cBoxPolitica.SelectedIndex == 1)
            {
                CadastrarFuncionario(func);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            else
            {
                EnvioEmail(func.Email);
                CadastrarFuncionario(func);
                MessageBox.Show("Funcionário cadastrado com sucesso!" + "\r\n\r\n" + "As políticas de uso dos equipamentos foram enviadas para o email cadastrado!");
            }
            
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtBairro.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtChefe.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtChefe.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtUF.Text = string.Empty;
        }

        public void CadastrarViaCSV(string caminho)
        {
            int count = 0;

            // Declara que o arquivo .csv tem cabeçalho
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            //Instância as classes de leitura do csv e obtem registros mapeando na classe funcionario
            using (var reader = new StreamReader(caminho))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<CadCSVMap>();

                var funcionarios = csv.GetRecords<Funcionario>();

                foreach (var funcionario in funcionarios)
                {
                    CadastrarFuncionario(funcionario);

                    if (funcionario.AssinouPolitica == 2)
                    {
                        EnvioEmail(funcionario.Email);
                    }

                    count = count + 1;
                }
            }

            MessageBox.Show(count.ToString() + " funcionários foram cadastrados!");

        }

        private void btnCadastroCSV_Click(object sender, EventArgs e)
        {

            //Abre tela para o usuário selecionar o arquivo de cadastro
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string caminho = openFileDialog.FileName;
            frmListaUsuarios frmLista = new frmListaUsuarios(caminho);

            //Faz a leitura do arquivo e quebra em linhas e colunas para exibição no datagrid
            StreamReader reader = new StreamReader(caminho);
            string linha;
            string[] campo;

            while ((linha = reader.ReadLine()) != null)
            {
                campo = linha.Split(',');
                frmLista.dataGridView1.Rows.Add(campo);
            }

            frmLista.ShowDialog();
        }

        private void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                con.AbrirConexao();
                Sql = "insert into Funcionarios (CPF, RG, Nome, Email, DataNascimento, Celular, Cargo, NomeChefe, CEP, Rua, Numero, Complemento, Bairro, UF, Cidade, AssinouPolitica, Ativo) " +
                                "values (@CPF, @RG, @Nome, @Email, @DataNascimento, @Celular, @Cargo, @NomeChefe, @CEP, @Rua, @Numero, @Complemento, @Bairro, @UF, @Cidade, @AssinouPolitica, @Ativo)";

                cmd = new SqlCommand(Sql, con.cnn);
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = funcionario.CPF;
                cmd.Parameters.Add("@RG", SqlDbType.VarChar).Value = funcionario.RG;
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = funcionario.Nome;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = funcionario.Email;
                cmd.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = funcionario.DataNascimento;
                cmd.Parameters.Add("@Celular", SqlDbType.VarChar).Value = funcionario.Celular;
                cmd.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = funcionario.Cargo;
                cmd.Parameters.Add("@NomeChefe", SqlDbType.VarChar).Value = funcionario.NomeChefe;
                cmd.Parameters.Add("@CEP", SqlDbType.VarChar).Value = funcionario.CEP;
                cmd.Parameters.Add("@Rua", SqlDbType.VarChar).Value = funcionario.Rua;
                cmd.Parameters.Add("@Numero", SqlDbType.VarChar).Value = funcionario.Numero;
                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = funcionario.Complemento;
                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = funcionario.Bairro;
                cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = funcionario.UF;
                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = funcionario.Cidade;
                cmd.Parameters.Add("@AssinouPolitica", SqlDbType.Int).Value = funcionario.AssinouPolitica;
                cmd.Parameters.Add("@Ativo", SqlDbType.Int).Value = funcionario.Ativo;

                cmd.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao inserir novo funcionaro: " + ex.Message);
            }
        }

        private void EnvioEmail(string EmailDestino)
        {
            try
            {
                Attachment anexosEmail = new Attachment("C:\\Users\\Gabriel\\Documents\\PoliticaEquipamento.txt");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("gabrieltech1204@outlook.com", "Gabriel Tech");
                mailMessage.To.Add(EmailDestino);
                mailMessage.Subject = "Política de equipamentos - Gabriel Tech";
                mailMessage.Body = "Segue em anexo política de uso dos equipamentos da empresa!";
                mailMessage.Attachments.Add(anexosEmail);

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("gabrieltech1204@outlook.com", "*Portfoliocrud1204");
                smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}