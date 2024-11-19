using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Promocao
    {
        public int PromocaoId { get; set; } // Identificador único da promoção
        public string NomeFuncionario { get; set; } // Nome do funcionário promovido
        public string FuncaoAtual { get; set; } // Função atual do funcionário
        public string NovaFuncao { get; set; } // Nova função do funcionário
        public decimal SalarioAtual { get; set; } // Salário atual do funcionário
        public decimal NovoSalario { get; set; } // Novo salário do funcionário
        public DateTime DataAdmissao { get; set; } // Data de admissão do funcionário
        public int IdGerente { get; set; } // Identificador do gerente (funcionário responsável
        public string Status { get; set; }
        public int IdFuncionarioPromovido { get; set; }


        // Construtor padrão
        public Promocao() { }

        // Construtor com parâmetros
        public Promocao(int promocaoId, string nomeFuncionario, string funcaoAtual, string novaFuncao,
                        decimal salarioAtual, decimal novoSalario, DateTime dataAdmissao, int funcionarioId)
        {
            PromocaoId = promocaoId;
            NomeFuncionario = nomeFuncionario;
            FuncaoAtual = funcaoAtual;
            NovaFuncao = novaFuncao;
            SalarioAtual = salarioAtual;
            NovoSalario = novoSalario;
            DataAdmissao = dataAdmissao;
            IdGerente = funcionarioId;
        }
    }
}
