using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ProdutoDAL :SqlHelper
    {
        public List<Produto> BuscarProdutos(SqlConnection con)
        {
            string query = "SELECT * FROM Produto";
            List<Produto> listaProd = new List<Produto>();

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Produto objProduto = new Produto
                            {
                                Id = Convert.ToInt32(dr["Id"]), // ID do produto
                                Nome = dr["Nome"].ToString(), // Nome do produto
                                Preco = Convert.ToDouble(dr["Preco"]), // Preço do produto
                                Categoria = dr["Categoria"].ToString(), // Categoria do produto
                                Desconto = Convert.ToDouble(dr["Desconto"]), // Desconto aplicado no produto
                                Imagem = dr["imagem"].ToString(), // Caminho ou URL da imagem
                                Quantidade = Convert.ToInt32(dr["Quantidade"]) // Quantidade em estoque
                            };

                            // Adiciona o objeto à lista
                            listaProd.Add(objProduto);
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
                throw new Exception("Ocorreu um erro ao listar os Produtos: " + ex.Message, ex);
            }



            // Retorna a lista de funcionários
            return listaProd;
        }

        public List<Produto> BuscarProdutosPorCategoria(SqlConnection con, string categoria)
        {
            // Consulta SQL para filtrar por categoria e selecionar apenas Id e Nome
            string query = "SELECT Id, Nome , Quantidade FROM Produto WHERE Categoria = @Categoria";

            // Lista para armazenar os produtos retornados
            List<Produto> listaProd = new List<Produto>();

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parâmetro para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@Categoria", categoria);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Criando o objeto Produto com apenas Id e Nome
                            Produto objProduto = new Produto
                            {
                                Id = Convert.ToInt32(dr["Id"]), // ID do produto
                                Nome = dr["Nome"].ToString(), // Nome do produto
                                Quantidade = Convert.ToInt32(dr["Quantidade"])
                            };

                            // Adiciona o objeto à lista
                            listaProd.Add(objProduto);
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
                throw new Exception("Ocorreu um erro ao listar os Produtos: " + ex.Message, ex);
            }

            // Retorna a lista de produtos filtrados por categoria
            return listaProd;
        }





        public void CadastrarProduto(SqlConnection con, Produto produto)
        {
            // Query para inserir o produto
            string queryCadastrarProduto = @"
                INSERT INTO Produto
                (Nome, Preco, Categoria, Desconto, Imagem, Quantidade) 
                VALUES 
                (@Nome, @Preco, @Categoria, @Desconto, @Imagem, @Quantidade);";

            try
            {
                // Iniciar uma transação para garantir consistência
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Inserir o produto
                        using (SqlCommand comandoProduto = new SqlCommand(queryCadastrarProduto, con, transaction))
                        {
                            comandoProduto.Parameters.AddWithValue("@Nome", produto.Nome);
                            comandoProduto.Parameters.AddWithValue("@Preco", produto.Preco);
                            comandoProduto.Parameters.AddWithValue("@Categoria", produto.Categoria);
                            comandoProduto.Parameters.AddWithValue("@Desconto", produto.Desconto);
                            comandoProduto.Parameters.AddWithValue("@Imagem", produto.Imagem ?? (object)DBNull.Value);
                            comandoProduto.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

                            // Executar o comando
                            int linhasAfetadas = comandoProduto.ExecuteNonQuery();

                            if (linhasAfetadas <= 0)
                            {
                                throw new Exception("Nenhuma linha foi inserida para o produto.");
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
                throw new Exception("Ocorreu um erro ao cadastrar o produto: " + ex.Message, ex);
            }
        }

        public void AlteraProduto(SqlConnection con, Produto produto)
        {
            // Query para atualizar os campos do produto
            string queryAlterarProduto = @"
        UPDATE Produto 
        SET 
            Nome = @Nome,
            Preco = @Preco,
            Quantidade = @Quantidade,
            Imagem = @Imagem
        WHERE 
            Id = @ProdutoId;";

            try
            {
                // Iniciar uma transação para garantir consistência
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand comandoProduto = new SqlCommand(queryAlterarProduto, con, transaction))
                        {
                            comandoProduto.Parameters.AddWithValue("@Nome", produto.Nome);
                            comandoProduto.Parameters.AddWithValue("@Preco", produto.Preco);
                            comandoProduto.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                            comandoProduto.Parameters.AddWithValue("@Imagem", produto.Imagem ?? (object)DBNull.Value);
                            comandoProduto.Parameters.AddWithValue("@ProdutoId", produto.Id);

                            // Executar o comando
                            int linhasAfetadas = comandoProduto.ExecuteNonQuery();

                            if (linhasAfetadas <= 0)
                            {
                                throw new Exception("Nenhuma linha foi atualizada. Verifique se o ID do produto é válido.");
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
                throw new Exception("Ocorreu um erro ao alterar o produto: " + ex.Message, ex);
            }
        }

        public void AlterarQuantidadeProduto(SqlConnection con, string nomeProduto, int novaQuantidade)
        {
            string query = "UPDATE Produto SET Quantidade = @NovaQuantidade WHERE Nome = @NomeProduto";

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adicionando parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                    cmd.Parameters.AddWithValue("@NovaQuantidade", novaQuantidade);

                    // Executa o comando
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se a atualização foi bem-sucedida
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Quantidade do produto alterada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado ou nenhum dado foi alterado.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a quantidade do produto: " + ex.Message);
            }
        }

    }
}
