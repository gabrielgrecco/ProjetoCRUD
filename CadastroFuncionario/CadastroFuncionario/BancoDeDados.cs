using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    class Conexao
    {
        public string connectionString = "Data Source=DESKTOP-G74ITUK;Initial Catalog=ProjetoCrud;Persist Security Info=True;User ID=sa;Password=34180688";

        public SqlConnection cnn = null;

        public void AbrirConexao()
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel fechar a conexão: " + ex.Message);
            }
        }

    }
}
