using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class FuncionarioFazDAL : SqlHelper
    {
        public Funcionario LoginFuncionario(SqlConnection con, string email, string senha)
        {
            // Definir a consulta SQL com parâmetros para evitar SQL Injection
            string loginEmailESenha = "SELECT * FROM Funcionario WHERE email = @Email AND senha = @Senha";

            try
            {
                // Criar e preparar a consulta
                SqlCommand cmd = new SqlCommand(loginEmailESenha, con);

                // Adicionar parâmetros para evitar SQL Injection
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                // Executar a consulta e obter o SqlDataReader
                SqlDataReader dr = cmd.ExecuteReader();

                // Verificar se a consulta retornou algum resultado
                if (dr.Read())
                {
                    // Criar o objeto Funcionario e preencher os dados retornados
                    Funcionario funcionario = new Funcionario
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Nome = dr["nome"].ToString(),
                        Cpf = dr["cpf"].ToString(),
                        Cnpj = dr["cnpj"].ToString(),
                        DataNascimento = Convert.ToDateTime(dr["dataNascimento"]),
                        Senha = dr["senha"].ToString(),
                        Salario = Convert.ToDouble(dr["salario"]),
                        Funcao = dr["funcao"].ToString(),
                        FazendaId = Convert.ToInt32(dr["fazendaId"])
                    };

                    return funcionario;
                }
                else
                {
                    // Caso o login não seja encontrado
                    return null;  // Retorna null se o login for inválido
                }
            }
            catch (Exception ex)
            {
                // Log ou tratamento mais adequado da exceção
                throw new Exception("Erro ao realizar o login: " + ex.Message, ex);
            }
        }

        public List<Funcionario> ListarFuncionarios(SqlConnection con)
        {
            // Query para buscar todos os funcionários
            string query = "SELECT * FROM funcionario";
            List<Funcionario> listaFunc = new List<Funcionario>();

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Criando e preenchendo o objeto Funcionario com os novos atributos
                            Funcionario objFunc = new Funcionario
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Nome = dr["nome"].ToString(),
                                Cpf = dr["cpf"].ToString(),
                                Cnpj = dr["cnpj"].ToString(),
                                DataNascimento = Convert.ToDateTime(dr["dataNascimento"]),
                                Senha = dr["senha"].ToString(),
                                Salario = Convert.ToDouble(dr["salario"]),
                                Funcao = dr["funcao"].ToString(),
                                FazendaId = Convert.ToInt32(dr["fazendaId"])
                            };

                            // Adiciona o objeto à lista
                            listaFunc.Add(objFunc);
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
            return listaFunc;
        }

        public void CadastrarFuncionario(SqlConnection con, Funcionario funcionario)
        {
            // Query para inserir o endereço
            string queryCadastrarEndereco = @"
INSERT INTO Endereco 
(rua, numero, complemento, cidade, estado, cep) 
VALUES 
(@Rua, @Numero, @Complemento, @Cidade, @Estado, @Cep);
SELECT SCOPE_IDENTITY();"; // Recupera o ID gerado

            // Query para inserir o funcionário
            string queryCadastrarFuncionario = @"
INSERT INTO Funcionario 
(nome, cpf, dataNascimento, celular, email, senha, salario, funcao, fazendaId, fk_EnderecoId, nomeGerente, dataAdmissao) 
VALUES 
(@Nome, @Cpf, @DataNascimento, @Celular, @Email, @Senha, @Salario, @Funcao, @FazendaId, @FkEnderecoId, @NomeGerente, @DataAdmissao);";

            try
            {
                // Iniciar uma transação para garantir consistência
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Inserir o endereço
                        using (SqlCommand comandoEndereco = new SqlCommand(queryCadastrarEndereco, con, transaction))
                        {
                            comandoEndereco.Parameters.AddWithValue("@Rua", funcionario.Endereco.Rua);
                            comandoEndereco.Parameters.AddWithValue("@Numero", funcionario.Endereco.Numero);
                            comandoEndereco.Parameters.AddWithValue("@Complemento", funcionario.Endereco.Complemento ?? (object)DBNull.Value);
                            comandoEndereco.Parameters.AddWithValue("@Cidade", funcionario.Endereco.Cidade);
                            comandoEndereco.Parameters.AddWithValue("@Estado", funcionario.Endereco.Estado);
                            comandoEndereco.Parameters.AddWithValue("@Cep", funcionario.Endereco.Cep);

                            // Executar o comando e obter o ID do endereço
                            int enderecoId = Convert.ToInt32(comandoEndereco.ExecuteScalar());
                            funcionario.Endereco.Id = enderecoId; // Atualizar o objeto Funcionario.Endereco com o ID gerado
                        }

                        // Inserir o funcionário
                        using (SqlCommand comandoFuncionario = new SqlCommand(queryCadastrarFuncionario, con, transaction))
                        {
                            comandoFuncionario.Parameters.AddWithValue("@Nome", funcionario.Nome);
                            comandoFuncionario.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
                            comandoFuncionario.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);
                            comandoFuncionario.Parameters.AddWithValue("@Celular", funcionario.Celular);
                            comandoFuncionario.Parameters.AddWithValue("@Email", funcionario.Email);
                            comandoFuncionario.Parameters.AddWithValue("@Senha", funcionario.Senha);
                            comandoFuncionario.Parameters.AddWithValue("@Salario", funcionario.Salario);
                            comandoFuncionario.Parameters.AddWithValue("@Funcao", funcionario.Funcao);
                            comandoFuncionario.Parameters.AddWithValue("@FazendaId", funcionario.FazendaId);
                            comandoFuncionario.Parameters.AddWithValue("@FkEnderecoId", funcionario.Endereco.Id);

                            // Adicionando os novos parâmetros
                            comandoFuncionario.Parameters.AddWithValue("@NomeGerente", funcionario.NomeGerente ?? (object)DBNull.Value);
                            comandoFuncionario.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);

                            // Executar o comando
                            int linhasAfetadas = comandoFuncionario.ExecuteNonQuery();

                            if (linhasAfetadas <= 0)
                            {
                                throw new Exception("Nenhuma linha foi inserida para o funcionário.");
                            }
                        }

                        // Confirma a transação
                        transaction.Commit();
                    }
                    catch
                    {
                        // Reverte a transação em caso de erro
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao cadastrar o funcionário: " + ex.Message, ex);
            }
        }

        public void AlterarSenha(SqlConnection con, Funcionario funcionario, string novaSenha)
        {

            // Query para atualizar a senha do funcionário
            string queryAlterarSenha = @"
        UPDATE Funcionario 
        SET senha = @NovaSenha 
        WHERE id = @FuncionarioId;";

            try
            {
                // Iniciar uma transação para garantir consistência
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand comando = new SqlCommand(queryAlterarSenha, con, transaction))
                        {
                            comando.Parameters.AddWithValue("@NovaSenha", novaSenha);
                            comando.Parameters.AddWithValue("@FuncionarioId", funcionario.Id);

                            // Executar o comando
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas <= 0)
                            {
                                throw new Exception("Nenhuma linha foi atualizada. Verifique se o ID do funcionário é válido.");
                            }
                        }

                        // Confirmar a transação
                        transaction.Commit();
                    }
                    catch
                    {
                        // Reverter a transação em caso de erro
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar a senha do funcionário: " + ex.Message, ex);
            }

        }

        public Funcionario BuscarFuncionarioPorId(SqlConnection con, int id)
        {
            // Query para buscar o funcionário pelo ID
            string query = "SELECT * FROM funcionario WHERE id = @id";
            Funcionario funcionario = null;

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adicionando o parâmetro ID à query
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Criando e preenchendo o objeto Funcionario com os dados obtidos
                            funcionario = new Funcionario
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Nome = dr["nome"].ToString(),
                                Cpf = dr["cpf"].ToString(),
                                Cnpj = dr["cnpj"].ToString(),
                                DataNascimento = Convert.ToDateTime(dr["dataNascimento"]),
                                Senha = dr["senha"].ToString(),
                                Salario = Convert.ToDouble(dr["salario"]),
                                Funcao = dr["funcao"].ToString(),
                                FazendaId = Convert.ToInt32(dr["fazendaId"])
                            };
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
                throw new Exception("Ocorreu um erro ao buscar o funcionário: " + ex.Message, ex);
            }

            // Retorna o funcionário encontrado ou null se não houver resultados
            return funcionario;
        }

        public void AtualizarFuncionario(SqlConnection con, int id, string novaFuncao, double novoSalario)
        {
            // Query para atualizar os dados do funcionário
            string query = "UPDATE funcionario SET funcao = @novaFuncao, salario = @novoSalario WHERE id = @id";

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adicionando os parâmetros
                    cmd.Parameters.AddWithValue("@novaFuncao", novaFuncao);
                    cmd.Parameters.AddWithValue("@novoSalario", novoSalario);
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executa o comando
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se alguma linha foi alterada
                    if (linhasAfetadas == 0)
                    {
                        throw new Exception("Funcionário não encontrado ou dados não foram atualizados.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar os dados do funcionário: " + ex.Message, ex);
            }
        }

        public void ExcluirFuncionario(SqlConnection con, int funcionarioId)
        {
            // Query para excluir o funcionário
            string queryExcluirFuncionario = @"
                DELETE FROM Funcionario 
                WHERE id = @FuncionarioId;";

            try
            {
                // Iniciar uma transação para garantir consistência
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand comando = new SqlCommand(queryExcluirFuncionario, con, transaction))
                        {
                            comando.Parameters.AddWithValue("@FuncionarioId", funcionarioId);

                            // Executar o comando
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas <= 0)
                            {
                                throw new Exception("Nenhuma linha foi excluída. Verifique se o ID do funcionário é válido.");
                            }
                        }

                        // Confirmar a transação
                        transaction.Commit();
                    }
                    catch
                    {
                        // Reverter a transação em caso de erro
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao excluir o funcionário: " + ex.Message, ex);
            }
        }

        public void AtualizarFuncionario(SqlConnection con, int id, Funcionario funcionario)
        {
            // Query dinâmica para atualizar os campos não nulos
            string query = @"
UPDATE Funcionario
SET
    funcao = COALESCE(@Funcao, funcao),
    salario = COALESCE(@Salario, salario),
    fazendaId = COALESCE(@FazendaId, fazendaId),
    nomeGerente = COALESCE(@NomeGerente, nomeGerente),
    nome = COALESCE(@Nome, nome),
    cpf = COALESCE(@Cpf, cpf),
    cnpj = COALESCE(@Cnpj, cnpj),
    dataNascimento = COALESCE(@DataNascimento, dataNascimento),
    celular = COALESCE(@Celular, celular),
    email = COALESCE(@Email, email),
    senha = COALESCE(@Senha, senha),
    dataAdmissao = COALESCE(@DataAdmissao, dataAdmissao),
    imagem = COALESCE(@Imagem, imagem)
WHERE id = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adiciona os parâmetros ao comando
                    cmd.Parameters.AddWithValue("@Funcao", (object)funcionario.Funcao ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Salario", (object)funcionario.Salario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FazendaId", (object)funcionario.FazendaId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NomeGerente", (object)funcionario.NomeGerente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nome", (object)funcionario.Nome ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cpf", (object)funcionario.Cpf ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cnpj", (object)funcionario.Cnpj ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento == default ? DBNull.Value : (object)funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@Celular", (object)funcionario.Celular ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)funcionario.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Senha", (object)funcionario.Senha ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao == default ? DBNull.Value : (object)funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@Imagem", (object)funcionario.Imagem ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", id);

                    // Executa o comando e verifica se alguma linha foi alterada
                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    if (linhasAfetadas == 0)
                    {
                        throw new Exception("Funcionário não encontrado ou dados não foram atualizados.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar os dados do funcionário: " + ex.Message, ex);
            }
        }


    }
}
