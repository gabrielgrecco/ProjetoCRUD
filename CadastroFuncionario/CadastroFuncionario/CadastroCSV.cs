using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    public class Funcionario
    {
        public string CPF {  get; set; }
        public string RG { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Celular {  get; set; }
        public string Cargo { get; set; }
        public string NomeChefe {  get; set; }
        public string CEP { get; set; }
        public string Rua {  get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public int AssinouPolitica {  get; set; }
        public int Ativo {  get; set; }
    }
}
