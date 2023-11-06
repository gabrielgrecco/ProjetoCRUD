using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    public class CadCSVMap : ClassMap<Funcionario>
    {
        public CadCSVMap() 
        {
            Map(c => c.CPF).Name("CPF");
            Map(c => c.RG).Name("RG");
            Map(c => c.Nome).Name("Nome");
            Map(c => c.Email).Name("Email");
            Map(c => c.DataNascimento).Name("DataNascimento");
            Map(c => c.Celular).Name("Celular");
            Map(c => c.Cargo).Name("Cargo");
            Map(c => c.NomeChefe).Name("NomeChefe");
            Map(c => c.CEP).Name("CEP");
            Map(c => c.Rua).Name("Rua");
            Map(c => c.Numero).Name("Numero");
            Map(c => c.Complemento).Name("Complemento");
            Map(c => c.Bairro).Name("Bairro");
            Map(c => c.UF).Name("UF");
            Map(c => c.Cidade).Name("Cidade");
            Map(c => c.AssinouPolitica).Name("AssinouPolitica");
            Map(c => c.Ativo).Name("Ativo");
        }
    }
}
