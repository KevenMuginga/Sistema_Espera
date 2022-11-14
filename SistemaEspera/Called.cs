using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEspera
{
    public class Called
    {
        public int id { get; set; }
        public int fichaId { get; set; }
        public String estado { get; set; }
        public DateTime datta { get; set; }
        public int servicoId { get; set; }

        public void insertCalled(int ficha, DateTime data, int servico)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand();

                String sqlCall = "insert into TB_CALLED(ficha, datta, servico) VALUES(@fichaId, @datta, @servico)";

                command.CommandText = sqlCall;
                command.Connection = cnn;

                cnn.Open();
                command.Parameters.Add("@fichaId", SqlDbType.Int).Value = ficha;
                command.Parameters.Add("@datta", SqlDbType.Date).Value = data;
                command.Parameters.Add("@servico", SqlDbType.Int).Value = servico;

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro insert Called: " + ex.Message);
            }
        }

        public void updateCalled(int IdFicha, int servico)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand();

                command.CommandText = "update TB_CALLED set estado = 'CALLED' where NOT ficha = ('" + IdFicha + "') and servico = ('" + servico + "')";
                command.Connection = cnn;

                cnn.Open();

                command.ExecuteNonQuery();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro update Called: " + ex.Message);
            }
        }

        public List<Called> SelectCalled(DateTime data, String estado)
        {
            List<Called> called = new List<Called>();

            try
            {
                String sql = "select * from TB_CALLED where estado = ('" + estado + "') and datta = ('" + data + "')";


                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand(sql);

                cnn.Open();

                command.CommandText = sql;
                command.Connection = cnn;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Called call = new Called();

                        call.id = Convert.ToInt32(reader["id"].ToString());
                        call.estado = reader["estado"].ToString();
                        call.fichaId = Convert.ToInt32(reader["ficha"].ToString());
                        call.datta = Convert.ToDateTime(reader["datta"]);
                        call.servicoId = Convert.ToInt32(reader["servico"].ToString());

                        called.Add(call);
                    }
                }
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Select Ficha: " + ex.Message);
            }

            return called;
        }


        public List<Called> SelectCalled(DateTime data, String estado, int servico)
        {
            List<Called> called = new List<Called>();

            try
            {
                String sql = "select * from TB_CALLED where estado = ('" + estado + "') and datta = ('" + data + "') and servico = ('" + servico + "')";


                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand(sql);

                cnn.Open();

                command.CommandText = sql;
                command.Connection = cnn;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Called call = new Called();

                        call.id = Convert.ToInt32(reader["id"].ToString());
                        call.estado = reader["estado"].ToString();
                        call.fichaId = Convert.ToInt32(reader["ficha"].ToString());
                        call.datta = Convert.ToDateTime(reader["datta"]);
                        call.servicoId = Convert.ToInt32(reader["servico"].ToString());

                        called.Add(call);
                    }
                }
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Select Ficha: " + ex.Message);
            }

            return called;
        }
    }
}
