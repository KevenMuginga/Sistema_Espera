using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEspera
{
    public class Balcao
    {
        public int fichaId { get; set; }
        public int userId { get; set; }

        public void insertBalcao(int user, int ficha)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-EFTV18J\SQLSERVE; integrated security = SSPI; initial Catalog = SistemaDeEsperaPro");
                SqlCommand command = new SqlCommand();

                string sql = "insert into TB_BALCAO(userId, fichaId) Values(@userId, @fichaId)";

                cnn.Open();

                command.Connection = cnn;
                command.CommandText = sql;

                command.Parameters.Add("@userId", SqlDbType.Int).Value = user;
                command.Parameters.Add("@fichaId", SqlDbType.Int).Value = ficha;
                
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                cnn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro insert Balcao: " + ex.Message);
            }
        }
    }
}
