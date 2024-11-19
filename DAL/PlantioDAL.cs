using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlantioDAL :SqlHelper
    {
        public List<Plantio> BuscaListaPlantio(SqlConnection con)
        {
            string query = "SELECT * FROM Plantio";
            List<Plantio> listaPlan = new List<Plantio>();

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Plantio objPlantio = new Plantio
                            {
                                Id = Convert.ToInt32(dr["Id"]), // ID do produto
                                NomeProduto = dr["NomeProduto"].ToString(), // Nome do produto
                                Status = dr["Status"] != DBNull.Value ? dr["Status"].ToString() : null, // Status do plantio
                                Quantidade = dr["Quantidade"] != DBNull.Value ? Convert.ToInt32(dr["Quantidade"]) : 0, // Quantidade em estoque
                                FazendaId = dr["FazendaId"] != DBNull.Value ? Convert.ToInt32(dr["FazendaId"]) : 0, // ID da fazenda
                                NomePlantio = dr["NomePlantio"] != DBNull.Value ? dr["NomePlantio"].ToString() : null, // Nome do plantio
                                DataPlantacao = (DateTime)(dr["DataPlantacao"] != DBNull.Value ? Convert.ToDateTime(dr["DataPlantacao"]) : (DateTime?)null), // Data da plantação
                                DataColheita = (DateTime)(dr["DataColheita"] != DBNull.Value ? Convert.ToDateTime(dr["DataColheita"]) : (DateTime?)null), // Data da colheita
                                Imagem = dr["Imagem"] != DBNull.Value ? dr["Imagem"].ToString() : null // Caminho ou URL da imagem
                            };


                            // Adiciona o objeto à lista
                            listaPlan.Add(objPlantio);
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
                throw new Exception("Ocorreu um erro ao listar os Plantio: " + ex.Message, ex);
            }

            // Retorna a lista de funcionários
            return listaPlan;
        }
        public List<Plantio> BuscaListaPlantioImagem(SqlConnection con)
        {
            string query = "SELECT * FROM Plantio";
            List<Plantio> listaPlan = new List<Plantio>();

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Plantio objPlantio = new Plantio
                            {
                                Id = Convert.ToInt32(dr["Id"]), // ID do produto
                                NomePlantio = dr["NomePlantio"].ToString(),
                                Imagem = dr["Imagem"].ToString() // Caminho ou URL da imagem
                            };


                            // Adiciona o objeto à lista
                            listaPlan.Add(objPlantio);
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
                throw new Exception("Ocorreu um erro ao listar os Plantio: " + ex.Message, ex);
            }

            // Retorna a lista de funcionários
            return listaPlan;
        }

        public void AtualizarPlantio(SqlConnection con, Plantio plantio)
        {
            string query = "UPDATE Plantio SET " +
                           "Status = @Status, " +
                           "NomeProduto = @NomeProduto, "+
                           "Quantidade = @Quantidade, " +
                           "FazendaId = @FazendaId, " +
                           "DataPlantacao = @DataPlantacao, " +
                           "DataColheita = @DataColheita, " +
                           "Imagem = @Imagem " +
                           "WHERE NomePlantio = @NomePlantio"; // Filtrando pelo NomePlantio

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Definindo os parâmetros para prevenir SQL Injection
                    cmd.Parameters.AddWithValue("@NomeProduto", plantio.NomeProduto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", plantio.Status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Quantidade", plantio.Quantidade ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@FazendaId", plantio.FazendaId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataPlantacao", plantio.DataPlantacao ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataColheita", plantio.DataColheita ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Imagem", plantio.Imagem ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NomePlantio", plantio.NomePlantio);

                    // Executa o comando para atualizar o plantio no banco
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Erro ao acessar o banco de dados: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar o Plantio: " + ex.Message, ex);
            }
        }

        public Plantio BuscarPlantioPorNome(SqlConnection con, string nomePlantio)
        {
            string query = "SELECT * FROM Plantio WHERE NomePlantio = @NomePlantio";
            Plantio plantioEncontrado = null;

            try
            {
                // Usando "using" para gerenciar recursos
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adicionando o parâmetro para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@NomePlantio", nomePlantio);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read()) // Busca o primeiro registro correspondente
                        {
                            plantioEncontrado = new Plantio
                            {
                                Id = Convert.ToInt32(dr["Id"]), // ID do plantio
                                NomePlantio = dr["NomePlantio"].ToString(),
                                NomeProduto = dr["NomeProduto"] != DBNull.Value ? dr["NomeProduto"].ToString() : null,
                                Status = dr["Status"] != DBNull.Value ? dr["Status"].ToString() : null,
                                Quantidade = dr["Quantidade"] != DBNull.Value ? Convert.ToInt32(dr["Quantidade"]) : 0,
                                FazendaId = dr["FazendaId"] != DBNull.Value ? Convert.ToInt32(dr["FazendaId"]) : 0,
                                DataPlantacao = dr["DataPlantacao"] != DBNull.Value ? Convert.ToDateTime(dr["DataPlantacao"]) : DateTime.MinValue,
                                DataColheita = dr["DataColheita"] != DBNull.Value ? Convert.ToDateTime(dr["DataColheita"]) : DateTime.MinValue,
                                Imagem = dr["Imagem"] != DBNull.Value ? dr["Imagem"].ToString() : null
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
                throw new Exception("Ocorreu um erro ao buscar o Plantio: " + ex.Message, ex);
            }

            // Retorna o plantio encontrado ou null caso nenhum seja encontrado
            return plantioEncontrado;
        }


    }
}
