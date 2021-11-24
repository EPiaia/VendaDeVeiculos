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
    class ClienteService
    {

        private String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;

        public ClienteService()
        {

        }

        public int? getIdNovoCliente()
        {
            int? codigo = 0;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("SELECT MAX(CLI_ID) AS ID FROM CLIENTE;", conn);

            try
            {
                try
                {
                    conn.Open();
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro ao abrir conexão com o banco.");
                }
                try
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        if (DBNull.Value.Equals(reader["ID"])){
                            codigo = 0;
                        } else
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
            catch{ }
            finally
            {
                conn.Close();
            }
            return codigo;

        }

        public void gravarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("INSERT INTO CLIENTE" +
                "(CLI_NOME, CLI_CPFCNPJ, CLI_CIDADE, CLI_BAIRRO, CLI_LOGRADOURO, CLI_NUM, CLI_COMPL," +
                "CLI_EMAIL, CLI_FONE, CLI_NASCIMENTO)" +
                " VALUES" +
                "(@Nome, @CpfCnpj, @Cidade, @Bairro, @Logradouro, @Num, @Compl, @Email, @Fone, @Nasc)", conn);
            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = cliente.CliNome;
            comm.Parameters.Add("@CpfCnpj", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CpfCnpj"].Value = cliente.CliCpfCnpj;
            comm.Parameters.Add("@Cidade", System.Data.SqlDbType.Int);
           // comm.Parameters["@Cidade"].Value = cliente.CliCidade.CidId;
            comm.Parameters["@Cidade"].Value = DBNull.Value;
            comm.Parameters.Add("@Bairro", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Bairro"].Value = cliente.CliBairro;
            comm.Parameters.Add("@Logradouro", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Logradouro"].Value = cliente.CliLogradouro;
            comm.Parameters.Add("@Num", System.Data.SqlDbType.Int);
            comm.Parameters["@Num"].Value = cliente.CliNum;
            comm.Parameters.Add("@Compl", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Compl"].Value = cliente.CliCompl;
            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = cliente.CliEmail;
            comm.Parameters.Add("@Fone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Fone"].Value = cliente.CliFone;
            comm.Parameters.Add("@Nasc", System.Data.SqlDbType.Date);
            comm.Parameters["@Nasc"].Value = cliente.CliNascimento.Date;

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
                    MessageBox.Show("Cliente cadastrado com sucesso!");
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

        public void atualizarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("UPDATE CLIENTE SET" +
                " CLI_NOME = @Nome, CLI_CPFCNPJ = @CpfCnpj, CLI_CIDADE = @Cidade, CLI_BAIRRO = @Bairro, " +
                "CLI_LOGRADOURO = @Logradouro, CLI_NUM = @Num, CLI_COMPL = @Compl," +
                "CLI_EMAIL = @Email, CLI_FONE = @Fone, CLI_NASCIMENTO = @Nasc" +
                " WHERE CLI_ID = @Codigo", conn);
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = cliente.CliId;
            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = cliente.CliNome;
            comm.Parameters.Add("@CpfCnpj", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CpfCnpj"].Value = cliente.CliCpfCnpj;
            comm.Parameters.Add("@Cidade", System.Data.SqlDbType.Int);
            // comm.Parameters["@Cidade"].Value = cliente.CliCidade.CidId;
            comm.Parameters["@Cidade"].Value = DBNull.Value;
            comm.Parameters.Add("@Bairro", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Bairro"].Value = cliente.CliBairro;
            comm.Parameters.Add("@Logradouro", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Logradouro"].Value = cliente.CliLogradouro;
            comm.Parameters.Add("@Num", System.Data.SqlDbType.Int);
            comm.Parameters["@Num"].Value = cliente.CliNum;
            comm.Parameters.Add("@Compl", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Compl"].Value = cliente.CliCompl;
            comm.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Email"].Value = cliente.CliEmail;
            comm.Parameters.Add("@Fone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Fone"].Value = cliente.CliFone;
            comm.Parameters.Add("@Nasc", System.Data.SqlDbType.Date);
            comm.Parameters["@Nasc"].Value = cliente.CliNascimento.Date;

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
                    MessageBox.Show("Cliente atualizado com sucesso!");
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

        public void deletarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("DELETE FROM CLIENTE WHERE CLI_ID = @Codigo", conn);
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = cliente.CliId;

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
                    MessageBox.Show("Cliente deletado com sucesso!");
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

        public ArrayList pesquisarTodosClientes()
        {

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList clientesPesquisados = new ArrayList();

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT * FROM Cliente", conn);

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
                        Cliente cliente = new Cliente();
                        cliente.CliId = Convert.ToInt32(reader["CLI_ID"]);
                        cliente.CliNome = reader["CLI_NOME"].ToString();
                        cliente.CliCpfCnpj = reader["CLI_CPFCNPJ"].ToString();
                        // cliente.CliCidade = reader["Cidade"].ToString();
                        cliente.CliBairro = reader["CLI_BAIRRO"].ToString();
                        cliente.CliLogradouro = reader["CLI_LOGRADOURO"].ToString();
                        cliente.CliNum = Convert.ToInt32(reader["CLI_NUM"]);
                        cliente.CliCompl = reader["CLI_COMPL"].ToString();
                        cliente.CliEmail = reader["CLI_EMAIL"].ToString();
                        cliente.CliFone = reader["CLI_FONE"].ToString();
                        cliente.CliNascimento = Convert.ToDateTime(reader["CLI_NASCIMENTO"]);
                        clientesPesquisados.Add(cliente);
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
            return clientesPesquisados;
        }

        public ArrayList filtrarClientes(Dictionary<string, string> filtros)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList clientesPesquisados = new ArrayList();
            string sql = "SELECT * FROM CLIENTE WHERE ";

            if (filtros.ContainsKey("cliId"))
            {
                sql += "CLI_ID = " + filtros["cliId"];
            } else
            {
                bool addAnd = filtros.ContainsKey("cliNome") && filtros.ContainsKey("cliCpfCnpj");
                if (filtros.ContainsKey("cliNome"))
                {
                    sql += "CLI_NOME LIKE '%" + filtros["cliNome"] + "%' ";
                }
                if (addAnd)
                {
                    sql += "AND ";
                }
                if (filtros.ContainsKey("cliCpfCnpj"))
                {
                    sql += "CLI_CPFCNPJ LIKE '%" + filtros["cliCpfCnpj"] + "%'";
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
                    if (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.CliId = Convert.ToInt32(reader["CLI_ID"]);
                        cliente.CliNome = reader["CLI_NOME"].ToString();
                        cliente.CliCpfCnpj = reader["CLI_CPFCNPJ"].ToString();
                        // cliente.CliCidade = reader["Cidade"].ToString();
                        cliente.CliBairro = reader["CLI_BAIRRO"].ToString();
                        cliente.CliLogradouro = reader["CLI_LOGRADOURO"].ToString();
                        cliente.CliNum = Convert.ToInt32(reader["CLI_NUM"]);
                        cliente.CliCompl = reader["CLI_COMPL"].ToString();
                        cliente.CliEmail = reader["CLI_EMAIL"].ToString();
                        cliente.CliFone = reader["CLI_FONE"].ToString();
                        cliente.CliNascimento = Convert.ToDateTime(reader["CLI_NASCIMENTO"]);
                        clientesPesquisados.Add(cliente);
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
            return clientesPesquisados;

        }

    }
}
