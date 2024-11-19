using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PromocaoDAL : SqlHelper
    {
        public List<Promocao> ListarPromocoes(SqlConnection con)
        {
            // Query para buscar todos os funcionários
            string query = "SELECT * FROM Promocao";
            List<Promocao> listaProm = new List<Promocao>();

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Criando e preenchendo o objeto Promocao com os novos atributos
                            Promocao objFunc = new Promocao
                            {
                                PromocaoId = Convert.ToInt32(dr["PromocaoId"]),
                                NomeFuncionario = dr["NomeFuncionario"].ToString(),
                                FuncaoAtual = dr["FuncaoAtual"].ToString(),
                                NovaFuncao = dr["NovaFuncao"].ToString(),
                                SalarioAtual = Convert.ToDecimal(dr["SalarioAtual"]),
                                NovoSalario = Convert.ToDecimal(dr["NovoSalario"]),
                                DataAdmissao = Convert.ToDateTime(dr["DataAdmissao"]),
                                IdGerente = Convert.ToInt32(dr["IdGerente"]),
                                Status = dr["Status"].ToString(),
                                IdFuncionarioPromovido = Convert.ToInt32(dr["IdFuncionarioPromovido"]),
                            };

                            // Adiciona o objeto à lista
                            listaProm.Add(objFunc);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao listar os funcionários: " + ex.Message, ex);
            }

            // Retorna a lista de funcionários
            return listaProm;
        }

        public void InserirPromocao(SqlConnection con, Promocao promocao)
        {
            // Query para inserir uma nova promoção na tabela Promocao
            string query = @"
        INSERT INTO Promocao (
            nomeFuncionario, 
            funcaoAtual, 
            novaFuncao, 
            salarioAtual, 
            novoSalario, 
            dataAdmissao, 
            idgerente, 
            status,
            IdFuncionarioPromovido
        )
        VALUES (
            @NomeFuncionario,
            @FuncaoAtual,
            @NovaFuncao,
            @SalarioAtual,
            @NovoSalario,
            @DataAdmissao,
            @IdGerente,
            @Status,
            @IdFuncionarioPromovido
        )";

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Definindo os parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@NomeFuncionario", promocao.NomeFuncionario);
                    cmd.Parameters.AddWithValue("@FuncaoAtual", promocao.FuncaoAtual);
                    cmd.Parameters.AddWithValue("@NovaFuncao", promocao.NovaFuncao);
                    cmd.Parameters.AddWithValue("@SalarioAtual", promocao.SalarioAtual);
                    cmd.Parameters.AddWithValue("@NovoSalario", promocao.NovoSalario);
                    cmd.Parameters.AddWithValue("@DataAdmissao", promocao.DataAdmissao);
                    cmd.Parameters.AddWithValue("@IdGerente", promocao.IdGerente);
                    cmd.Parameters.AddWithValue("@Status", promocao.Status);
                    cmd.Parameters.AddWithValue("@IdFuncionarioPromovido", promocao.IdFuncionarioPromovido);

                    // Executa o comando para inserir os dados na tabela
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao inserir a promoção: " + ex.Message, ex);
            }
        }

        public void AtualizarStatusPromocao(SqlConnection con, int promocaoId, string novoStatus)
        {
            // Query para atualizar o status da promoção
            string query = "UPDATE Promocao SET Status = @novoStatus WHERE PromocaoId = @promocaoId";

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adicionando os parâmetros
                    cmd.Parameters.AddWithValue("@novoStatus", novoStatus);
                    cmd.Parameters.AddWithValue("@promocaoId", promocaoId);

                    // Executa o comando
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se alguma linha foi alterada
                    if (linhasAfetadas == 0)
                    {
                        throw new Exception("Promoção não encontrada ou status não foi atualizado.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar o status da promoção: " + ex.Message, ex);
            }
        }



    }
}
