using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaDeVeiculos.Model;

namespace VendaDeVeiculos.Service
{
    public class CidadeService
    {

        public CidadeService()
        {

        }


        public int? getIdNovaCidade()
        {
            int? codigo = 0;
            String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("SELECT MAX(CID_ID) AS ID FROM CIDADE;", conn);

            try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro ao abrir conexão com o banco.");
                }
                try
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        if (DBNull.Value.Equals(reader["ID"]))
                        {
                            codigo = 0;
                        }
                        else
                        {
                            codigo = Convert.ToInt32(reader["ID"]);
                        }
                        codigo++;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro ao executar o comando.");
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return codigo;

        }

        public void gravarCidade(Cidade cidade)
        {
            String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("INSERT INTO CIDADE" +
                "(CID_NOME, CID_PAIS, CID_UF)" +
                " VALUES" +
                "(@Nome, @Pais, @UF)", conn);
            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = cidade.CidNome;
            comm.Parameters.Add("@Pais", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Pais"].Value = cidade.CidPais;
            comm.Parameters.Add("@UF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@UF"].Value = cidade.CidUf;
            

            try
            {
                // Abrir a conexão com o banco de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o banco de dados.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Executa o comando SQL para inserir dados na base de dados
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Cidade cadastrada com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();
            }
        }

        public void atualizarCidade(Cidade cidade)
        {
            String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("UPDATE CIDADE SET" +
                " CID_NOME = @Nome, CID_PAIS = @Pais, CID_UF = @UF" +
                " WHERE CID_ID = @Codigo", conn);
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = cidade.CidId;
            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = cidade.CidNome;
            comm.Parameters.Add("@Pais", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Pais"].Value = cidade.CidPais;
            comm.Parameters.Add("@UF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@UF"].Value = cidade.CidUf;

            try
            {
                // Abrir a conexão com o banco de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o banco de dados.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Executa o comando SQL para inserir dados na base de dados
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Cidade atualizada com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();
            }
        }

        public void deletarCidade(Cidade cidade)
        {
            String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("DELETE FROM CIDADE WHERE CID_ID = @Codigo", conn);
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = cidade.CidId;

            try
            {
                // Abrir a conexão com o banco de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o banco de dados.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Executa o comando SQL para inserir dados na base de dados
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Cidade deletada com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                // Fechar a conexão com o banco de dados
                conn.Close();
            }
        }

        public ArrayList pesquisarTodasCidades()
        {
            String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList cidadesPesquisadas = new ArrayList();

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT * FROM CIDADE", conn);

            try
            {
                try
                {
                    // Tentar abrir a conexão com a base de dados
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir a conexão com a base de dados!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    // Executa o comando SQL
                    reader = comm.ExecuteReader();

                    // Se encontrou um registro, repassa os dados para o form
                    while (reader.Read())
                    {
                        Cidade cidade = new Cidade();
                        cidade.CidId = Convert.ToInt32(reader["CID_ID"]);
                        cidade.CidNome = reader["CID_NOME"].ToString();
                        cidade.CidPais = reader["CID_PAIS"].ToString();
                        cidade.CidUf = reader["CID_UF"].ToString();
                        cidadesPesquisadas.Add(cidade);
                    }

                    reader.Close(); // Encerra o leitor de dados 
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com a base de dados
            }
            return cidadesPesquisadas;
        }

        public ArrayList filtrarCidades(Dictionary<string, string> filtros)
        {
            String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList cidadesPesquisadas = new ArrayList();
            string sql = "SELECT * FROM CIDADE WHERE ";

            if (filtros.ContainsKey("cidId"))
            {
                sql += "CID_ID = " + filtros["cidId"];
            }
            else
            {
                List<String> filtrosList = new List<string>();
                
                if (filtros.ContainsKey("cidNome"))
                {
                    filtrosList.Add("CID_NOME LIKE '%" + filtros["cidNome"] + "%' ");
                }
                if (filtros.ContainsKey("cidPais"))
                {
                    filtrosList.Add("CID_PAIS LIKE '%" + filtros["cidPais"] + "%' ");
                }
                if (filtros.ContainsKey("cidUf"))
                {
                    filtrosList.Add("CID_UF LIKE '%" + filtros["cidUf"] + "%' ");
                }

                for(int i = 0; i < filtrosList.Count; i++)
                {
                    sql += filtrosList[i];
                    if(filtrosList.Count > 1 && i != filtrosList.Count - 1)
                    {
                        sql += " AND ";
                    }
                }
            }

            // Cria o comando SQL de consulta
            comm = new SqlCommand(sql, conn);

            try
            {
                try
                {
                    // Tentar abrir a conexão com a base de dados
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir a conexão com a base de dados!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    // Executa o comando SQL
                    reader = comm.ExecuteReader();

                    // Se encontrou um registro, repassa os dados para o form
                    while (reader.Read())
                    {
                        Cidade cidade = new Cidade();
                        cidade.CidId = Convert.ToInt32(reader["CID_ID"]);
                        cidade.CidNome = reader["CID_NOME"].ToString();
                        cidade.CidPais = reader["CID_PAIS"].ToString();
                        cidade.CidUf = reader["CID_UF"].ToString();
                        cidadesPesquisadas.Add(cidade);
                    }

                    reader.Close(); // Encerra o leitor de dados 
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com a base de dados
            }
            return cidadesPesquisadas;

        }
    }
}
