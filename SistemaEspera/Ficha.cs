using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEspera
{
    public class Ficha
    {
        //public Ficha()
        //{
        //SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");

        //}

        public int id { get; set; }
        public int ficha { get; set; }
        public DateTime datta { get; set; }
        public String estado { get; set; }
        public int servico { get; set; }

        public void InsertFicha(Ficha ficha)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand();

                command.Connection = cnn;

                String sql = "insert into TB_FICHA (ficha, datta, servico) VALUES(@ficha, @datta, @servico)";
                command.CommandText = sql;
                cnn.Open();

                command.Parameters.Add("@ficha", SqlDbType.Int).Value = ficha.ficha;
                command.Parameters.Add("@datta", SqlDbType.Date).Value = ficha.datta;
                //command.Parameters.Add("@estado", SqlDbType.Char).Value = ficha.estado;
                command.Parameters.Add("@servico", SqlDbType.Int).Value = ficha.servico;

                command.ExecuteNonQuery();
                command.Parameters.Clear();
                cnn.Close();
               
            }
            catch (Exception ex)
            {

                DialogResult dialogResult = MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        public List<Ficha> SelectFicha( DateTime data, int fich)
        {
            List<Ficha> listFicha = new List<Ficha>();

            try
            {
                String sql = "select * from TB_FICHA where ficha = ('" + fich + "') and estado = ('" + "ON" + "') and datta = ('" + data + "') and servico = ('" + 1 + "')";


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
                        Ficha ficha = new Ficha();

                        ficha.id = Convert.ToInt32(reader["id"].ToString());
                        ficha.estado = reader["estado"].ToString();
                        ficha.ficha = Convert.ToInt32(reader["ficha"].ToString());
                        ficha.datta = Convert.ToDateTime(reader["datta"]);
                        ficha.servico = Convert.ToInt32(reader["servico"].ToString());

                        listFicha.Add(ficha);
                        
                    }
                }
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Select Ficha: " + ex.Message);
            }

            return listFicha;
        }

        public List<Ficha> SelectFicha(DateTime data, String estado, int servico)
        {
            List<Ficha> listFicha = new List<Ficha>();

            try
            {
                String sql = "select * from TB_FICHA where estado = ('" + estado + "') and datta = ('" + data + "') and servico = ('" + servico + "')";


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
                        Ficha ficha = new Ficha();

                        ficha.id = Convert.ToInt32(reader["id"].ToString());
                        ficha.estado = reader["estado"].ToString();
                        ficha.ficha = Convert.ToInt32(reader["ficha"].ToString());
                        ficha.datta = Convert.ToDateTime(reader["datta"]);
                        ficha.servico = Convert.ToInt32(reader["servico"].ToString());

                        listFicha.Add(ficha);

                    }
                }
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Select Ficha: " + ex.Message);
            }

            return listFicha;
        }

        public void updateFicha(int Idficha, int servico)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand();

                command.CommandText = "update TB_FICHA set estado = 'OFF' where id = ('" + Idficha + "')";
                command.Connection = cnn;
                cnn.Open();

                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Update Ficha: " + ex.Message);
            }
        }

            public List<Ficha> SelectFicha(DateTime data, int IdFicha, int servico)
            {
                List<Ficha> listFicha = new List<Ficha>();

                try
                {
                    String sql = "select * from TB_FICHA where id = ('" + IdFicha + "') and datta = ('" + data + "') and servico = ('" + servico + "')";


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
                            Ficha ficha = new Ficha();

                            ficha.id = Convert.ToInt32(reader["id"].ToString());
                            ficha.estado = reader["estado"].ToString();
                            ficha.ficha = Convert.ToInt32(reader["ficha"].ToString());
                            ficha.datta = Convert.ToDateTime(reader["datta"]);
                            ficha.servico = Convert.ToInt32(reader["servico"].ToString());

                            listFicha.Add(ficha);

                        }
                    }
                    cnn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro Select Ficha: " + ex.Message);
                }

                return listFicha;
            }

        public List<Ficha> SelectFicha(DateTime data)
        {
            List<Ficha> listFicha = new List<Ficha>();

            try
            {
                String sql = "select * from TB_FICHA where datta = ('" + data + "')";


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
                        Ficha ficha = new Ficha();

                        ficha.id = Convert.ToInt32(reader["id"].ToString());
                        ficha.estado = reader["estado"].ToString();
                        ficha.ficha = Convert.ToInt32(reader["ficha"].ToString());
                        ficha.datta = Convert.ToDateTime(reader["datta"]);
                        ficha.servico = Convert.ToInt32(reader["servico"].ToString());

                        listFicha.Add(ficha);

                    }
                }
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Select Ficha: " + ex.Message);
            }

            return listFicha;
        }

        public Ficha selectFichPBalcao(DateTime data, String estado, int servico)
        {
            Called call = new Called();
            Ficha ficha = new Ficha();

            int fichaId;
            
            if (call.SelectCalled(data, estado, servico).Count > 0)
            {
                fichaId = Convert.ToInt32(call.SelectCalled(data, estado, servico)[0].fichaId.ToString());



                if (ficha.SelectFicha(data, fichaId, servico).Count > 0)
                {
                    ficha.id = Convert.ToInt32(ficha.SelectFicha(data, fichaId, servico)[0].id.ToString());
                    ficha.ficha = Convert.ToInt32(ficha.SelectFicha(data, fichaId, servico)[0].ficha.ToString());
                }

            }

            return ficha;

        }

    }
}
