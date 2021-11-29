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

    class VeiculoService
    {

        private String connString = Properties.Settings.Default.vendaDeVeiculosConnectionString;

        public VeiculoService()
        {

        }

        public int? getIdNovoVeiculo()
        {
            int? codigo = 0;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("SELECT MAX(VCL_ID) AS ID FROM VEICULO;", conn);

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

        public void gravarVeiculo(Veiculo veiculo)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("INSERT INTO VEICULO" +
                "(VCL_CHASSI, VCL_MOTOR, VCL_MODELO, VCL_MARCA, VCL_TIPO, VCL_USADO," +
                " VCL_KM, VCL_COMPLEMENTO, VCL_VALOR, VCL_VENDIDO)" +
                " VALUES" +
                "(@Chassi, @Motor, @Modelo, @Marca, @Tipo, @Usado," +
                " @Km, @Complemento, @Valor, @Vendido)", conn);
            comm.Parameters.Add("@Chassi", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Chassi"].Value = veiculo.VclChassi;
            comm.Parameters.Add("@Motor", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Motor"].Value = veiculo.VclMotor;
            comm.Parameters.Add("@Modelo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Modelo"].Value = veiculo.VclModelo;
            comm.Parameters.Add("@Marca", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Marca"].Value = veiculo.VclMarca;
            comm.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Tipo"].Value = veiculo.VclTipo;
            comm.Parameters.Add("@Usado", System.Data.SqlDbType.Int);
            comm.Parameters["@Usado"].Value = veiculo.getBitUsado();
            comm.Parameters.Add("@Km", System.Data.SqlDbType.Float);
            comm.Parameters["@Km"].Value = veiculo.VclKm;
            comm.Parameters.Add("@Complemento", System.Data.SqlDbType.Text);
            comm.Parameters["@Complemento"].Value = veiculo.VclComplemento;
            comm.Parameters.Add("@Valor", System.Data.SqlDbType.Float);
            comm.Parameters["@Valor"].Value = veiculo.VclValor;
            comm.Parameters.Add("@Vendido", System.Data.SqlDbType.Int);
            comm.Parameters["@Vendido"].Value = veiculo.getBitVendido();

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
                    MessageBox.Show("Veículo cadastrado com sucesso!");
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

        public void atualizarVeiculo(Veiculo veiculo)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("UPDATE VEICULO" +
                " SET VCL_CHASSI = @Chassi, VCL_MOTOR = @Motor, VCL_MODELO = @Modelo," +
                " VCL_MARCA = @Marca, VCL_TIPO = @Tipo, VCL_USADO = @Usado, VCL_KM = @Km," +
                " VCL_COMPLEMENTO = @Complemento, VCL_VALOR = @Valor, VCL_VENDIDO = @Vendido", conn);
            comm.Parameters.Add("@Chassi", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Chassi"].Value = veiculo.VclChassi;
            comm.Parameters.Add("@Motor", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Motor"].Value = veiculo.VclMotor;
            comm.Parameters.Add("@Modelo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Modelo"].Value = veiculo.VclModelo;
            comm.Parameters.Add("@Marca", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Marca"].Value = veiculo.VclMarca;
            comm.Parameters.Add("@Tipo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Tipo"].Value = veiculo.VclTipo;
            comm.Parameters.Add("@Usado", System.Data.SqlDbType.Int);
            comm.Parameters["@Usado"].Value = veiculo.getBitUsado();
            comm.Parameters.Add("@Km", System.Data.SqlDbType.Float);
            comm.Parameters["@Km"].Value = veiculo.VclKm;
            comm.Parameters.Add("@Complemento", System.Data.SqlDbType.Text);
            comm.Parameters["@Complemento"].Value = veiculo.VclComplemento;
            comm.Parameters.Add("@Valor", System.Data.SqlDbType.Float);
            comm.Parameters["@Valor"].Value = veiculo.VclValor;
            comm.Parameters.Add("@Vendido", System.Data.SqlDbType.Int);
            comm.Parameters["@Vendido"].Value = veiculo.getBitVendido();

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
                    MessageBox.Show("Veículo atualizado com sucesso!");
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

        public void deletarVeiculo(Veiculo veiculo)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("DELETE FROM VEICULO WHERE VCL_ID = @Codigo", conn);
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = veiculo.VclId;

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
                    MessageBox.Show("Veículo deletado com sucesso!");
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

        public ArrayList pesquisarTodosVeiculos()
        {

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList veiculosPesquisados = new ArrayList();

            // Cria o comando SQL de consulta
            comm = new SqlCommand(
                "SELECT * FROM VEICULO", conn);

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
                        Veiculo veiculo = new Veiculo();
                        veiculo.VclId = Convert.ToInt32(reader["VCL_ID"]);
                        veiculo.VclChassi = reader["VCL_CHASSI"].ToString();
                        veiculo.VclMotor = reader["VCL_MOTOR"].ToString();
                        veiculo.VclModelo = reader["VCL_MODELO"].ToString();
                        veiculo.VclMarca = reader["VCL_MARCA"].ToString();
                        veiculo.VclTipo = reader["VCL_TIPO"].ToString();
                        veiculo.setUsadoPorBit(Convert.ToInt32(reader["VCL_USADO"]));
                        veiculo.VclKm = Convert.ToDouble(reader["VCL_KM"]);
                        veiculo.VclComplemento = reader["VCL_COMPLEMENTO"].ToString();
                        veiculo.VclValor = Convert.ToDouble(reader["VCL_VALOR"]);
                        veiculo.setVendidoPorBit(Convert.ToInt32(reader["VCL_VENDIDO"]));
                        veiculosPesquisados.Add(veiculo);
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
            return veiculosPesquisados;
        }

        public ArrayList filtrarVeiculos(Dictionary<string, string> filtros)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm;
            SqlDataReader reader;
            ArrayList veiculosPesquisados = new ArrayList();
            string sql = "SELECT * FROM VEICULO";

            if (filtros.ContainsKey("vclId"))
            {
                sql += " WHERE VCL_ID = " + filtros["vclId"];
            }
            else
            {
                List<string> filtrosList = new List<string>();
                if (filtros.ContainsKey("vclModelo"))
                {
                    filtrosList.Add("VCL_MODELO LIKE '%" + filtros["vclModelo"] + "%'");
                }
                if (filtros.ContainsKey("vclMarca"))
                {
                    filtrosList.Add("VCL_MARCA LIKE '%" + filtros["vclMarca"] + "%'");
                }
                if (filtros.ContainsKey("vclTipo"))
                {
                    filtrosList.Add("VCL_TIPO LIKE '%" + filtros["vclTipo"] + "%'");
                }
                if (filtros.ContainsKey("vclUsado"))
                {
                    filtrosList.Add("VCL_USADO = " + filtros["vclUsado"]);
                }
                if (filtros.ContainsKey("vclKm"))
                {
                    filtrosList.Add("VCL_KM <= " + filtros["vclKm"]);
                }
                if (filtros.ContainsKey("vclValor"))
                {
                    filtrosList.Add("VCL_VALOR <= " + filtros["vclValor"]);
                }
                if (filtros.ContainsKey("vclVendido"))
                {
                    filtrosList.Add("VCL_VENDIDO = " + filtros["vclVendido"]);
                }
                sql += filtrosList.Count > 0 ? " WHERE " : "";
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
                        Veiculo veiculo = new Veiculo();
                        veiculo.VclId = Convert.ToInt32(reader["VCL_ID"]);
                        veiculo.VclChassi = reader["VCL_CHASSI"].ToString();
                        veiculo.VclMotor = reader["VCL_MOTOR"].ToString();
                        veiculo.VclModelo = reader["VCL_MODELO"].ToString();
                        veiculo.VclMarca = reader["VCL_MARCA"].ToString();
                        veiculo.VclTipo = reader["VCL_TIPO"].ToString();
                        veiculo.setUsadoPorBit(Convert.ToInt32(reader["VCL_USADO"]));
                        veiculo.VclKm = Convert.ToDouble(reader["VCL_KM"]);
                        veiculo.VclComplemento = reader["VCL_COMPLEMENTO"].ToString();
                        veiculo.VclValor = Convert.ToDouble(reader["VCL_VALOR"]);
                        veiculo.setVendidoPorBit(Convert.ToInt32(reader["VCL_VENDIDO"]));
                        veiculosPesquisados.Add(veiculo);
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
            return veiculosPesquisados;

        }

    }
}
