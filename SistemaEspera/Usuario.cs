using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SistemaEspera
{
    public class Usuario
    {
        public int id { get; set; }
        public String estado { get; set; }
        public String cargo { get; set; }
        public DateTime data { get; set; }
        public int servico { get; set; }


        public void insertUser(DateTime data, int servico)
        {

            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand();

                command.CommandText = "insert into USUARIO(estado, datta, servico) VALUES(@estado, @datta, @servico)";


                command.Connection = cnn;

                command.Parameters.Add("@estado", SqlDbType.Char).Value = "on";
                command.Parameters.Add("@datta", SqlDbType.Date).Value = data;
                command.Parameters.Add("@servico", SqlDbType.VarChar).Value = 1;

                cnn.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro insert User: " + ex.Message);
            }
        }

        public List<Usuario> SelectUser(DateTime data, int servico)
        {
            List<Usuario> listUser = new List<Usuario>();
            
            try
            {

                String sql = "select * from USUARIO where estado = ('" + "on" + "') and datta = ('" + data + "') and servico = ('" + servico + "')";

                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand(sql);
                command.Connection = cnn;
                command.CommandText = sql;
                cnn.Open();
                             
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario user = new Usuario();
                        user.id = Convert.ToInt32(reader["id"].ToString());
                        user.cargo = reader["cargo"].ToString();
                        user.estado = reader["estado"].ToString();
                        user.data = Convert.ToDateTime(reader["datta"]);
                        user.servico = Convert.ToInt32(reader["servico"].ToString());

                        listUser.Add(user);
                    }
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);                
            }

            return listUser;
        }

    }
}
