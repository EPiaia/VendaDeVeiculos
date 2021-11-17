using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void gravarCliente(Model.Cliente cliente)
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

    }
}
