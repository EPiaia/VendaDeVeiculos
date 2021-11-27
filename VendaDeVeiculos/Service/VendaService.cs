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
    class VendaService
    {
        private String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;
        private ClienteService cs = new ClienteService();
        private VendedorService vs = new VendedorService();
        private VeiculoService ves = new VeiculoService();

        public int? getIdNovaVenda()
        {
            int? codigo = 0;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("SELECT MAX(VEN_ID) AS ID FROM VENDA;", conn);

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

        public void gravarVenda(Venda venda)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("INSERT INTO VENDA" +
                "(VEN_CLIENTE, VEN_VENDEDOR, VEN_VEICULO, VEN_DATA, VEN_TOTAL," +
                " VEN_ADICIONAIS, VEN_TRIBUTOS, VEN_DESCONTOS, VEN_PAGAMENTO)" +
                " VALUES" +
                "(@Cliente, @Vendedor, @Veiculo, @Data, @Total, @Adicionais," +
                " @Tributos, @Descontos, @Pagamento)", conn);
            comm.Parameters.Add("@Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Cliente"].Value = venda.VenCliente.CliId;
            comm.Parameters.Add("@Vendedor", System.Data.SqlDbType.Int);
            comm.Parameters["@Vendedor"].Value = venda.VenVendedor.VdrId;
            comm.Parameters.Add("@Veiculo", System.Data.SqlDbType.Int);
            comm.Parameters["@Veiculo"].Value = venda.VenVeiculo.VclId;
            comm.Parameters.Add("@Data", System.Data.SqlDbType.DateTime);
            comm.Parameters["@Data"].Value = DateTime.Now;
            comm.Parameters.Add("@Total", System.Data.SqlDbType.Float);
            comm.Parameters["@Total"].Value = venda.VenTotal;
            comm.Parameters.Add("@Adicionais", System.Data.SqlDbType.Float);
            comm.Parameters["@Adicionais"].Value = venda.VenAdicionais;
            comm.Parameters.Add("@Tributos", System.Data.SqlDbType.Float);
            comm.Parameters["@Tributos"].Value = venda.VenTributos;
            comm.Parameters.Add("@Descontos", System.Data.SqlDbType.Float);
            comm.Parameters["@Descontos"].Value = venda.VenDescontos;
            comm.Parameters.Add("@Pagamento", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Pagamento"].Value = venda.VenPagamento;

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
                    MessageBox.Show("Venda cadastrada com sucesso!");
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

        public void atualizarVenda(Venda venda)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("UPDATE VENDA" +
                " SET VEN_CLIENTE = @Cliente, SET VEN_VENDEDOR = @Vendedor, " +
                " SET VEN_VEICULO = @Veiculo, SET VEN_DATA= @Data, SET VEN_TOTAL = @Total," +
                " SET VEN_ADICIONAIS = @Adicionais, SET VEN_TRIBUTOS = @Tributos," +
                " SET VEN_DESCONTOS = @Descontos, SET VEN_PAGAMENTO = @Pagamento", conn);
            comm.Parameters.Add("@Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@Cliente"].Value = venda.VenCliente.CliId;
            comm.Parameters.Add("@Vendedor", System.Data.SqlDbType.Int);
            comm.Parameters["@Vendedor"].Value = venda.VenVendedor.VdrId;
            comm.Parameters.Add("@Veiculo", System.Data.SqlDbType.Int);
            comm.Parameters["@Veiculo"].Value = venda.VenVeiculo.VclId;
            comm.Parameters.Add("@Data", System.Data.SqlDbType.DateTime);
            comm.Parameters["@Data"].Value = DateTime.Now;
            comm.Parameters.Add("@Total", System.Data.SqlDbType.Float);
            comm.Parameters["@Total"].Value = venda.VenTotal;
            comm.Parameters.Add("@Adicionais", System.Data.SqlDbType.Float);
            comm.Parameters["@Adicionais"].Value = venda.VenAdicionais;
            comm.Parameters.Add("@Tributos", System.Data.SqlDbType.Float);
            comm.Parameters["@Tributos"].Value = venda.VenTributos;
            comm.Parameters.Add("@Descontos", System.Data.SqlDbType.Float);
            comm.Parameters["@Descontos"].Value = venda.VenDescontos;
            comm.Parameters.Add("@Pagamento", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Pagamento"].Value = venda.VenPagamento;

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
                    MessageBox.Show("Venda atualizada com sucesso!");
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

        public void deletarVenda(Venda venda)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("DELETE FROM VENDA WHERE VEN_ID = @Codigo", conn);
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = venda.VenId;

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
                    MessageBox.Show("Venda deletada com sucesso!");
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

        public ArrayList pesquisarTodasVendas()
        {

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList vendasPesquisadas = new ArrayList();

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT * FROM VENDA", conn);
            /* Não vale a pena fazer um inner join, porque são cinco tabelas (cliente, vendedor
             * veículo, cidade do cliente e cidade do vendedor) e o código ficaria
             * muito extenso, dessa forma vale mais fazer pequenas consultas ao banco
            */
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
                        Venda venda = new Venda();
                        Dictionary<string, string> filtros = new Dictionary<string, string>();
                        venda.VenId = Convert.ToInt32(reader["VEN_ID"]);      
                        filtros.Add("cliId", reader["VEN_CLIENTE"].ToString());
                        venda.VenCliente = (Cliente) cs.filtrarClientes(filtros)[0];
                        filtros.Clear();
                        filtros.Add("vdrId", reader["VEN_VENDEDOR"].ToString());
                        venda.VenVendedor = (Vendedor)vs.filtrarVendedores(filtros)[0];
                        filtros.Clear();
                        filtros.Add("vclId", reader["VEN_VEICULO"].ToString());
                        venda.VenVeiculo = (Veiculo)ves.filtrarVeiculos(filtros)[0];
                        venda.VenData = Convert.ToDateTime(reader["VEN_DATA"]);
                        venda.VenTotal = Convert.ToDouble(reader["VEN_TOTAL"]);
                        venda.VenAdicionais = Convert.ToDouble(reader["VEN_ADICIONAIS"]);
                        venda.VenTributos = Convert.ToDouble(reader["VEN_TRIBUTOS"]);
                        venda.VenDescontos = Convert.ToDouble(reader["VEN_DESCONTOS"]);
                        venda.VenPagamento = reader["VEN_PAGAMENTO"].ToString();
                        vendasPesquisadas.Add(venda);
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
            return vendasPesquisadas;
        }

        public ArrayList filtrarVendas(Dictionary<string, string> filtros)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList vendasPesquisadas = new ArrayList();
            string sql = "SELECT * FROM VENDA WHERE ";

            if (filtros.ContainsKey("venId"))
            {
                sql += "VEN_ID = " + filtros["venId"];
            }
            else
            {
                List<string> filtrosList = new List<string>();
                if (filtros.ContainsKey("venCli"))
                {
                    filtrosList.Add("VEN_CLIENTE = " + filtros["venCli"]);
                }
                if (filtros.ContainsKey("venVdr"))
                {
                    filtrosList.Add("VEN_VENDEDOR = " + filtros["venVdr"]);
                }
                if (filtros.ContainsKey("venVcl"))
                {
                    filtrosList.Add("VEN_VEICULO = " + filtros["venVcl"]);
                }
                if (filtros.ContainsKey("venDataIni"))
                {
                    filtrosList.Add("VEN_DATA >= " + filtros["venDataIni"]);
                }
                if (filtros.ContainsKey("venDataFim"))
                {
                    filtrosList.Add("VEN_DATA <= " + filtros["venDataFim"]);
                }
                if (filtros.ContainsKey("venTotal"))
                {
                    filtrosList.Add("VEN_TOTAL <= " + filtros["venTotal"]);
                }
                for (int i = 0; i < filtrosList.Count; i++)
                {
                    sql += filtrosList[i];
                    if (filtrosList.Count > 1 && i != filtrosList.Count - 1)
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
                        Venda venda = new Venda();
                        Dictionary<string, string> filtrosVenda = new Dictionary<string, string>();
                        venda.VenId = Convert.ToInt32(reader["VEN_ID"]);
                        filtrosVenda.Add("cliId", reader["VEN_CLIENTE"].ToString());
                        venda.VenCliente = (Cliente)cs.filtrarClientes(filtrosVenda)[0];
                        filtrosVenda.Clear();
                        filtrosVenda.Add("vdrId", reader["VEN_VENDEDOR"].ToString());
                        venda.VenVendedor = (Vendedor)vs.filtrarVendedores(filtrosVenda)[0];
                        filtrosVenda.Clear();
                        filtrosVenda.Add("vclId", reader["VEN_VEICULO"].ToString());
                        venda.VenVeiculo = (Veiculo)ves.filtrarVeiculos(filtrosVenda)[0];
                        venda.VenData = Convert.ToDateTime(reader["VEN_DATA"]);
                        venda.VenTotal = Convert.ToDouble(reader["VEN_TOTAL"]);
                        venda.VenAdicionais = Convert.ToDouble(reader["VEN_ADICIONAIS"]);
                        venda.VenTributos = Convert.ToDouble(reader["VEN_TRIBUTOS"]);
                        venda.VenDescontos = Convert.ToDouble(reader["VEN_DESCONTOS"]);
                        venda.VenPagamento = reader["VEN_PAGAMENTO"].ToString();
                        vendasPesquisadas.Add(venda);
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
            return vendasPesquisadas;

        }

    }
}
